namespace ManningApp.Dashboard_UserControls
{
    partial class PlanControl
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
            this.PlanTabControl = new System.Windows.Forms.TabControl();
            this.signOnTab = new System.Windows.Forms.TabPage();
            this.signOnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rankBox = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.btnSignOn = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.seafarerGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.othernamesBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signOffTab = new System.Windows.Forms.TabPage();
            this.suggestionsTab = new System.Windows.Forms.TabPage();
            this.PlanTabControl.SuspendLayout();
            this.signOnTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seafarerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanTabControl
            // 
            this.PlanTabControl.Controls.Add(this.signOnTab);
            this.PlanTabControl.Controls.Add(this.signOffTab);
            this.PlanTabControl.Controls.Add(this.suggestionsTab);
            this.PlanTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanTabControl.Location = new System.Drawing.Point(17, 18);
            this.PlanTabControl.Name = "PlanTabControl";
            this.PlanTabControl.SelectedIndex = 0;
            this.PlanTabControl.Size = new System.Drawing.Size(741, 517);
            this.PlanTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.PlanTabControl.TabIndex = 0;
            // 
            // signOnTab
            // 
            this.signOnTab.Controls.Add(this.signOnDateTimePicker);
            this.signOnTab.Controls.Add(this.rankBox);
            this.signOnTab.Controls.Add(this.btnRefresh);
            this.signOnTab.Controls.Add(this.errorMessage);
            this.signOnTab.Controls.Add(this.btnSignOn);
            this.signOnTab.Controls.Add(this.idBox);
            this.signOnTab.Controls.Add(this.searchBox);
            this.signOnTab.Controls.Add(this.btnSearch);
            this.signOnTab.Controls.Add(this.seafarerGridView);
            this.signOnTab.Controls.Add(this.label4);
            this.signOnTab.Controls.Add(this.label3);
            this.signOnTab.Controls.Add(this.label1);
            this.signOnTab.Controls.Add(this.othernamesBox);
            this.signOnTab.Controls.Add(this.surnameBox);
            this.signOnTab.Controls.Add(this.label2);
            this.signOnTab.Location = new System.Drawing.Point(4, 30);
            this.signOnTab.Name = "signOnTab";
            this.signOnTab.Padding = new System.Windows.Forms.Padding(3);
            this.signOnTab.Size = new System.Drawing.Size(733, 483);
            this.signOnTab.TabIndex = 0;
            this.signOnTab.Text = "Sign On";
            this.signOnTab.ToolTipText = "plan seafarer to go onboard";
            this.signOnTab.UseVisualStyleBackColor = true;
            // 
            // signOnDateTimePicker
            // 
            this.signOnDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOnDateTimePicker.Checked = false;
            this.signOnDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOnDateTimePicker.Location = new System.Drawing.Point(319, 416);
            this.signOnDateTimePicker.MaxDate = new System.DateTime(2199, 12, 31, 0, 0, 0, 0);
            this.signOnDateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.signOnDateTimePicker.Name = "signOnDateTimePicker";
            this.signOnDateTimePicker.Size = new System.Drawing.Size(245, 25);
            this.signOnDateTimePicker.TabIndex = 50;
            // 
            // rankBox
            // 
            this.rankBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rankBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankBox.Location = new System.Drawing.Point(28, 418);
            this.rankBox.Name = "rankBox";
            this.rankBox.ReadOnly = true;
            this.rankBox.Size = new System.Drawing.Size(245, 22);
            this.rankBox.TabIndex = 49;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(592, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 30);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMessage.Location = new System.Drawing.Point(588, 303);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 23);
            this.errorMessage.TabIndex = 47;
            // 
            // btnSignOn
            // 
            this.btnSignOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSignOn.FlatAppearance.BorderSize = 0;
            this.btnSignOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOn.ForeColor = System.Drawing.Color.White;
            this.btnSignOn.Location = new System.Drawing.Point(592, 341);
            this.btnSignOn.Name = "btnSignOn";
            this.btnSignOn.Size = new System.Drawing.Size(88, 71);
            this.btnSignOn.TabIndex = 46;
            this.btnSignOn.Text = "Sign On";
            this.btnSignOn.UseVisualStyleBackColor = false;
            // 
            // idBox
            // 
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.68932F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(592, 420);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(88, 20);
            this.idBox.TabIndex = 44;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(28, 44);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(443, 22);
            this.searchBox.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.68932F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(475, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 22);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // seafarerGridView
            // 
            this.seafarerGridView.AllowUserToAddRows = false;
            this.seafarerGridView.AllowUserToDeleteRows = false;
            this.seafarerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seafarerGridView.CausesValidation = false;
            this.seafarerGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.seafarerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seafarerGridView.Location = new System.Drawing.Point(28, 78);
            this.seafarerGridView.Name = "seafarerGridView";
            this.seafarerGridView.ReadOnly = true;
            this.seafarerGridView.ShowCellErrors = false;
            this.seafarerGridView.ShowRowErrors = false;
            this.seafarerGridView.Size = new System.Drawing.Size(536, 251);
            this.seafarerGridView.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sign On Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Rank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Other Names";
            // 
            // othernamesBox
            // 
            this.othernamesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.othernamesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othernamesBox.Location = new System.Drawing.Point(319, 364);
            this.othernamesBox.Name = "othernamesBox";
            this.othernamesBox.ReadOnly = true;
            this.othernamesBox.Size = new System.Drawing.Size(245, 22);
            this.othernamesBox.TabIndex = 34;
            // 
            // surnameBox
            // 
            this.surnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.Location = new System.Drawing.Point(28, 362);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.ReadOnly = true;
            this.surnameBox.Size = new System.Drawing.Size(245, 22);
            this.surnameBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Surname";
            // 
            // signOffTab
            // 
            this.signOffTab.Location = new System.Drawing.Point(4, 30);
            this.signOffTab.Name = "signOffTab";
            this.signOffTab.Padding = new System.Windows.Forms.Padding(3);
            this.signOffTab.Size = new System.Drawing.Size(733, 483);
            this.signOffTab.TabIndex = 1;
            this.signOffTab.Text = "Sign Off";
            this.signOffTab.ToolTipText = "sign off seafarer to leave";
            this.signOffTab.UseVisualStyleBackColor = true;
            // 
            // suggestionsTab
            // 
            this.suggestionsTab.Location = new System.Drawing.Point(4, 30);
            this.suggestionsTab.Name = "suggestionsTab";
            this.suggestionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.suggestionsTab.Size = new System.Drawing.Size(733, 483);
            this.suggestionsTab.TabIndex = 2;
            this.suggestionsTab.Text = "Suggestions";
            this.suggestionsTab.UseVisualStyleBackColor = true;
            // 
            // PlanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlanTabControl);
            this.Name = "PlanControl";
            this.Size = new System.Drawing.Size(770, 550);
            this.PlanTabControl.ResumeLayout(false);
            this.signOnTab.ResumeLayout(false);
            this.signOnTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seafarerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PlanTabControl;
        private System.Windows.Forms.TabPage signOnTab;
        private System.Windows.Forms.TabPage signOffTab;
        private System.Windows.Forms.TabPage suggestionsTab;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button btnSignOn;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView seafarerGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox othernamesBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rankBox;
        private System.Windows.Forms.DateTimePicker signOnDateTimePicker;
    }
}
