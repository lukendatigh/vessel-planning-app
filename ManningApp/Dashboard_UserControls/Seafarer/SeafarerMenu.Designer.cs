namespace ManningApp.Dashboard_UserControls
{
    partial class SeafarerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeafarerMenu));
            this.btnSeafarerDelete = new System.Windows.Forms.Button();
            this.btnSeafarerEdit = new System.Windows.Forms.Button();
            this.btnSeafarerAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeafarerDelete
            // 
            this.btnSeafarerDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnSeafarerDelete.FlatAppearance.BorderSize = 0;
            this.btnSeafarerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeafarerDelete.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeafarerDelete.ForeColor = System.Drawing.Color.White;
            this.btnSeafarerDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnSeafarerDelete.Image")));
            this.btnSeafarerDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeafarerDelete.Location = new System.Drawing.Point(330, 39);
            this.btnSeafarerDelete.Name = "btnSeafarerDelete";
            this.btnSeafarerDelete.Size = new System.Drawing.Size(143, 30);
            this.btnSeafarerDelete.TabIndex = 5;
            this.btnSeafarerDelete.Text = "Delete Seafarer";
            this.btnSeafarerDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeafarerDelete.UseVisualStyleBackColor = false;
            // 
            // btnSeafarerEdit
            // 
            this.btnSeafarerEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnSeafarerEdit.FlatAppearance.BorderSize = 0;
            this.btnSeafarerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeafarerEdit.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeafarerEdit.ForeColor = System.Drawing.Color.White;
            this.btnSeafarerEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnSeafarerEdit.Image")));
            this.btnSeafarerEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeafarerEdit.Location = new System.Drawing.Point(189, 39);
            this.btnSeafarerEdit.Name = "btnSeafarerEdit";
            this.btnSeafarerEdit.Size = new System.Drawing.Size(123, 30);
            this.btnSeafarerEdit.TabIndex = 4;
            this.btnSeafarerEdit.Text = "Edit Seafarer";
            this.btnSeafarerEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeafarerEdit.UseVisualStyleBackColor = false;
            // 
            // btnSeafarerAdd
            // 
            this.btnSeafarerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSeafarerAdd.FlatAppearance.BorderSize = 0;
            this.btnSeafarerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeafarerAdd.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeafarerAdd.ForeColor = System.Drawing.Color.White;
            this.btnSeafarerAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnSeafarerAdd.Image")));
            this.btnSeafarerAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeafarerAdd.Location = new System.Drawing.Point(42, 39);
            this.btnSeafarerAdd.Name = "btnSeafarerAdd";
            this.btnSeafarerAdd.Size = new System.Drawing.Size(129, 30);
            this.btnSeafarerAdd.TabIndex = 3;
            this.btnSeafarerAdd.Text = "Add Seafarer";
            this.btnSeafarerAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeafarerAdd.UseVisualStyleBackColor = false;
            // 
            // SeafarerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSeafarerDelete);
            this.Controls.Add(this.btnSeafarerEdit);
            this.Controls.Add(this.btnSeafarerAdd);
            this.Name = "SeafarerMenu";
            this.Size = new System.Drawing.Size(780, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeafarerDelete;
        private System.Windows.Forms.Button btnSeafarerEdit;
        private System.Windows.Forms.Button btnSeafarerAdd;
    }
}
