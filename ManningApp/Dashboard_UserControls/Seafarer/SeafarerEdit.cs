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
            
        }

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

        private void btnUpdateSeafarer_Click(object sender, EventArgs e)
        {

        }

        private void searchSeafarer()
        {
            string searchText = searchBox.Text;
            Database database = new Database();
            database.OpenConnection();

            string query = "SELECT surname,othernames,rank,contract,previous_vessel,current_vessel " +
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

    }
}
