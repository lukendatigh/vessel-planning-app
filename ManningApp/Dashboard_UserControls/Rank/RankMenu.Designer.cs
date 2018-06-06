namespace ManningApp.Dashboard_Form_UserControls
{
    partial class RankMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankMenu));
            this.btnRankAdd = new System.Windows.Forms.Button();
            this.btnRankEdit = new System.Windows.Forms.Button();
            this.btnRankDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRankAdd
            // 
            this.btnRankAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRankAdd.FlatAppearance.BorderSize = 0;
            this.btnRankAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankAdd.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRankAdd.ForeColor = System.Drawing.Color.White;
            this.btnRankAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnRankAdd.Image")));
            this.btnRankAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRankAdd.Location = new System.Drawing.Point(42, 39);
            this.btnRankAdd.Name = "btnRankAdd";
            this.btnRankAdd.Size = new System.Drawing.Size(105, 30);
            this.btnRankAdd.TabIndex = 0;
            this.btnRankAdd.Text = "Add Rank";
            this.btnRankAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRankAdd.UseVisualStyleBackColor = false;
            // 
            // btnRankEdit
            // 
            this.btnRankEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnRankEdit.FlatAppearance.BorderSize = 0;
            this.btnRankEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankEdit.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRankEdit.ForeColor = System.Drawing.Color.White;
            this.btnRankEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnRankEdit.Image")));
            this.btnRankEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRankEdit.Location = new System.Drawing.Point(167, 39);
            this.btnRankEdit.Name = "btnRankEdit";
            this.btnRankEdit.Size = new System.Drawing.Size(100, 30);
            this.btnRankEdit.TabIndex = 1;
            this.btnRankEdit.Text = "Edit Rank";
            this.btnRankEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRankEdit.UseVisualStyleBackColor = false;
            // 
            // btnRankDelete
            // 
            this.btnRankDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnRankDelete.FlatAppearance.BorderSize = 0;
            this.btnRankDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankDelete.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRankDelete.ForeColor = System.Drawing.Color.White;
            this.btnRankDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnRankDelete.Image")));
            this.btnRankDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRankDelete.Location = new System.Drawing.Point(288, 39);
            this.btnRankDelete.Name = "btnRankDelete";
            this.btnRankDelete.Size = new System.Drawing.Size(118, 30);
            this.btnRankDelete.TabIndex = 2;
            this.btnRankDelete.Text = "Delete Rank";
            this.btnRankDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRankDelete.UseVisualStyleBackColor = false;
            // 
            // RankMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRankDelete);
            this.Controls.Add(this.btnRankEdit);
            this.Controls.Add(this.btnRankAdd);
            this.Name = "RankMenu";
            this.Size = new System.Drawing.Size(780, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRankAdd;
        private System.Windows.Forms.Button btnRankEdit;
        private System.Windows.Forms.Button btnRankDelete;
    }
}
