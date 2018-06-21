namespace ManningApp.Dashboard_UserControls
{
    partial class VesselControl
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
            this.btnAddVessel = new System.Windows.Forms.Button();
            this.btnDeleteVessel = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.vesselGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdateVessel = new System.Windows.Forms.Button();
            this.fleetBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboManningOfficer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vesselGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddVessel
            // 
            this.btnAddVessel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnAddVessel.FlatAppearance.BorderSize = 0;
            this.btnAddVessel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVessel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVessel.ForeColor = System.Drawing.Color.White;
            this.btnAddVessel.Location = new System.Drawing.Point(619, 293);
            this.btnAddVessel.Name = "btnAddVessel";
            this.btnAddVessel.Size = new System.Drawing.Size(88, 30);
            this.btnAddVessel.TabIndex = 44;
            this.btnAddVessel.Text = "Add";
            this.btnAddVessel.UseVisualStyleBackColor = false;
            this.btnAddVessel.Click += new System.EventHandler(this.btnAddVessel_Click);
            // 
            // btnDeleteVessel
            // 
            this.btnDeleteVessel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnDeleteVessel.FlatAppearance.BorderSize = 0;
            this.btnDeleteVessel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVessel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVessel.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVessel.Location = new System.Drawing.Point(619, 365);
            this.btnDeleteVessel.Name = "btnDeleteVessel";
            this.btnDeleteVessel.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteVessel.TabIndex = 43;
            this.btnDeleteVessel.Text = "Delete";
            this.btnDeleteVessel.UseVisualStyleBackColor = false;
            this.btnDeleteVessel.Click += new System.EventHandler(this.btnDeleteVessel_Click);
            // 
            // idBox
            // 
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.68932F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(619, 488);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(88, 20);
            this.idBox.TabIndex = 42;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(55, 42);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(443, 22);
            this.searchBox.TabIndex = 41;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.68932F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(502, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 22);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // vesselGridView
            // 
            this.vesselGridView.AllowUserToAddRows = false;
            this.vesselGridView.AllowUserToDeleteRows = false;
            this.vesselGridView.AllowUserToResizeRows = false;
            this.vesselGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vesselGridView.CausesValidation = false;
            this.vesselGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.vesselGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vesselGridView.Location = new System.Drawing.Point(55, 76);
            this.vesselGridView.Name = "vesselGridView";
            this.vesselGridView.ReadOnly = true;
            this.vesselGridView.ShowCellErrors = false;
            this.vesselGridView.ShowRowErrors = false;
            this.vesselGridView.Size = new System.Drawing.Size(536, 319);
            this.vesselGridView.TabIndex = 39;
            this.vesselGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vesselGridView_CellClick);
            // 
            // btnUpdateVessel
            // 
            this.btnUpdateVessel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnUpdateVessel.FlatAppearance.BorderSize = 0;
            this.btnUpdateVessel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVessel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVessel.ForeColor = System.Drawing.Color.White;
            this.btnUpdateVessel.Location = new System.Drawing.Point(619, 329);
            this.btnUpdateVessel.Name = "btnUpdateVessel";
            this.btnUpdateVessel.Size = new System.Drawing.Size(88, 30);
            this.btnUpdateVessel.TabIndex = 38;
            this.btnUpdateVessel.Text = "Update";
            this.btnUpdateVessel.UseVisualStyleBackColor = false;
            this.btnUpdateVessel.Click += new System.EventHandler(this.btnUpdateVessel_Click);
            // 
            // fleetBox
            // 
            this.fleetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fleetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fleetBox.Location = new System.Drawing.Point(346, 488);
            this.fleetBox.Name = "fleetBox";
            this.fleetBox.Size = new System.Drawing.Size(245, 22);
            this.fleetBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fleet";
            // 
            // comboManningOfficer
            // 
            this.comboManningOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboManningOfficer.FormattingEnabled = true;
            this.comboManningOfficer.Location = new System.Drawing.Point(55, 487);
            this.comboManningOfficer.Name = "comboManningOfficer";
            this.comboManningOfficer.Size = new System.Drawing.Size(243, 24);
            this.comboManningOfficer.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Manning Officer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Type";
            // 
            // typeBox
            // 
            this.typeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.Location = new System.Drawing.Point(346, 435);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(245, 22);
            this.typeBox.TabIndex = 32;
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(55, 433);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(245, 22);
            this.nameBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(619, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 30);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMessage.Location = new System.Drawing.Point(617, 266);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 46;
            // 
            // VesselControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddVessel);
            this.Controls.Add(this.btnDeleteVessel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.vesselGridView);
            this.Controls.Add(this.btnUpdateVessel);
            this.Controls.Add(this.fleetBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboManningOfficer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Name = "VesselControl";
            this.Size = new System.Drawing.Size(770, 550);
            this.Load += new System.EventHandler(this.VesselControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vesselGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVessel;
        private System.Windows.Forms.Button btnDeleteVessel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView vesselGridView;
        private System.Windows.Forms.Button btnUpdateVessel;
        private System.Windows.Forms.TextBox fleetBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboManningOfficer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label errorMessage;
    }
}
