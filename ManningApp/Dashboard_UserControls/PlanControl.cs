using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Data;

namespace ManningApp.Dashboard_UserControls
{
    public partial class PlanControl : UserControl
    {
        public PlanControl()
        {
            InitializeComponent();
        }

        private void PlanControl_Load(object sender, EventArgs e)
        {
            btnSignOn.Enabled = false; //to force the user to refresh 
        }

        private void btnRefresh_signOn_Click(object sender, EventArgs e)
        {
            loadVesselCombobox(); //load data to vessel combobox
            btnRefresh_signOn.Enabled = false;
            btnSignOn.Enabled = true;
        }
        private void btnSearch_signOn_Click(object sender, EventArgs e)
        {
            searchSeafarer_signOn();
        }
        private void seafarerGridView_signOn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idBox_signOn.Text = seafarerGridView_signOn.SelectedRows[0].Cells[0].Value.ToString();
                surnameBox_signOn.Text = seafarerGridView_signOn.SelectedRows[0].Cells[1].Value.ToString();
                othernamesBox_signOn.Text = seafarerGridView_signOn.SelectedRows[0].Cells[2].Value.ToString();
                rankBox_signOn.Text = seafarerGridView_signOn.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void btnSignOn_Click(object sender, EventArgs e)
        {
            string signOnDate = dateTimePicker_signOn.Value.ToString("dd-MM-yyyy");
            string currentVessel = comboVesselName_signOn.Text;
            string idText = idBox_signOn.Text;

            Database database = new Database();
            database.OpenConnection();

            string statement = "UPDATE tblSeafarer " +
                               "SET current_vessel = '" + currentVessel + "', sign_on_date = '" +  signOnDate + "' " +
                               "WHERE id ='" + idText + "'";

            if (currentVessel == "")
            {
                MessageBox.Show("Invalid Input", "Please select a vessel to plan seafarer on", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                string message = String.Format("Plan {0} for {1} on {2}", surnameBox_signOn.Text, currentVessel, signOnDate);
                DialogResult dialog = MessageBox.Show(message, @"Sign On Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(statement, database.connection))
                        {
                            command.ExecuteNonQuery(); //execute database command
                            MessageBox.Show(@"Seafarer successfully planned!", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    searchSeafarer_signOn();
                }
                else
                {
                    return;
                }
            }
            database.CloseConnection();
        }






        

        private void btnSearch_signOff_Click(object sender, EventArgs e)
        {
            searchSeafarer_signOff();
        }
        private void seafarerGridView_signOff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idBox_signOff.Text = seafarerGridView_signOff.SelectedRows[0].Cells[0].Value.ToString();
                surnameBox_signOff.Text = seafarerGridView_signOff.SelectedRows[0].Cells[1].Value.ToString();
                othernamesBox_signOff.Text = seafarerGridView_signOff.SelectedRows[0].Cells[2].Value.ToString();
                rankBox_signOff.Text = seafarerGridView_signOff.SelectedRows[0].Cells[3].Value.ToString();
                currentVesselBox_signOff.Text = seafarerGridView_signOff.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnSignOff_Click(object sender, EventArgs e)
        {
            string signOffDate = dateTimePicker_signOff.Value.ToString("dd-MM-yyyy");
            string idText = idBox_signOn.Text;
            string currentVessel = currentVesselBox_signOff.Text;

            Database database = new Database();
            database.OpenConnection();


            string statement = "UPDATE tblSeafarer " +
                               "SET previous_vessel = current_vessel, current_vessel = NULL, " +
                               "sign_on_date = NULL, sign_off_date = '"+ signOffDate +"' " +
                               "WHERE id ='" + idText + "'";

            string message = String.Format("Off-Sign {0} from {1} on {2}", surnameBox_signOff.Text, currentVessel, signOffDate);
            DialogResult dialog = MessageBox.Show(message, @"Sign Off Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(statement, database.connection))
                    {
                        command.ExecuteNonQuery(); //execute database command
                        MessageBox.Show(@"Seafarer successfully planned!", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                searchSeafarer_signOn();
            }
            else
            {
                return;
            }
            database.CloseConnection();

        }



















        private void searchSeafarer_signOn()
        {
            string searchText = searchBox_signOn.Text;
            Database database = new Database();
            database.OpenConnection();

            string statement = "SELECT id,surname,othernames,rank,previous_vessel,sign_off_date " +
                               "FROM tblSeafarer WHERE surname LIKE '%" + searchText + "%' " +
                               "OR othernames LIKE '%" + searchText + "%'";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(statement, database.connection);
            using (dataAdapter)
            {
                DataTable dataTable = new DataTable("Seafarers");
                dataAdapter.Fill(dataTable);
                seafarerGridView_signOn.DataSource = dataTable;
                DataView dataView = dataTable.DefaultView;
                seafarerGridView_signOn.DataSource = dataView.ToTable();
            }
            database.CloseConnection();
            searchBox_signOn.Select();
        }
        private void searchSeafarer_signOff()
        {
            string searchText = searchBox_signOff.Text;
            Database database = new Database();
            database.OpenConnection();

            string statement = "SELECT id,surname,othernames,rank,current_vessel,sign_on_date " +
                               "FROM tblSeafarer WHERE surname LIKE '%" + searchText + "%' " +
                               "OR othernames LIKE '%" + searchText + "%'";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(statement, database.connection);
            using (dataAdapter)
            {
                DataTable dataTable = new DataTable("Seafarers");
                dataAdapter.Fill(dataTable);
                seafarerGridView_signOff.DataSource = dataTable;
                DataView dataView = dataTable.DefaultView;
                seafarerGridView_signOff.DataSource = dataView.ToTable();
            }
            database.CloseConnection();
            searchBox_signOff.Select();
        }

        private void loadVesselCombobox()
        {
            try
            {
                Database database = new Database();
                database.OpenConnection();

                string statement = "SELECT name FROM tblVessel";
                SQLiteCommand command = new SQLiteCommand(statement, database.connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read()) //loop reader and fill the combobox
                {
                    comboVesselName_signOn.Items.Add(reader["name"].ToString());
                }

                database.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
