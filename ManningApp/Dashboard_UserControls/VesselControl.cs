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
            loadManningOfficerComboboxData();
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
        private void seafarerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                loadManningOfficerComboboxData(); //load data into manning officer combobox 
                idBox.Text = vesselGridView.SelectedRows[0].Cells[0].Value.ToString();
                nameBox.Text = vesselGridView.SelectedRows[0].Cells[1].Value.ToString();
                typeBox.Text = vesselGridView.SelectedRows[0].Cells[2].Value.ToString();
                comboManningOfficer.Text = vesselGridView.SelectedRows[0].Cells[3].Value.ToString();
                fleetBox.Text = vesselGridView.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                               "OR type LIKE '%" + searchText + "%'" ;
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
            Database database = new Database();
            database.OpenConnection();

            string statement = "SELECT surname FROM tblManningOfficer";
            SQLiteCommand command = new SQLiteCommand(statement, database.connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())   //loop reader and fill the combobox
            {
                comboManningOfficer.Items.Add(reader["surname"].ToString());
            }
            database.CloseConnection();

        }


    }
}
