using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Data;
using System.Data;

namespace ManningApp.Dashboard_UserControls
{
    public partial class RankControl : UserControl
    {
        public RankControl()
        {
            InitializeComponent();
        }
        private void RankControl_Load(object sender, EventArgs e)
        {
            nameBox.Select();//focus on name box

            //initialize tooltips on control hovers
            ToolTip tooltip = new ToolTip();
            tooltip.IsBalloon = true;
            tooltip.SetToolTip(nameBox, "enter rank name");
            tooltip.SetToolTip(shortnameBox, "enter short rank name");
            tooltip.SetToolTip(comboRankType, "select rank type");
            tooltip.SetToolTip(comboDaysOn, "select days onboard for rank");
            tooltip.SetToolTip(comboDaysOff, "select days onshore for rank");

            btnAddRank.Enabled = false;
            btnUpdateRank.Enabled = false;
            btnDeleteRank.Enabled = false;
        }

        /*******************************************
        *               SEARCHING                 *
        *******************************************/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchRank();
        }
        
        /*******************************************
        *            RECORD SELECTION             *
        *******************************************/
        private void rankGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idBox.Text = rankGridView.SelectedRows[0].Cells[0].Value.ToString();
                nameBox.Text = rankGridView.SelectedRows[0].Cells[1].Value.ToString();
                comboDaysOn.Text = rankGridView.SelectedRows[0].Cells[2].Value.ToString();
                comboDaysOff.Text = rankGridView.SelectedRows[0].Cells[3].Value.ToString();
                shortnameBox.Text = rankGridView.SelectedRows[0].Cells[4].Value.ToString();
                comboRankType.Text = rankGridView.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        /*******************************************
         *                ADDING                   *
         *******************************************/
        private void btnAddRank_Click(object sender, EventArgs e)
        {
            //connect to database
            Database database = new Database();
            database.OpenConnection(); // open connection

            //texbox items to string
            var nameField = nameBox.Text.Trim();
            var shortNameField = shortnameBox.Text.Trim();
            var rankTypeField = comboRankType.Text;
            var daysOnField = comboDaysOn.Text.Trim();
            var daysOffField = comboDaysOff.Text.Trim();

            //checking for empty fields 
            if (nameField == "" || shortNameField == "" ||
                daysOnField == "" || daysOffField == "" || rankTypeField == "")
            {
                errorMessage.Text = @"some fields seem empty";
                return;
            }

            //statement string
            string statement = "INSERT INTO tblRank(name, type, min_days_on, min_days_off, short)" +
                               "VALUES ('" + nameField + "', '" + rankTypeField + "', " +
                               "'" + daysOnField + "', '" + daysOffField + "', '" + shortNameField + "')";

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
                searchRank();
                makeEmpty();
            }
            database.CloseConnection();
        }

        /*******************************************
        *                UPDATING                  *
        ********************************************/
        private void btnUpdateRank_Click(object sender, EventArgs e)
        {

            //texbox items to string
            var nameField = nameBox.Text.Trim();
            var shortNameField = shortnameBox.Text.Trim();
            var rankTypeField = comboRankType.Text;
            var daysOnField = comboDaysOn.Text.Trim();
            var daysOffField = comboDaysOff.Text.Trim();
            var idField = idBox.Text;

            Database database = new Database();
            database.OpenConnection();

            string statement = "UPDATE tblRank " +
                               "SET name = '" + nameField + "', type = '" + rankTypeField + "'," +
                               "min_days_on = '" + daysOnField + "', min_days_off = '" + daysOffField + "', " +
                               "short = '" + shortNameField + "' WHERE id ='" + idField + "'";
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
            
            searchRank();
            makeEmpty();
            database.CloseConnection();
        }
        
        /*******************************************
        *                DELETING                  *
        ********************************************/
        private void btnDeleteRank_Click(object sender, EventArgs e)
        {
            string idText = idBox.Text;
            string name = nameBox.Text;

            Database database = new Database();
            database.OpenConnection();
            string statement = "DELETE FROM tblRank WHERE id = '" + idText + "'";

            string message = String.Format("Are you sure you want to delete the {0} rank?", name);
            DialogResult dialog = MessageBox.Show(message, @"Deletion", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(statement, database.connection))
                    {
                        command.ExecuteNonQuery(); //execute database command
                        MessageBox.Show(@"Successfully Deleted!", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        searchRank();
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


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            loadComboBoxData();

            btnAddRank.Enabled = true;
            btnUpdateRank.Enabled = true;
            btnDeleteRank.Enabled = true;
        }
        

        private void loadComboBoxData()
        {
            //rank type combobox
            try
            {
                Database database = new Database();
                database.OpenConnection();

                string statement = "SELECT DISTINCT type FROM tblRank";
                SQLiteCommand command = new SQLiteCommand(statement, database.connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read()) //loop reader and fill the combobox
                {
                        comboRankType.Items.Add(reader["type"].ToString());
                }
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //days on combobox
            try
            {
                Database database = new Database();
                database.OpenConnection();

                string statement = "SELECT DISTINCT min_days_on FROM tblRank";
                SQLiteCommand command = new SQLiteCommand(statement, database.connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read()) //loop reader and fill the combobox
                {
                    comboDaysOn.Items.Add(reader["min_days_on"].ToString());
                }
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //days off combobox
            try
            {
                Database database = new Database();
                database.OpenConnection();

                string statement = "SELECT DISTINCT min_days_off FROM tblRank";
                SQLiteCommand command = new SQLiteCommand(statement, database.connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read()) //loop reader and fill the combobox
                {
                    comboDaysOff.Items.Add(reader["min_days_off"].ToString());
                }
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        private void searchRank()
        {
            string searchText = searchBox.Text;
            Database database = new Database();
            database.OpenConnection();

            string statement = "SELECT id,name,min_days_on,min_days_off,short,type " +
                               "FROM tblRank WHERE name LIKE '%" + searchText + "%' " +
                               "OR short LIKE '%" + searchText + "%'";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(statement, database.connection);
            using (dataAdapter)
            {
                DataTable dataTable = new DataTable("Ranks");
                dataAdapter.Fill(dataTable);
                rankGridView.DataSource = dataTable;
                DataView dataView = dataTable.DefaultView;
                rankGridView.DataSource = dataView.ToTable();
            }
            database.CloseConnection();
            searchBox.Select();
        }

        private void makeEmpty()
        {
            nameBox.Text = "";
            idBox.Text = "";
            shortnameBox.Text = "";
            comboDaysOn.Text = "";
            comboDaysOff.Text = "";
            comboRankType.Text = "";
        }


    }
}
