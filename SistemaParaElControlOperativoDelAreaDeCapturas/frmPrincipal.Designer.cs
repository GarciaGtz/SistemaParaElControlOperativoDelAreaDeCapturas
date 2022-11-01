namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstatus = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuParrilla = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarSession = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_logoIS = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoIS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(520, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuEstatus,
            this.menuCerrarSession});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarUsuario});
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(163, 20);
            this.menuUsuarios.Text = "Administración de usuarios";
            // 
            // subMenuRegistrarUsuario
            // 
            this.subMenuRegistrarUsuario.Name = "subMenuRegistrarUsuario";
            this.subMenuRegistrarUsuario.Size = new System.Drawing.Size(120, 22);
            this.subMenuRegistrarUsuario.Text = "Registrar";
            this.subMenuRegistrarUsuario.Click += new System.EventHandler(this.subMenuRegistrarUsuario_Click);
            // 
            // menuEstatus
            // 
            this.menuEstatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuParrilla});
            this.menuEstatus.Name = "menuEstatus";
            this.menuEstatus.Size = new System.Drawing.Size(56, 20);
            this.menuEstatus.Text = "Estatus";
            // 
            // subMenuParrilla
            // 
            this.subMenuParrilla.Name = "subMenuParrilla";
            this.subMenuParrilla.Size = new System.Drawing.Size(110, 22);
            this.subMenuParrilla.Text = "Parrilla";
            this.subMenuParrilla.Click += new System.EventHandler(this.subMenuParrilla_Click);
            // 
            // menuCerrarSession
            // 
            this.menuCerrarSession.Name = "menuCerrarSession";
            this.menuCerrarSession.Size = new System.Drawing.Size(88, 20);
            this.menuCerrarSession.Text = "Cerrar Sesión";
            this.menuCerrarSession.Click += new System.EventHandler(this.menuCerrarSession_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_logoIS
            // 
            this.pictureBox_logoIS.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logoIS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_logoIS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logoIS.Image")));
            this.pictureBox_logoIS.Location = new System.Drawing.Point(92, 42);
            this.pictureBox_logoIS.Name = "pictureBox_logoIS";
            this.pictureBox_logoIS.Size = new System.Drawing.Size(229, 155);
            this.pictureBox_logoIS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logoIS.TabIndex = 23;
            this.pictureBox_logoIS.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_logoIS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logoIS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuEstatus;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSession;
        private System.Windows.Forms.ToolStripMenuItem subMenuParrilla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_logoIS;
    }
}