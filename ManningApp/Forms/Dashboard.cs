using System;
using System.Drawing;
using System.Windows.Forms;
using ManningApp.Dashboard_UserControls;

namespace ManningApp
{
    public partial class DashboardForm : Form
    {
        private Point lastLocation;


        //make form moveable
        private bool mouseDown;

        //custom form color
        private readonly Color selectedColor = Color.FromArgb(25, 140, 108);
        private readonly Color sideDefault = Color.FromArgb(37, 37, 38);

        public DashboardForm()
        {
            InitializeComponent();

            slidePanel.Height = btnDashboard.Height;
            slidePanel.Top = btnDashboard.Top;
            btnDashboard.BackColor = selectedColor;
        }

        private void DashboardForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DashboardForm_MouseMove(object sender, MouseEventArgs e)
        {
        }



        //close button event
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Close Program?", "Exit", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes) Application.Exit();
            else if (dialog == DialogResult.No) return;
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

            planControl1.BringToFront();
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

            viewControl1.BringToFront();
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

            seafarerControl1.BringToFront();
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

            vesselControl1.BringToFront();
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

            rankControl1.BringToFront();
        }
    }
}