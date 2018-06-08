using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using Data;

namespace ManningApp.Dashboard_UserControls.Seafarer
{
    public partial class SeafarerControl : UserControl
    {
        public SeafarerControl()
        {
            InitializeComponent();
        }

        /*******************************************
         *               SEARCHING                 *
         *******************************************/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchSeafarer();
        }

        /*******************************************
         *            RECORD SELECTION             *
         *******************************************/
        private void seafarerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                loadRankComboboxData(); //load data into rank combobox 
                idBox.Text = seafarerGridView.SelectedRows[0].Cells[0].Value.ToString();
                surnameBox.Text = seafarerGridView.SelectedRows[0].Cells[1].Value.ToString();
                othernamesBox.Text = seafarerGridView.SelectedRows[0].Cells[2].Value.ToString();
                comboRank.Text = seafarerGridView.SelectedRows[0].Cells[3].Value.ToString();
                contractBox.Text = seafarerGridView.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /*******************************************
         *                 ADDING                  *
         *******************************************/
        private void btnAddSeafarer_Click(object sender, EventArgs e)
        {
            //connect to database
            Database database = new Database();
            database.OpenConnection(); // open connection

            //texbox items to string
            string surnameField, othernamesField, rankField, contractField;
            surnameField = surnameBox.Text.Trim();
            othernamesField = othernamesBox.Text.Trim();
            rankField = comboRank.Text;
            contractField = contractBox.Text.Trim();

            //checking for empty fields 
            if (surnameField == "" || othernamesField == "" ||
                rankField == "" || contractField == "")
            {
                errorMessage.Text = "some fields seem empty";
                return;
            }

            //statement string
            string statement = "INSERT INTO tblSeafarer(surname, othernames, rank, contract)" +
                           "VALUES ('" + surnameField + "', '" + othernamesField + "', " +
                           "'" + rankField + "', '" + contractField + "')";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(statement, database.connection))
                {
                    command.ExecuteNonQuery(); //execute database command
                }
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //database.CloseConnection();
            }
            database.CloseConnection(); //close connection
            searchSeafarer();
            makeEmpty(); //clear boxes            
        }

        /*******************************************
         *                UPDATING                 *
         *******************************************/
        private void btnUpdateSeafarer_Click(object sender, EventArgs e)
        {
            string idText = idBox.Text;
            string surnameText = surnameBox.Text;
            string othernamesText = othernamesBox.Text;
            string rankText = comboRank.Text;
            string contractText = contractBox.Text;
            Database database = new Database();
            database.OpenConnection();

            string statement = "UPDATE tblSeafarer " +
                "SET surname = '"+ surnameText +"', othernames = '"+ othernamesText +"'," +
                "rank = '"+ rankText +"', contract = '"+ contractText +"' " +
                "WHERE id ='" + idText + "'";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(statement, database.connection))
                {
                    command.ExecuteNonQuery(); //execute database command
                    MessageBox.Show("Successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchSeafarer();                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //database.CloseConnection();
            }
            database.CloseConnection(); //close connection
        }

        /*******************************************
         *               DELETING                  *
         *******************************************/
        private void btnDeleteSeafarer_Click(object sender, EventArgs e)
        {
            string idText = idBox.Text;
            string name = surnameBox.Text + ", " + othernamesBox.Text;

            Database database = new Database();
            database.OpenConnection();
            string statement = "DELETE FROM tblSeafarer WHERE id = '" + idText + "'";

            string message = String.Format("Are you sure you want to delete {0}", name);
            DialogResult dialog = MessageBox.Show(message, "Deletion", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(statement, database.connection))
                    {
                        command.ExecuteNonQuery(); //execute database command
                        MessageBox.Show("Successfully Deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        searchSeafarer();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //database.CloseConnection();
                }
                database.CloseConnection(); //close connection
            }
            else if (dialog == DialogResult.No) return;
        }

        

        //method to search for seafarer and display in data grid view
        private void searchSeafarer()
        {
            string searchText = searchBox.Text;
            Database database = new Database();
            database.OpenConnection();

            string statement = "SELECT id,surname,othernames,rank,contract,previous_vessel,current_vessel " +
                "FROM tblSeafarer WHERE surname LIKE '%" + searchText + "%' " +
                               "OR othernames LIKE '%" + searchText + "%'" +
                               "OR rank LIKE '%" + searchText + "%'";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(statement, database.connection);
            using (dataAdapter)
            {
                DataTable dataTable = new DataTable("Seafarers");
                dataAdapter.Fill(dataTable);
                seafarerGridView.DataSource = dataTable;
                DataView dataView = dataTable.DefaultView;
                seafarerGridView.DataSource = dataView.ToTable();
            }
            database.CloseConnection();

            searchBox.Select();
        }

        //method to load data into rank combobox
        private void loadRankComboboxData()
        {
            Database database = new Database();
            database.OpenConnection();

            string statement = "SELECT name FROM tblRank";
            SQLiteCommand command = new SQLiteCommand(statement, database.connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())   //loop reader and fill the combobox
            {
                comboRank.Items.Add(reader["name"].ToString());
            }
            database.CloseConnection();

        }

        private void makeEmpty()
        {
            surnameBox.Text = "";
            othernamesBox.Text = "";
            comboRank.Text = "";
            contractBox.Text = "";
        }
        private void SeafarerControl_Load_1(object sender, EventArgs e)
        {
            //focus on surname box
            surnameBox.Select();

            //initialize tooltips on control hovers
            ToolTip tooltip = new ToolTip();
            tooltip.IsBalloon = true;
            tooltip.SetToolTip(surnameBox, "enter seafarer's surname");
            tooltip.SetToolTip(othernamesBox, "enter seafarer's other names");
            tooltip.SetToolTip(comboRank, "select seafarer's current rank");
            tooltip.SetToolTip(contractBox, "enter seafarer's current contract");

            loadRankComboboxData(); //load data to rank combobox
        }


    }
}
