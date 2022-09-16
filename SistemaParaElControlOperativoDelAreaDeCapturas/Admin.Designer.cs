namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    partial class Admin
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
            this.lblmensajeAdmin = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensajeAdmin
            // 
            this.lblmensajeAdmin.AutoSize = true;
            this.lblmensajeAdmin.Location = new System.Drawing.Point(320, 91);
            this.lblmensajeAdmin.Name = "lblmensajeAdmin";
            this.lblmensajeAdmin.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeAdmin.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(320, 163);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(36, 13);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblmensajeAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensajeAdmin;
        private System.Windows.Forms.Label lblAdmin;
    }
}