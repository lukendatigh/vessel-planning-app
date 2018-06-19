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
            this.dateTimePicker_signOn = new System.Windows.Forms.DateTimePicker();
            this.rankBox_signOn = new System.Windows.Forms.TextBox();
            this.btnRefresh_signOn = new System.Windows.Forms.Button();
            this.errorMessage_signOn = new System.Windows.Forms.Label();
            this.btnSignOn = new System.Windows.Forms.Button();
            this.idBox_signOn = new System.Windows.Forms.TextBox();
            this.searchBox_signOn = new System.Windows.Forms.TextBox();
            this.btnSearch_signOn = new System.Windows.Forms.Button();
            this.seafarerGridView_signOn = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.othernamesBox_signOn = new System.Windows.Forms.TextBox();
            this.surnameBox_signOn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signOffTab = new System.Windows.Forms.TabPage();
            this.suggestionsTab = new System.Windows.Forms.TabPage();
            this.dateTimePicker_signOff = new System.Windows.Forms.DateTimePicker();
            this.rankBox_signOff = new System.Windows.Forms.TextBox();
            this.btnRefresh_signOff = new System.Windows.Forms.Button();
            this.errorMessage_signOff = new System.Windows.Forms.Label();
            this.btnSignOff = new System.Windows.Forms.Button();
            this.idBox_signOff = new System.Windows.Forms.TextBox();
            this.searchBox_signOff = new System.Windows.Forms.TextBox();
            this.btnSearch_signOff = new System.Windows.Forms.Button();
            this.seafarerGridView_signOff = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.othernamesBox_signOff = new System.Windows.Forms.TextBox();
            this.surnameBox_signOff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PlanTabControl.SuspendLayout();
            this.signOnTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seafarerGridView_signOn)).BeginInit();
            this.signOffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seafarerGridView_signOff)).BeginInit();
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
            this.signOnTab.Controls.Add(this.dateTimePicker_signOn);
            this.signOnTab.Controls.Add(this.rankBox_signOn);
            this.signOnTab.Controls.Add(this.btnRefresh_signOn);
            this.signOnTab.Controls.Add(this.errorMessage_signOn);
            this.signOnTab.Controls.Add(this.btnSignOn);
            this.signOnTab.Controls.Add(this.idBox_signOn);
            this.signOnTab.Controls.Add(this.searchBox_signOn);
            this.signOnTab.Controls.Add(this.btnSearch_signOn);
            this.signOnTab.Controls.Add(this.seafarerGridView_signOn);
            this.signOnTab.Controls.Add(this.label4);
            this.signOnTab.Controls.Add(this.label3);
            this.signOnTab.Controls.Add(this.label1);
            this.signOnTab.Controls.Add(this.othernamesBox_signOn);
            this.signOnTab.Controls.Add(this.surnameBox_signOn);
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
            // dateTimePicker_signOn
            // 
            this.dateTimePicker_signOn.CalendarFont = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_signOn.Checked = false;
            this.dateTimePicker_signOn.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_signOn.Location = new System.Drawing.Point(319, 416);
            this.dateTimePicker_signOn.MaxDate = new System.DateTime(2199, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_signOn.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_signOn.Name = "dateTimePicker_signOn";
            this.dateTimePicker_signOn.Size = new System.Drawing.Size(245, 25);
            this.dateTimePicker_signOn.TabIndex = 50;
            // 
            // rankBox_signOn
            // 
            this.rankBox_signOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rankBox_signOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankBox_signOn.Location = new System.Drawing.Point(28, 418);
            this.rankBox_signOn.Name = "rankBox_signOn";
            this.rankBox_signOn.ReadOnly = true;
            this.rankBox_signOn.Size = new System.Drawing.Size(245, 22);
            this.rankBox_signOn.TabIndex = 49;
            // 
            // btnRefresh_signOn
            // 
            this.btnRefresh_signOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnRefresh_signOn.FlatAppearance.BorderSize = 0;
            this.btnRefresh_signOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_signOn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh_signOn.ForeColor = System.Drawing.Color.White;
            this.btnRefresh_signOn.Location = new System.Drawing.Point(592, 44);
            this.btnRefresh_signOn.Name = "btnRefresh_signOn";
            this.btnRefresh_signOn.Size = new System.Drawing.Size(88, 30);
            this.btnRefresh_signOn.TabIndex = 48;
            this.btnRefresh_signOn.Text = "Refresh";
            this.btnRefresh_signOn.UseVisualStyleBackColor = false;
            // 
            // errorMessage_signOn
            // 
            this.errorMessage_signOn.AutoSize = true;
            this.errorMessage_signOn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.68932F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage_signOn.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMessage_signOn.Location = new System.Drawing.Point(588, 315);
            this.errorMessage_signOn.Name = "errorMessage_signOn";
            this.errorMessage_signOn.Size = new System.Drawing.Size(0, 13);
            this.errorMessage_signOn.TabIndex = 47;
            // 
            // btnSignOn
            // 
            this.btnSignOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSignOn.FlatAppearance.BorderSize = 0;
            this.btnSignOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOn.ForeColor = System.Drawing.Color.White;
            this.btnSignOn.Location = new System.Drawing.Point(592, 341);
            this.btnSignOn.Name = "btnSignOn";
            this.btnSignOn.Size = new System.Drawing.Size(88, 71);
            this.btnSignOn.TabIndex = 46;
            this.btnSignOn.Text = "Sign On";
            this.btnSignOn.UseVisualStyleBackColor = false;
            // 
            // idBox_signOn
            // 
            this.idBox_signOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox_signOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.68932F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox_signOn.Location = new System.Drawing.Point(592, 420);
            this.idBox_signOn.Name = "idBox_signOn";
            this.idBox_signOn.ReadOnly = true;
            this.idBox_signOn.Size = new System.Drawing.Size(88, 20);
            this.idBox_signOn.TabIndex = 44;
            // 
            // searchBox_signOn
            // 
            this.searchBox_signOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox_signOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox_signOn.Location = new System.Drawing.Point(28, 44);
            this.searchBox_signOn.Name = "searchBox_signOn";
            this.searchBox_signOn.Size = new System.Drawing.Size(443, 22);
            this.searchBox_signOn.TabIndex = 43;
            // 
            // btnSearch_signOn
            // 
            this.btnSearch_signOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSearch_signOn.FlatAppearance.BorderSize = 0;
            this.btnSearch_signOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_signOn.Font = new System.Drawing.Font("Segoe UI", 7.68932F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_signOn.ForeColor = System.Drawing.Color.White;
            this.btnSearch_signOn.Location = new System.Drawing.Point(475, 44);
            this.btnSearch_signOn.Name = "btnSearch_signOn";
            this.btnSearch_signOn.Size = new System.Drawing.Size(88, 22);
            this.btnSearch_signOn.TabIndex = 42;
            this.btnSearch_signOn.Text = "Search";
            this.btnSearch_signOn.UseVisualStyleBackColor = false;
            // 
            // seafarerGridView_signOn
            // 
            this.seafarerGridView_signOn.AllowUserToAddRows = false;
            this.seafarerGridView_signOn.AllowUserToDeleteRows = false;
            this.seafarerGridView_signOn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seafarerGridView_signOn.CausesValidation = false;
            this.seafarerGridView_signOn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.seafarerGridView_signOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seafarerGridView_signOn.Location = new System.Drawing.Point(28, 78);
            this.seafarerGridView_signOn.Name = "seafarerGridView_signOn";
            this.seafarerGridView_signOn.ReadOnly = true;
            this.seafarerGridView_signOn.ShowCellErrors = false;
            this.seafarerGridView_signOn.ShowRowErrors = false;
            this.seafarerGridView_signOn.Size = new System.Drawing.Size(536, 251);
            this.seafarerGridView_signOn.TabIndex = 41;
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
            // othernamesBox_signOn
            // 
            this.othernamesBox_signOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.othernamesBox_signOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othernamesBox_signOn.Location = new System.Drawing.Point(319, 364);
            this.othernamesBox_signOn.Name = "othernamesBox_signOn";
            this.othernamesBox_signOn.ReadOnly = true;
            this.othernamesBox_signOn.Size = new System.Drawing.Size(245, 22);
            this.othernamesBox_signOn.TabIndex = 34;
            // 
            // surnameBox_signOn
            // 
            this.surnameBox_signOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameBox_signOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox_signOn.Location = new System.Drawing.Point(28, 362);
            this.surnameBox_signOn.Name = "surnameBox_signOn";
            this.surnameBox_signOn.ReadOnly = true;
            this.surnameBox_signOn.Size = new System.Drawing.Size(245, 22);
            this.surnameBox_signOn.TabIndex = 33;
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
            this.signOffTab.Controls.Add(this.dateTimePicker_signOff);
            this.signOffTab.Controls.Add(this.rankBox_signOff);
            this.signOffTab.Controls.Add(this.btnRefresh_signOff);
            this.signOffTab.Controls.Add(this.errorMessage_signOff);
            this.signOffTab.Controls.Add(this.btnSignOff);
            this.signOffTab.Controls.Add(this.idBox_signOff);
            this.signOffTab.Controls.Add(this.searchBox_signOff);
            this.signOffTab.Controls.Add(this.btnSearch_signOff);
            this.signOffTab.Controls.Add(this.seafarerGridView_signOff);
            this.signOffTab.Controls.Add(this.label6);
            this.signOffTab.Controls.Add(this.label7);
            this.signOffTab.Controls.Add(this.label8);
            this.signOffTab.Controls.Add(this.othernamesBox_signOff);
            this.signOffTab.Controls.Add(this.surnameBox_signOff);
            this.signOffTab.Controls.Add(this.label9);
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
            // dateTimePicker_signOff
            // 
            this.dateTimePicker_signOff.CalendarFont = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_signOff.Checked = false;
            this.dateTimePicker_signOff.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_signOff.Location = new System.Drawing.Point(319, 416);
            this.dateTimePicker_signOff.MaxDate = new System.DateTime(2199, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_signOff.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_signOff.Name = "dateTimePicker_signOff";
            this.dateTimePicker_signOff.Size = new System.Drawing.Size(245, 25);
            this.dateTimePicker_signOff.TabIndex = 65;
            // 
            // rankBox_signOff
            // 
            this.rankBox_signOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rankBox_signOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankBox_signOff.Location = new System.Drawing.Point(28, 418);
            this.rankBox_signOff.Name = "rankBox_signOff";
            this.rankBox_signOff.ReadOnly = true;
            this.rankBox_signOff.Size = new System.Drawing.Size(245, 22);
            this.rankBox_signOff.TabIndex = 64;
            // 
            // btnRefresh_signOff
            // 
            this.btnRefresh_signOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnRefresh_signOff.FlatAppearance.BorderSize = 0;
            this.btnRefresh_signOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_signOff.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh_signOff.ForeColor = System.Drawing.Color.White;
            this.btnRefresh_signOff.Location = new System.Drawing.Point(592, 44);
            this.btnRefresh_signOff.Name = "btnRefresh_signOff";
            this.btnRefresh_signOff.Size = new System.Drawing.Size(88, 30);
            this.btnRefresh_signOff.TabIndex = 63;
            this.btnRefresh_signOff.Text = "Refresh";
            this.btnRefresh_signOff.UseVisualStyleBackColor = false;
            // 
            // errorMessage_signOff
            // 
            this.errorMessage_signOff.AutoSize = true;
            this.errorMessage_signOff.Font = new System.Drawing.Font("Segoe UI Semibold", 7.68932F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage_signOff.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMessage_signOff.Location = new System.Drawing.Point(588, 315);
            this.errorMessage_signOff.Name = "errorMessage_signOff";
            this.errorMessage_signOff.Size = new System.Drawing.Size(0, 13);
            this.errorMessage_signOff.TabIndex = 62;
            // 
            // btnSignOff
            // 
            this.btnSignOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSignOff.FlatAppearance.BorderSize = 0;
            this.btnSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOff.Font = new System.Drawing.Font("Segoe UI Semibold", 11.18447F, System.Drawing.FontStyle.Bold);
            this.btnSignOff.ForeColor = System.Drawing.Color.White;
            this.btnSignOff.Location = new System.Drawing.Point(592, 341);
            this.btnSignOff.Name = "btnSignOff";
            this.btnSignOff.Size = new System.Drawing.Size(88, 71);
            this.btnSignOff.TabIndex = 61;
            this.btnSignOff.Text = "Sign Off";
            this.btnSignOff.UseVisualStyleBackColor = false;
            // 
            // idBox_signOff
            // 
            this.idBox_signOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox_signOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.68932F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox_signOff.Location = new System.Drawing.Point(592, 420);
            this.idBox_signOff.Name = "idBox_signOff";
            this.idBox_signOff.ReadOnly = true;
            this.idBox_signOff.Size = new System.Drawing.Size(88, 20);
            this.idBox_signOff.TabIndex = 60;
            // 
            // searchBox_signOff
            // 
            this.searchBox_signOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox_signOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox_signOff.Location = new System.Drawing.Point(28, 44);
            this.searchBox_signOff.Name = "searchBox_signOff";
            this.searchBox_signOff.Size = new System.Drawing.Size(443, 22);
            this.searchBox_signOff.TabIndex = 59;
            // 
            // btnSearch_signOff
            // 
            this.btnSearch_signOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSearch_signOff.FlatAppearance.BorderSize = 0;
            this.btnSearch_signOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_signOff.Font = new System.Drawing.Font("Segoe UI", 7.68932F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_signOff.ForeColor = System.Drawing.Color.White;
            this.btnSearch_signOff.Location = new System.Drawing.Point(475, 44);
            this.btnSearch_signOff.Name = "btnSearch_signOff";
            this.btnSearch_signOff.Size = new System.Drawing.Size(88, 22);
            this.btnSearch_signOff.TabIndex = 58;
            this.btnSearch_signOff.Text = "Search";
            this.btnSearch_signOff.UseVisualStyleBackColor = false;
            // 
            // seafarerGridView_signOff
            // 
            this.seafarerGridView_signOff.AllowUserToAddRows = false;
            this.seafarerGridView_signOff.AllowUserToDeleteRows = false;
            this.seafarerGridView_signOff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seafarerGridView_signOff.CausesValidation = false;
            this.seafarerGridView_signOff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.seafarerGridView_signOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seafarerGridView_signOff.Location = new System.Drawing.Point(28, 78);
            this.seafarerGridView_signOff.Name = "seafarerGridView_signOff";
            this.seafarerGridView_signOff.ReadOnly = true;
            this.seafarerGridView_signOff.ShowCellErrors = false;
            this.seafarerGridView_signOff.ShowRowErrors = false;
            this.seafarerGridView_signOff.Size = new System.Drawing.Size(536, 251);
            this.seafarerGridView_signOff.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Sign Off Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Rank";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Other Names";
            // 
            // othernamesBox_signOff
            // 
            this.othernamesBox_signOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.othernamesBox_signOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othernamesBox_signOff.Location = new System.Drawing.Point(319, 364);
            this.othernamesBox_signOff.Name = "othernamesBox_signOff";
            this.othernamesBox_signOff.ReadOnly = true;
            this.othernamesBox_signOff.Size = new System.Drawing.Size(245, 22);
            this.othernamesBox_signOff.TabIndex = 53;
            // 
            // surnameBox_signOff
            // 
            this.surnameBox_signOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameBox_signOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox_signOff.Location = new System.Drawing.Point(28, 362);
            this.surnameBox_signOff.Name = "surnameBox_signOff";
            this.surnameBox_signOff.ReadOnly = true;
            this.surnameBox_signOff.Size = new System.Drawing.Size(245, 22);
            this.surnameBox_signOff.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "Surname";
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
            ((System.ComponentModel.ISupportInitialize)(this.seafarerGridView_signOn)).EndInit();
            this.signOffTab.ResumeLayout(false);
            this.signOffTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seafarerGridView_signOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PlanTabControl;
        private System.Windows.Forms.TabPage signOnTab;
        private System.Windows.Forms.TabPage signOffTab;
        private System.Windows.Forms.TabPage suggestionsTab;
        private System.Windows.Forms.Button btnRefresh_signOn;
        private System.Windows.Forms.Label errorMessage_signOn;
        private System.Windows.Forms.Button btnSignOn;
        private System.Windows.Forms.TextBox idBox_signOn;
        private System.Windows.Forms.TextBox searchBox_signOn;
        private System.Windows.Forms.Button btnSearch_signOn;
        private System.Windows.Forms.DataGridView seafarerGridView_signOn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox othernamesBox_signOn;
        private System.Windows.Forms.TextBox surnameBox_signOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rankBox_signOn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_signOn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_signOff;
        private System.Windows.Forms.TextBox rankBox_signOff;
        private System.Windows.Forms.Button btnRefresh_signOff;
        private System.Windows.Forms.Label errorMessage_signOff;
        private System.Windows.Forms.Button btnSignOff;
        private System.Windows.Forms.TextBox idBox_signOff;
        private System.Windows.Forms.TextBox searchBox_signOff;
        private System.Windows.Forms.Button btnSearch_signOff;
        private System.Windows.Forms.DataGridView seafarerGridView_signOff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox othernamesBox_signOff;
        private System.Windows.Forms.TextBox surnameBox_signOff;
        private System.Windows.Forms.Label label9;
    }
}
