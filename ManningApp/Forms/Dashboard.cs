using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManningApp
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        //make form moveable
        private bool mouseDown;
        private Point lastLocation;
        private void DashboardForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void DashboardForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) 
                    + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }



        //close button event
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
