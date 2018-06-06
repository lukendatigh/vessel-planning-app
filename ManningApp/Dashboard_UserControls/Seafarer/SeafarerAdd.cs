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
        }

        private void btnSaveSeafarer_Click(object sender, EventArgs e)
        {
            //connect to database
            Database database = new Database();
            database.OpenConnection();

            //texbox items to string
            string surnameField, othernamesField, rankField, contractField;
            surnameField = surnameBox.Text.Trim();
            othernamesField = othernamesBox.Text.Trim();
            rankField = comboRank.Text;
            contractField = contractBox.Text.Trim();
            

            //checking for empty fields 
            if (surnameField == "" || othernamesField == "" ||
                rankField == "" && contractField == "")
            {
                errorMessage.Text = "some fields seem empty";
                return;
            }

            //query string
            string query = "INSERT INTO tblSeafarer(surname, othernames, rank, contract)" +
               "VALUES ('"+surnameField+"', '"+othernamesField+"', " +
               "'"+rankField+"', '"+contractField+"')";

            SQLiteCommand command = new SQLiteCommand(query, database.connection);
            command.ExecuteNonQuery(); //execute adtabase command

            database.CloseConnection(); //close connection


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
