namespace ManningApp.Dashboard_UserControls.Seafarer
{
    partial class SeafarerControl
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
            this.btnUpdateSeafarer = new System.Windows.Forms.Button();
            this.contractBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRank = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.othernamesBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seafarerGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.btnDeleteSeafarer = new System.Windows.Forms.Button();
            this.btnAddSeafarer = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seafarerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateSeafarer
            // 
            this.btnUpdateSeafarer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnUpdateSeafarer.FlatAppearance.BorderSize = 0;
            this.btnUpdateSeafarer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSeafarer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSeafarer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSeafarer.Location = new System.Drawing.Point(601, 315);
            this.btnUpdateSeafarer.Name = "btnUpdateSeafarer";
            this.btnUpdateSeafarer.Size = new System.Drawing.Size(88, 30);
            this.btnUpdateSeafarer.TabIndex = 21;
            this.btnUpdateSeafarer.Text = "Update";
            this.btnUpdateSeafarer.UseVisualStyleBackColor = false;
            this.btnUpdateSeafarer.Click += new System.EventHandler(this.btnUpdateSeafarer_Click);
            // 
            // contractBox
            // 
            this.contractBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractBox.Location = new System.Drawing.Point(328, 474);
            this.contractBox.Name = "contractBox";
            this.contractBox.Size = new System.Drawing.Size(245, 22);
            this.contractBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contract";
            // 
            // comboRank
            // 
            this.comboRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRank.FormattingEnabled = true;
            this.comboRank.Location = new System.Drawing.Point(37, 473);
            this.comboRank.Name = "comboRank";
            this.comboRank.Size = new System.Drawing.Size(243, 24);
            this.comboRank.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Other Names";
            // 
            // othernamesBox
            // 
            this.othernamesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.othernamesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othernamesBox.Location = new System.Drawing.Point(328, 421);
            this.othernamesBox.Name = "othernamesBox";
            this.othernamesBox.Size = new System.Drawing.Size(245, 22);
            this.othernamesBox.TabIndex = 15;
            // 
            // surnameBox
            // 
            this.surnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.Location = new System.Drawing.Point(37, 419);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(245, 22);
            this.surnameBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Surname";
            // 
            // seafarerGridView
            // 
            this.seafarerGridView.AllowUserToAddRows = false;
            this.seafarerGridView.AllowUserToDeleteRows = false;
            this.seafarerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seafarerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seafarerGridView.Location = new System.Drawing.Point(37, 62);
            this.seafarerGridView.Name = "seafarerGridView";
            this.seafarerGridView.ReadOnly = true;
            this.seafarerGridView.Size = new System.Drawing.Size(536, 319);
            this.seafarerGridView.TabIndex = 22;
            this.seafarerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seafarerGridView_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.68932F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(484, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 22);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(37, 28);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(443, 22);
            this.searchBox.TabIndex = 25;
            // 
            // idBox
            // 
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.68932F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(601, 474);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(88, 20);
            this.idBox.TabIndex = 26;
            // 
            // btnDeleteSeafarer
            // 
            this.btnDeleteSeafarer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnDeleteSeafarer.FlatAppearance.BorderSize = 0;
            this.btnDeleteSeafarer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSeafarer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSeafarer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSeafarer.Location = new System.Drawing.Point(601, 351);
            this.btnDeleteSeafarer.Name = "btnDeleteSeafarer";
            this.btnDeleteSeafarer.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteSeafarer.TabIndex = 28;
            this.btnDeleteSeafarer.Text = "Delete";
            this.btnDeleteSeafarer.UseVisualStyleBackColor = false;
            // 
            // btnAddSeafarer
            // 
            this.btnAddSeafarer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnAddSeafarer.FlatAppearance.BorderSize = 0;
            this.btnAddSeafarer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSeafarer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSeafarer.ForeColor = System.Drawing.Color.White;
            this.btnAddSeafarer.Location = new System.Drawing.Point(601, 279);
            this.btnAddSeafarer.Name = "btnAddSeafarer";
            this.btnAddSeafarer.Size = new System.Drawing.Size(88, 30);
            this.btnAddSeafarer.TabIndex = 29;
            this.btnAddSeafarer.Text = "Add";
            this.btnAddSeafarer.UseVisualStyleBackColor = false;
            this.btnAddSeafarer.Click += new System.EventHandler(this.btnAddSeafarer_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMessage.Location = new System.Drawing.Point(598, 252);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 30;
            // 
            // SeafarerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.btnAddSeafarer);
            this.Controls.Add(this.btnDeleteSeafarer);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.seafarerGridView);
            this.Controls.Add(this.btnUpdateSeafarer);
            this.Controls.Add(this.contractBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.othernamesBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label2);
            this.Name = "SeafarerControl";
            this.Size = new System.Drawing.Size(780, 520);
            this.Load += new System.EventHandler(this.SeafarerControl_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.seafarerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateSeafarer;
        private System.Windows.Forms.TextBox contractBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox othernamesBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView seafarerGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button btnDeleteSeafarer;
        private System.Windows.Forms.Button btnAddSeafarer;
        private System.Windows.Forms.Label errorMessage;
    }
}
