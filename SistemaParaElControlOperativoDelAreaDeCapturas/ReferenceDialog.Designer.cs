namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    partial class ReferenceDialog
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
            this.reference_txt = new System.Windows.Forms.TextBox();
            this.add_reference_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reference_txt
            // 
            this.reference_txt.Location = new System.Drawing.Point(83, 58);
            this.reference_txt.Name = "reference_txt";
            this.reference_txt.Size = new System.Drawing.Size(224, 20);
            this.reference_txt.TabIndex = 0;
            this.reference_txt.TextChanged += new System.EventHandler(this.reference_txt_TextChanged);
            // 
            // add_reference_btn
            // 
            this.add_reference_btn.Location = new System.Drawing.Point(255, 98);
            this.add_reference_btn.Name = "add_reference_btn";
            this.add_reference_btn.Size = new System.Drawing.Size(122, 23);
            this.add_reference_btn.TabIndex = 1;
            this.add_reference_btn.Text = "Agregar referencia";
            this.add_reference_btn.UseVisualStyleBackColor = true;
            this.add_reference_btn.Click += new System.EventHandler(this.add_reference_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Favor de agregar la referencia en el siguiente campo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReferenceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 134);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_reference_btn);
            this.Controls.Add(this.reference_txt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ReferenceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Referencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reference_txt;
        private System.Windows.Forms.Button add_reference_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}