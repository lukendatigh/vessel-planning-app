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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.seafarerTab = new System.Windows.Forms.TabPage();
            this.vesselTab = new System.Windows.Forms.TabPage();
            this.rankTab = new System.Windows.Forms.TabPage();
            this.planTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.seafarerTab);
            this.tabControl1.Controls.Add(this.vesselTab);
            this.tabControl1.Controls.Add(this.rankTab);
            this.tabControl1.Controls.Add(this.planTab);
            this.tabControl1.Location = new System.Drawing.Point(24, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(390, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // seafarerTab
            // 
            this.seafarerTab.Location = new System.Drawing.Point(4, 22);
            this.seafarerTab.Name = "seafarerTab";
            this.seafarerTab.Padding = new System.Windows.Forms.Padding(3);
            this.seafarerTab.Size = new System.Drawing.Size(780, 405);
            this.seafarerTab.TabIndex = 0;
            this.seafarerTab.Text = "Seafarer";
            this.seafarerTab.UseVisualStyleBackColor = true;
            // 
            // vesselTab
            // 
            this.vesselTab.Location = new System.Drawing.Point(4, 22);
            this.vesselTab.Name = "vesselTab";
            this.vesselTab.Padding = new System.Windows.Forms.Padding(3);
            this.vesselTab.Size = new System.Drawing.Size(780, 405);
            this.vesselTab.TabIndex = 1;
            this.vesselTab.Text = "Vessel";
            this.vesselTab.UseVisualStyleBackColor = true;
            // 
            // rankTab
            // 
            this.rankTab.Location = new System.Drawing.Point(4, 22);
            this.rankTab.Name = "rankTab";
            this.rankTab.Size = new System.Drawing.Size(780, 405);
            this.rankTab.TabIndex = 2;
            this.rankTab.Text = "Rank";
            this.rankTab.UseVisualStyleBackColor = true;
            // 
            // planTab
            // 
            this.planTab.Location = new System.Drawing.Point(4, 22);
            this.planTab.Name = "planTab";
            this.planTab.Size = new System.Drawing.Size(382, 302);
            this.planTab.TabIndex = 3;
            this.planTab.Text = "Plan";
            this.planTab.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage seafarerTab;
        private System.Windows.Forms.TabPage vesselTab;
        private System.Windows.Forms.TabPage rankTab;
        private System.Windows.Forms.TabPage planTab;
    }
}