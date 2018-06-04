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
        //custom form color
        Color selectedColor = Color.FromArgb(25, 140, 108);
        Color sideDefault = Color.FromArgb(37, 37, 38);
        
        public DashboardForm()
        {
            InitializeComponent();

            slidePanel.Height = btnDashboard.Height;
            slidePanel.Top = btnDashboard.Top;
            btnDashboard.BackColor = selectedColor;
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


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnDashboard.Height;
            slidePanel.Top = btnDashboard.Top;
            btnDashboard.BackColor = selectedColor;

            //find a better way to do this
            btnPlan.BackColor = sideDefault;
            btnView.BackColor = sideDefault;
            btnSeafarer.BackColor = sideDefault;
            btnVessel.BackColor = sideDefault;
            btnRank.BackColor = sideDefault;
        }
        private void btnPlan_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnPlan.Height;
            slidePanel.Top = btnPlan.Top;
            btnPlan.BackColor = selectedColor;

            //find a better way to do this
            btnDashboard.BackColor = sideDefault;
            btnView.BackColor = sideDefault;
            btnSeafarer.BackColor = sideDefault;
            btnVessel.BackColor = sideDefault;
            btnRank.BackColor = sideDefault;

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnView.Height;
            slidePanel.Top = btnView.Top;
            btnView.BackColor = selectedColor;

            //find a better way to do this
            btnDashboard.BackColor = sideDefault;
            btnPlan.BackColor = sideDefault;
            btnSeafarer.BackColor = sideDefault;
            btnVessel.BackColor = sideDefault;
            btnRank.BackColor = sideDefault;
        }
        private void btnSeafarer_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnSeafarer.Height;
            slidePanel.Top = btnSeafarer.Top;
            btnSeafarer.BackColor = selectedColor;

            //find a better way to do this
            btnDashboard.BackColor = sideDefault;
            btnPlan.BackColor = sideDefault;
            btnView.BackColor = sideDefault;
            btnVessel.BackColor = sideDefault;
            btnRank.BackColor = sideDefault;
        }
        private void btnVessel_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnVessel.Height;
            slidePanel.Top = btnVessel.Top;
            btnVessel.BackColor = selectedColor;

            //find a better way to do this
            btnDashboard.BackColor = sideDefault;
            btnPlan.BackColor = sideDefault;
            btnView.BackColor = sideDefault;
            btnSeafarer.BackColor = sideDefault;
            btnRank.BackColor = sideDefault;
        }
        private void btnRank_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnRank.Height;
            slidePanel.Top = btnRank.Top;
            btnRank.BackColor = selectedColor;

            //find a better way to do this
            btnDashboard.BackColor = sideDefault;
            btnPlan.BackColor = sideDefault;
            btnView.BackColor = sideDefault;
            btnSeafarer.BackColor = sideDefault;
            btnVessel.BackColor = sideDefault;
        }
    }
}
