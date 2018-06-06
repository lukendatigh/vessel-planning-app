using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Data;

namespace ManningApp.Dashboard_UserControls.Seafarer
{
    public partial class SeafarerAdd : UserControl
    {
        public SeafarerAdd()
        {
            InitializeComponent();

        }

        private void SeafarerAdd_Load(object sender, EventArgs e)
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

        private void btnSaveSeafarer_Click(object sender, EventArgs e)
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

            //query string
            string query = "INSERT INTO tblSeafarer(surname, othernames, rank, contract)" +
               "VALUES ('"+surnameField+"', '"+othernamesField+"', " +
               "'"+rankField+"', '"+contractField+"')";

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, database.connection))
                {
                    command.ExecuteNonQuery(); //execute database command
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.CloseConnection();
            }

            database.CloseConnection(); //close connection
            makeEmpty(); //clear boxes
            
        }



        //method toload data into rank combobox
        private void loadRankComboboxData()
        {
            Database database = new Database();
            database.OpenConnection();

            string query = "SELECT rank_name FROM tblRank";

            SQLiteCommand command = new SQLiteCommand(query, database.connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())   //loop reader and fill the combobox
            {
                comboRank.Items.Add(reader["rank_name"].ToString());
            }

        }

        //method to clear boxes method
        private void makeEmpty()
        {
            surnameBox.Text = "";
            othernamesBox.Text = "";
            comboRank.Text = "";
            contractBox.Text = "";
        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }
        private void othernamesBox_TextChanged(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }
        private void contractBox_TextChanged(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }
        private void comboRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }
    }
}
