namespace ManageCash_Desktop.Administration
{
    partial class FrmRoles
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbxRoles = new System.Windows.Forms.GroupBox();
            this.DGV_Roles = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GbxRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxRoles
            // 
            this.GbxRoles.Controls.Add(this.BtnAdd);
            this.GbxRoles.Controls.Add(this.DGV_Roles);
            this.GbxRoles.Location = new System.Drawing.Point(12, 12);
            this.GbxRoles.Name = "GbxRoles";
            this.GbxRoles.Size = new System.Drawing.Size(537, 285);
            this.GbxRoles.TabIndex = 0;
            this.GbxRoles.TabStop = false;
            this.GbxRoles.Text = "All Roles";
            // 
            // DGV_Roles
            // 
            this.DGV_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Roles.Location = new System.Drawing.Point(53, 89);
            this.DGV_Roles.Name = "DGV_Roles";
            this.DGV_Roles.Size = new System.Drawing.Size(323, 150);
            this.DGV_Roles.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(21, 33);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 310);
            this.Controls.Add(this.GbxRoles);
            this.HelpButton = true;
            this.Name = "FrmRoles";
            this.Text = "Roles";
            this.GbxRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxRoles;
        private System.Windows.Forms.DataGridView DGV_Roles;
        private System.Windows.Forms.Button BtnAdd;
    }
}