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

        private void btnRefresh_signOn_Click(object sender, EventArgs e)
        {
            loadVesselCombobox(); //load data to vessel combobox
            btnRefresh_signOn.Enabled = false;
        }

        private void btnSearch_signOn_Click(object sender, EventArgs e)
        {
            searchSeafarer_signOn();
        }
        private void btnSearch_signOff_Click(object sender, EventArgs e)
        {
            searchSeafarer_signOff();
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
