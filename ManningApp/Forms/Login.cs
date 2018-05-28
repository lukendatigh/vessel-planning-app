using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Data;

namespace ManningApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //select nameBox
            nameBox.Select();

            //initialize tooltips on control hovers
            ToolTip tooltip = new ToolTip();
            tooltip.IsBalloon = true;
            tooltip.SetToolTip(nameBox, "enter username(surname)");
            tooltip.SetToolTip(passwordBox, "enter password");   
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string nameField = nameBox.Text;
            string passwordField = passwordBox.Text;

            //checking if fields are empty
            if (nameField == "" || passwordField == "")
            {
                errorMessage.Text = "some fields seem empty";
                return;
            }

            //connect to database
            Database database = new Database();
            database.OpenConnection();

            //query string
            string query = "SELECT * FROM tblManningOfficer " +
                "WHERE manning_officer_surname = '"+nameField+"' AND password = '"+passwordField+"'";
            
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, database.connection))
                {                    
                    
                    /*
                    command.CommandText = query;
                    command.Connection = database.con; */

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int loginValid = 0; //to store the state of correct login details
                        if (reader.Read())
                        {
                            loginValid ++;
                        }
                        if (loginValid == 1) //open main dashboard form when login details are correct
                        {
                            DashboardForm dashboard = new DashboardForm();
                            dashboard.Show();
                            this.Hide();
                            database.CloseConnection(); //close connection
                            return;
                        }
                        else //when incorrect details are entered
                        {
                            errorMessage.Text = "incorrect username or password";
                            database.CloseConnection(); //close connection
                            return;
                        }
                    }
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.CloseConnection();
            } 
            
            
        }
        

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }
    }
}
