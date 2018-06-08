namespace ManningApp
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.lblEdit = new System.Windows.Forms.Label();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnSeafarer = new System.Windows.Forms.Button();
            this.btnVessel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.seafarerEdit1 = new ManningApp.Dashboard_UserControls.Seafarer.SeafarerControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.slidePanel);
            this.panel1.Controls.Add(this.lblEdit);
            this.panel1.Controls.Add(this.btnRank);
            this.panel1.Controls.Add(this.btnSeafarer);
            this.panel1.Controls.Add(this.btnVessel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnPlan);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 600);
            this.panel1.TabIndex = 0;
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.slidePanel.Location = new System.Drawing.Point(0, 169);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(10, 33);
            this.slidePanel.TabIndex = 5;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEdit.Location = new System.Drawing.Point(13, 326);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(38, 19);
            this.lblEdit.TabIndex = 9;
            this.lblEdit.Text = "EDIT";
            // 
            // btnRank
            // 
            this.btnRank.FlatAppearance.BorderSize = 0;
            this.btnRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRank.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.Image = ((System.Drawing.Image)(resources.GetObject("btnRank.Image")));
            this.btnRank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRank.Location = new System.Drawing.Point(10, 424);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(173, 35);
            this.btnRank.TabIndex = 8;
            this.btnRank.Text = "Rank          ";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnSeafarer
            // 
            this.btnSeafarer.FlatAppearance.BorderSize = 0;
            this.btnSeafarer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeafarer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeafarer.Image = ((System.Drawing.Image)(resources.GetObject("btnSeafarer.Image")));
            this.btnSeafarer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeafarer.Location = new System.Drawing.Point(10, 348);
            this.btnSeafarer.Name = "btnSeafarer";
            this.btnSeafarer.Size = new System.Drawing.Size(173, 35);
            this.btnSeafarer.TabIndex = 7;
            this.btnSeafarer.Text = "Seafarer      ";
            this.btnSeafarer.UseVisualStyleBackColor = true;
            this.btnSeafarer.Click += new System.EventHandler(this.btnSeafarer_Click);
            // 
            // btnVessel
            // 
            this.btnVessel.FlatAppearance.BorderSize = 0;
            this.btnVessel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVessel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVessel.Image = ((System.Drawing.Image)(resources.GetObject("btnVessel.Image")));
            this.btnVessel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVessel.Location = new System.Drawing.Point(10, 386);
            this.btnVessel.Name = "btnVessel";
            this.btnVessel.Size = new System.Drawing.Size(173, 35);
            this.btnVessel.TabIndex = 6;
            this.btnVessel.Text = "Vessel         ";
            this.btnVessel.UseVisualStyleBackColor = true;
            this.btnVessel.Click += new System.EventHandler(this.btnVessel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(13, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU";
            // 
            // btnView
            // 
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(10, 245);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(173, 35);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View           ";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(10, 169);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(173, 35);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard  ";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.FlatAppearance.BorderSize = 0;
            this.btnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnPlan.Image")));
            this.btnPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlan.Location = new System.Drawing.Point(10, 207);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(173, 35);
            this.btnPlan.TabIndex = 0;
            this.btnPlan.Text = "Plan            ";
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 43);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.98058F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vessel Planning";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(916, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(869, 1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(43, 42);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(822, 1);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(43, 42);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // seafarerEdit1
            // 
            this.seafarerEdit1.Location = new System.Drawing.Point(183, 46);
            this.seafarerEdit1.Name = "seafarerEdit1";
            this.seafarerEdit1.Size = new System.Drawing.Size(760, 527);
            this.seafarerEdit1.TabIndex = 9;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.seafarerEdit1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnSeafarer;
        private System.Windows.Forms.Button btnVessel;
        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Label label2;
        private Dashboard_UserControls.Seafarer.SeafarerControl seafarerEdit1;
    }
}