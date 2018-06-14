namespace ManningApp.Dashboard_UserControls
{
    partial class RankControl
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
            this.btnAddRank = new System.Windows.Forms.Button();
            this.btnDeleteRank = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rankGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdateRank = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRankType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shortnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDaysOn = new System.Windows.Forms.ComboBox();
            this.comboDaysOff = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRank
            // 
            this.btnAddRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnAddRank.FlatAppearance.BorderSize = 0;
            this.btnAddRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRank.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRank.ForeColor = System.Drawing.Color.White;
            this.btnAddRank.Location = new System.Drawing.Point(602, 293);
            this.btnAddRank.Name = "btnAddRank";
            this.btnAddRank.Size = new System.Drawing.Size(88, 30);
            this.btnAddRank.TabIndex = 44;
            this.btnAddRank.Text = "Add";
            this.btnAddRank.UseVisualStyleBackColor = false;
            this.btnAddRank.Click += new System.EventHandler(this.btnAddRank_Click);
            // 
            // btnDeleteRank
            // 
            this.btnDeleteRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnDeleteRank.FlatAppearance.BorderSize = 0;
            this.btnDeleteRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRank.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRank.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRank.Location = new System.Drawing.Point(602, 365);
            this.btnDeleteRank.Name = "btnDeleteRank";
            this.btnDeleteRank.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteRank.TabIndex = 43;
            this.btnDeleteRank.Text = "Delete";
            this.btnDeleteRank.UseVisualStyleBackColor = false;
            this.btnDeleteRank.Click += new System.EventHandler(this.btnDeleteRank_Click);
            // 
            // idBox
            // 
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.68932F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(602, 488);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(88, 20);
            this.idBox.TabIndex = 42;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(38, 42);
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
            this.btnSearch.Location = new System.Drawing.Point(485, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 22);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rankGridView
            // 
            this.rankGridView.AllowUserToAddRows = false;
            this.rankGridView.AllowUserToDeleteRows = false;
            this.rankGridView.AllowUserToResizeRows = false;
            this.rankGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rankGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rankGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankGridView.Location = new System.Drawing.Point(38, 76);
            this.rankGridView.Name = "rankGridView";
            this.rankGridView.ReadOnly = true;
            this.rankGridView.Size = new System.Drawing.Size(536, 319);
            this.rankGridView.TabIndex = 39;
            this.rankGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rankGridView_CellClick);
            // 
            // btnUpdateRank
            // 
            this.btnUpdateRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnUpdateRank.FlatAppearance.BorderSize = 0;
            this.btnUpdateRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRank.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRank.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRank.Location = new System.Drawing.Point(602, 329);
            this.btnUpdateRank.Name = "btnUpdateRank";
            this.btnUpdateRank.Size = new System.Drawing.Size(88, 30);
            this.btnUpdateRank.TabIndex = 38;
            this.btnUpdateRank.Text = "Update";
            this.btnUpdateRank.UseVisualStyleBackColor = false;
            this.btnUpdateRank.Click += new System.EventHandler(this.btnUpdateRank_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Days On";
            // 
            // comboRankType
            // 
            this.comboRankType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRankType.FormattingEnabled = true;
            this.comboRankType.Location = new System.Drawing.Point(38, 487);
            this.comboRankType.Name = "comboRankType";
            this.comboRankType.Size = new System.Drawing.Size(243, 24);
            this.comboRankType.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Rank Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Short Name";
            // 
            // shortnameBox
            // 
            this.shortnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shortnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortnameBox.Location = new System.Drawing.Point(329, 435);
            this.shortnameBox.Name = "shortnameBox";
            this.shortnameBox.Size = new System.Drawing.Size(245, 22);
            this.shortnameBox.TabIndex = 32;
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(38, 433);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(245, 22);
            this.nameBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // comboDaysOn
            // 
            this.comboDaysOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDaysOn.FormattingEnabled = true;
            this.comboDaysOn.Location = new System.Drawing.Point(329, 487);
            this.comboDaysOn.Name = "comboDaysOn";
            this.comboDaysOn.Size = new System.Drawing.Size(85, 24);
            this.comboDaysOn.TabIndex = 45;
            // 
            // comboDaysOff
            // 
            this.comboDaysOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDaysOff.FormattingEnabled = true;
            this.comboDaysOff.Location = new System.Drawing.Point(443, 487);
            this.comboDaysOff.Name = "comboDaysOff";
            this.comboDaysOff.Size = new System.Drawing.Size(85, 24);
            this.comboDaysOff.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Days Off";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(602, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 30);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMessage.Location = new System.Drawing.Point(600, 266);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 49;
            // 
            // RankControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.comboDaysOff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboDaysOn);
            this.Controls.Add(this.btnAddRank);
            this.Controls.Add(this.btnDeleteRank);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rankGridView);
            this.Controls.Add(this.btnUpdateRank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboRankType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shortnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Name = "RankControl";
            this.Size = new System.Drawing.Size(770, 550);
            this.Load += new System.EventHandler(this.RankControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRank;
        private System.Windows.Forms.Button btnDeleteRank;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView rankGridView;
        private System.Windows.Forms.Button btnUpdateRank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRankType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shortnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDaysOn;
        private System.Windows.Forms.ComboBox comboDaysOff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label errorMessage;
    }
}
