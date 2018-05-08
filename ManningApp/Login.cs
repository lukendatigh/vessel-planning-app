using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tooltip.SetToolTip(nameBox, "enter surname");
            tooltip.SetToolTip(passwordBox, "enter password");

            //Database connection

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
