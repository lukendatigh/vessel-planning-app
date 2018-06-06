namespace ManningApp.Dashboard_UserControls
{
    partial class VesselMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VesselMenu));
            this.btnVesselDelete = new System.Windows.Forms.Button();
            this.btnVesselEdit = new System.Windows.Forms.Button();
            this.btnVesselAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVesselDelete
            // 
            this.btnVesselDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnVesselDelete.FlatAppearance.BorderSize = 0;
            this.btnVesselDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVesselDelete.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVesselDelete.ForeColor = System.Drawing.Color.White;
            this.btnVesselDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnVesselDelete.Image")));
            this.btnVesselDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVesselDelete.Location = new System.Drawing.Point(299, 39);
            this.btnVesselDelete.Name = "btnVesselDelete";
            this.btnVesselDelete.Size = new System.Drawing.Size(126, 30);
            this.btnVesselDelete.TabIndex = 8;
            this.btnVesselDelete.Text = "Delete Vessel";
            this.btnVesselDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVesselDelete.UseVisualStyleBackColor = false;
            // 
            // btnVesselEdit
            // 
            this.btnVesselEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnVesselEdit.FlatAppearance.BorderSize = 0;
            this.btnVesselEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVesselEdit.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVesselEdit.ForeColor = System.Drawing.Color.White;
            this.btnVesselEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnVesselEdit.Image")));
            this.btnVesselEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVesselEdit.Location = new System.Drawing.Point(173, 39);
            this.btnVesselEdit.Name = "btnVesselEdit";
            this.btnVesselEdit.Size = new System.Drawing.Size(108, 30);
            this.btnVesselEdit.TabIndex = 7;
            this.btnVesselEdit.Text = "Edit Vessel";
            this.btnVesselEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVesselEdit.UseVisualStyleBackColor = false;
            // 
            // btnVesselAdd
            // 
            this.btnVesselAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnVesselAdd.FlatAppearance.BorderSize = 0;
            this.btnVesselAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVesselAdd.Font = new System.Drawing.Font("Segoe UI", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVesselAdd.ForeColor = System.Drawing.Color.White;
            this.btnVesselAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnVesselAdd.Image")));
            this.btnVesselAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVesselAdd.Location = new System.Drawing.Point(42, 39);
            this.btnVesselAdd.Name = "btnVesselAdd";
            this.btnVesselAdd.Size = new System.Drawing.Size(113, 30);
            this.btnVesselAdd.TabIndex = 6;
            this.btnVesselAdd.Text = "Add Vessel";
            this.btnVesselAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVesselAdd.UseVisualStyleBackColor = false;
            // 
            // VesselMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVesselDelete);
            this.Controls.Add(this.btnVesselEdit);
            this.Controls.Add(this.btnVesselAdd);
            this.Name = "VesselMenu";
            this.Size = new System.Drawing.Size(780, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVesselDelete;
        private System.Windows.Forms.Button btnVesselEdit;
        private System.Windows.Forms.Button btnVesselAdd;
    }
}
