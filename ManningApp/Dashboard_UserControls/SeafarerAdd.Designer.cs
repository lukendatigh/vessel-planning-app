namespace ManningApp.Dashboard_UserControls.Seafarer
{
    partial class SeafarerAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.othernamesBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRank = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contractBox = new System.Windows.Forms.TextBox();
            this.btnSaveSeafarer = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Other Names";
            // 
            // othernamesBox
            // 
            this.othernamesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.othernamesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othernamesBox.Location = new System.Drawing.Point(46, 152);
            this.othernamesBox.Name = "othernamesBox";
            this.othernamesBox.Size = new System.Drawing.Size(245, 22);
            this.othernamesBox.TabIndex = 6;
            this.othernamesBox.TextChanged += new System.EventHandler(this.othernamesBox_TextChanged);
            // 
            // surnameBox
            // 
            this.surnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.Location = new System.Drawing.Point(45, 84);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(245, 22);
            this.surnameBox.TabIndex = 5;
            this.surnameBox.TextChanged += new System.EventHandler(this.surnameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rank";
            // 
            // comboRank
            // 
            this.comboRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRank.FormattingEnabled = true;
            this.comboRank.Location = new System.Drawing.Point(46, 218);
            this.comboRank.Name = "comboRank";
            this.comboRank.Size = new System.Drawing.Size(243, 24);
            this.comboRank.TabIndex = 9;
            this.comboRank.SelectedIndexChanged += new System.EventHandler(this.comboRank_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contract";
            // 
            // contractBox
            // 
            this.contractBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractBox.Location = new System.Drawing.Point(46, 282);
            this.contractBox.Name = "contractBox";
            this.contractBox.Size = new System.Drawing.Size(245, 22);
            this.contractBox.TabIndex = 11;
            this.contractBox.TextChanged += new System.EventHandler(this.contractBox_TextChanged);
            // 
            // btnSaveSeafarer
            // 
            this.btnSaveSeafarer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(108)))));
            this.btnSaveSeafarer.FlatAppearance.BorderSize = 0;
            this.btnSaveSeafarer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSeafarer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.786407F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSeafarer.ForeColor = System.Drawing.Color.White;
            this.btnSaveSeafarer.Location = new System.Drawing.Point(203, 337);
            this.btnSaveSeafarer.Name = "btnSaveSeafarer";
            this.btnSaveSeafarer.Size = new System.Drawing.Size(88, 30);
            this.btnSaveSeafarer.TabIndex = 12;
            this.btnSaveSeafarer.Text = "Save";
            this.btnSaveSeafarer.UseVisualStyleBackColor = false;
            this.btnSaveSeafarer.Click += new System.EventHandler(this.btnSaveSeafarer_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorMessage.Location = new System.Drawing.Point(47, 311);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 13;
            // 
            // SeafarerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.btnSaveSeafarer);
            this.Controls.Add(this.contractBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.othernamesBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label2);
            this.Name = "SeafarerAdd";
            this.Size = new System.Drawing.Size(780, 450);
            this.Load += new System.EventHandler(this.SeafarerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox othernamesBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contractBox;
        private System.Windows.Forms.Button btnSaveSeafarer;
        private System.Windows.Forms.Label errorMessage;
    }
}
