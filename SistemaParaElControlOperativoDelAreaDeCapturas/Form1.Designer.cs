namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_conectarbd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_conectarbd
            // 
            this.bt_conectarbd.Location = new System.Drawing.Point(98, 147);
            this.bt_conectarbd.Name = "bt_conectarbd";
            this.bt_conectarbd.Size = new System.Drawing.Size(75, 23);
            this.bt_conectarbd.TabIndex = 0;
            this.bt_conectarbd.Text = "Conectar";
            this.bt_conectarbd.UseVisualStyleBackColor = true;
            this.bt_conectarbd.Click += new System.EventHandler(this.bt_conectarbd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_conectarbd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_conectarbd;
    }
}

