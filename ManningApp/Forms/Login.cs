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
            bool loginValid = false; 
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

            try
            {                
                string query = ""; //query declaration
                
                
                SQLiteCommand command = new SQLiteCommand();
                command.CommandText = query;
                command.Connection = database.con;
                command.ExecuteNonQuery(); //executing the querry

                //I think some things should come here


                if (loginValid)
                {
                    this.Close();
                    new DashboardForm();
                }
                else
                {
                    errorMessage.Text = "invalid password";
                }

                database.CloseConnection();
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
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
