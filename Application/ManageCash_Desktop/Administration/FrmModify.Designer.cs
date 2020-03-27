namespace ManageCash_Desktop.Administration
{
    partial class FrmModify
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
            this.GbxModify = new System.Windows.Forms.GroupBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GbxModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxModify
            // 
            this.GbxModify.Controls.Add(this.BtnCancel);
            this.GbxModify.Controls.Add(this.BtnModify);
            this.GbxModify.Controls.Add(this.LblName);
            this.GbxModify.Controls.Add(this.TxtName);
            this.GbxModify.Location = new System.Drawing.Point(12, 12);
            this.GbxModify.Name = "GbxModify";
            this.GbxModify.Size = new System.Drawing.Size(206, 84);
            this.GbxModify.TabIndex = 0;
            this.GbxModify.TabStop = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(7, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(51, 17);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(135, 20);
            this.TxtName.TabIndex = 0;
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(111, 43);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 2;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(30, 43);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 114);
            this.Controls.Add(this.GbxModify);
            this.Name = "FrmModify";
            this.Text = "Modify";
            this.GbxModify.ResumeLayout(false);
            this.GbxModify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxModify;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnModify;
    }
}