using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using Data;

namespace ManningApp.Dashboard_UserControls
{
    public partial class VesselControl : UserControl
    {
        public VesselControl()
        {
            InitializeComponent();
        }
        private void VesselControl_Load(object sender, EventArgs e)
        {
            nameBox.Select();//focus on name box
            
            //initialize tooltips on control hovers
            ToolTip tooltip = new ToolTip();
            tooltip.IsBalloon = true;
            tooltip.SetToolTip(nameBox, "enter vessel name");
            tooltip.SetToolTip(typeBox, "enter vessel type");
            tooltip.SetToolTip(comboManningOfficer, "select manning officer");
            tooltip.SetToolTip(fleetBox, "enter fleet");

            btnAddVessel.Enabled = false;
            btnUpdateVessel.Enabled = false;
            btnDeleteVessel.Enabled = false;
        }

        /*******************************************
        *               SEARCHING                 *
        *******************************************/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchVessel(); //this method calls a sexy block of code that does as is
        }

        /*******************************************
        *            RECORD SELECTION             *
        *******************************************/
        private void vesselGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idBox.Text = vesselGridView.SelectedRows[0].Cells[0].Value.ToString();
                nameBox.Text = vesselGridView.SelectedRows[0].Cells[1].Value.ToString();
                typeBox.Text = vesselGridView.SelectedRows[0].Cells[2].Value.ToString();
                comboManningOfficer.Text = vesselGridView.SelectedRows[0].Cells[3].Value.ToString();
                fleetBox.Text = vesselGridView.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /*******************************************
         *                ADDING                   *
         *******************************************/
        private void btnAddVessel_Click(object sender, EventArgs e)
        {
            //connect to database
            Database database = new Database();
            database.OpenConnection(); // open connection

            //texbox items to string
            var nameField = nameBox.Text.Trim();
            var typeField = typeBox.Text.Trim();
            var manningOfficerField = comboManningOfficer.Text;
            var fleetField = fleetBox.Text.Trim();

            //checking for empty fields 
            if (nameField == "" || typeField == "" ||
                manningOfficerField== "" || fleetField == "")
            {
                errorMessage.Text = @"some fields seem empty";
                return;
            }

            //statement string
            string statement = "INSERT INTO tblVessel(name, type, manning_officer, fleet)" +
                               "VALUES ('" + nameField + "', '" + typeField + "', " +
                               "'" + manningOfficerField + "', '" + fleetField + "')";

            string message = String.Format("Add {0} to records?", nameField);
            DialogResult dialog = MessageBox.Show(message, @"Addition", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(statement, database.connection))
                    {
                        command.ExecuteNonQuery(); //execute database command
                        MessageBox.Show(@"Successfully added!", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                searchVessel();
                makeEmpty();
            }
            database.CloseConnection();
        }
        
        /*******************************************
        *                UPDATING                  *
        ********************************************/
        private void btnUpdateVessel_Click(object sender, EventArgs e)
        {
            string idText = idBox.Text;
            string nameText = nameBox.Text.Trim();
            string typeText = typeBox.Text.Trim();
            string manningOfficerText = comboManningOfficer.Text;
            string fleetText = fleetBox.Text.Trim();
            Database database = new Database();
            database.OpenConnection();

            string statement = "UPDATE tblVessel " +
                               "SET name = '" + nameText + "', type = '" + typeText + "'," +
                               "manning_officer= '" + manningOfficerText + "', fleet = '" + fleetText + "' " +
                               "WHERE id ='" + idText + "'";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(statement, database.connection))
                {
                    command.ExecuteNonQuery(); //execute database command
                    MessageBox.Show(@"Successfully updated!", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            database.CloseConnection();
            searchVessel();
            makeEmpty();
        }

        /*******************************************
        *                DELETING                  *
        ********************************************/
        private void btnDeleteVessel_Click(object sender, EventArgs e)
        {
            string idText = idBox.Text;
            string name = nameBox.Text;

            Database database = new Database();
            database.OpenConnection();
            string statement = "DELETE FROM tblVessel WHERE id = '" + idText + "'";

            string message = String.Format("Are you sure you want to delete {0}?", name);
            DialogResult dialog = MessageBox.Show(message, @"Deletion", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(statement, database.connection))
                    {
                        command.ExecuteNonQuery(); //execute database command
                        MessageBox.Show(@"Successfully Deleted!", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        searchVessel();
                        makeEmpty();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            database.CloseConnection();
            
        }

        

        //method to search for vessel and display in data grid view
        private void searchVessel()
        {
            string searchText = searchBox.Text;
            Database database = new Database();
            database.OpenConnection();

            string statement = "SELECT id,name,type,manning_officer,fleet " +
                               "FROM tblVessel WHERE name LIKE '%" + searchText + "%' " +
                               "OR fleet LIKE '%" + searchText + "%'" +
                               "OR type LIKE '%" + searchText + "%'";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(statement, database.connection);
            using (dataAdapter)
            {
                DataTable dataTable = new DataTable("Vessels");
                dataAdapter.Fill(dataTable);
                vesselGridView.DataSource = dataTable;
                DataView dataView = dataTable.DefaultView;
                vesselGridView.DataSource = dataView.ToTable();
            }
            database.CloseConnection();
            searchBox.Select();
        }

        //method to load data into rank combobox
        private void loadManningOfficerComboboxData()
        {
            try
            {
                Database database = new Database();
                database.OpenConnection();

                string statement = "SELECT surname FROM tblManningOfficer";
                SQLiteCommand command = new SQLiteCommand(statement, database.connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read()) //loop reader and fill the combobox
                {
                    comboManningOfficer.Items.Add(reader["surname"].ToString());
                }
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadManningOfficerComboboxData();
            btnRefresh.Enabled = false;

            btnAddVessel.Enabled = true;
            btnUpdateVessel.Enabled = true;
            btnDeleteVessel.Enabled = true;
        }

        private void makeEmpty()
        {
            nameBox.Text = "";
            typeBox.Text = "";
            comboManningOfficer.Text = "";
            fleetBox.Text = "";
        }
    }
}
