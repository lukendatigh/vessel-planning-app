using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Data;

namespace ManningApp.Dashboard_UserControls.Seafarer
{
    public partial class SeafarerEdit : UserControl
    {
        public SeafarerEdit()
        {
            InitializeComponent();
        }
        private void SeafarerEdit_Load(object sender, EventArgs e)
        {
            loadRankComboboxData(); //load data into rank combobox 
        }

        /*******************************************
         *               SEARCHING                 *
         *******************************************/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchSeafarer();
        }
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                searchSeafarer();
            }
            
        }

        /*******************************************
         *                EDITING                  *
         *******************************************/
        private void seafarerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateSeafarer_Click(object sender, EventArgs e)
        {

        }

        //method to search for seafarer an display in data grid view
        private void searchSeafarer()
        {
            string searchText = searchBox.Text;
            Database database = new Database();
            database.OpenConnection();

            string query = "SELECT id,surname,othernames,rank,contract,previous_vessel,current_vessel " +
                "FROM tblSeafarer WHERE surname LIKE '%" + searchText + "%' OR othernames LIKE '%" + searchText + "%'";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, database.connection);
            using (dataAdapter)
            {
                DataTable dataTable = new DataTable("Seafarers");
                dataAdapter.Fill(dataTable);
                seafarerGridView.DataSource = dataTable;
                DataView dataView = dataTable.DefaultView;
                seafarerGridView.DataSource = dataView.ToTable();
            }
            database.CloseConnection();
        }

        //method to load data into rank combobox
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

    }
}
