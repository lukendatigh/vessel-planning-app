namespace ManningApp.Dashboard_UserControls
{
    partial class ViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewTabControl = new System.Windows.Forms.TabControl();
            this.onboardTab = new System.Windows.Forms.TabPage();
            this.onleaveTab = new System.Windows.Forms.TabPage();
            this.vesselTab = new System.Windows.Forms.TabPage();
            this.rankTab = new System.Windows.Forms.TabPage();
            this.ViewTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewTabControl
            // 
            this.ViewTabControl.Controls.Add(this.onboardTab);
            this.ViewTabControl.Controls.Add(this.onleaveTab);
            this.ViewTabControl.Controls.Add(this.vesselTab);
            this.ViewTabControl.Controls.Add(this.rankTab);
            this.ViewTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTabControl.Location = new System.Drawing.Point(17, 18);
            this.ViewTabControl.Name = "ViewTabControl";
            this.ViewTabControl.SelectedIndex = 0;
            this.ViewTabControl.Size = new System.Drawing.Size(741, 517);
            this.ViewTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ViewTabControl.TabIndex = 1;
            // 
            // onboardTab
            // 
            this.onboardTab.Location = new System.Drawing.Point(4, 30);
            this.onboardTab.Name = "onboardTab";
            this.onboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.onboardTab.Size = new System.Drawing.Size(733, 483);
            this.onboardTab.TabIndex = 0;
            this.onboardTab.Text = "Onboard";
            this.onboardTab.ToolTipText = "view seafarer who are onboard vessels";
            this.onboardTab.UseVisualStyleBackColor = true;
            // 
            // onleaveTab
            // 
            this.onleaveTab.Location = new System.Drawing.Point(4, 30);
            this.onleaveTab.Name = "onleaveTab";
            this.onleaveTab.Padding = new System.Windows.Forms.Padding(3);
            this.onleaveTab.Size = new System.Drawing.Size(733, 483);
            this.onleaveTab.TabIndex = 1;
            this.onleaveTab.Text = "On Leave";
            this.onleaveTab.ToolTipText = "view seafarers who are on leave";
            this.onleaveTab.UseVisualStyleBackColor = true;
            // 
            // vesselTab
            // 
            this.vesselTab.Location = new System.Drawing.Point(4, 30);
            this.vesselTab.Name = "vesselTab";
            this.vesselTab.Padding = new System.Windows.Forms.Padding(3);
            this.vesselTab.Size = new System.Drawing.Size(733, 483);
            this.vesselTab.TabIndex = 2;
            this.vesselTab.Text = "By Vessel";
            this.vesselTab.ToolTipText = "view seafarers on a vessel";
            this.vesselTab.UseVisualStyleBackColor = true;
            // 
            // rankTab
            // 
            this.rankTab.Location = new System.Drawing.Point(4, 30);
            this.rankTab.Name = "rankTab";
            this.rankTab.Padding = new System.Windows.Forms.Padding(3);
            this.rankTab.Size = new System.Drawing.Size(733, 483);
            this.rankTab.TabIndex = 3;
            this.rankTab.Text = "By Rank";
            this.rankTab.ToolTipText = "view seafarers in a rank";
            this.rankTab.UseVisualStyleBackColor = true;
            // 
            // ViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewTabControl);
            this.Name = "ViewControl";
            this.Size = new System.Drawing.Size(770, 550);
            this.ViewTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ViewTabControl;
        private System.Windows.Forms.TabPage onboardTab;
        private System.Windows.Forms.TabPage onleaveTab;
        private System.Windows.Forms.TabPage vesselTab;
        private System.Windows.Forms.TabPage rankTab;
    }
}
