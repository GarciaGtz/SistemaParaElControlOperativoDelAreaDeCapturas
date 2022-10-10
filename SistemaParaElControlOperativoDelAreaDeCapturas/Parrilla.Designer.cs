namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    partial class Parrilla
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox_Parrilla_Calificado = new System.Windows.Forms.CheckBox();
            this.checkBox_Parrilla_Referencia = new System.Windows.Forms.CheckBox();
            this.checkBox_Parilla_Master = new System.Windows.Forms.CheckBox();
            this.button_Parrilla_guardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "PARRILLA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 412);
            this.dataGridView1.TabIndex = 2;
            // 
            // checkBox_Parrilla_Calificado
            // 
            this.checkBox_Parrilla_Calificado.AutoSize = true;
            this.checkBox_Parrilla_Calificado.Location = new System.Drawing.Point(579, 252);
            this.checkBox_Parrilla_Calificado.Name = "checkBox_Parrilla_Calificado";
            this.checkBox_Parrilla_Calificado.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Parrilla_Calificado.TabIndex = 3;
            this.checkBox_Parrilla_Calificado.Text = "Calificado";
            this.checkBox_Parrilla_Calificado.UseVisualStyleBackColor = true;
            // 
            // checkBox_Parrilla_Referencia
            // 
            this.checkBox_Parrilla_Referencia.AutoSize = true;
            this.checkBox_Parrilla_Referencia.Location = new System.Drawing.Point(579, 285);
            this.checkBox_Parrilla_Referencia.Name = "checkBox_Parrilla_Referencia";
            this.checkBox_Parrilla_Referencia.Size = new System.Drawing.Size(95, 17);
            this.checkBox_Parrilla_Referencia.TabIndex = 4;
            this.checkBox_Parrilla_Referencia.Text = "Con referencia";
            this.checkBox_Parrilla_Referencia.UseVisualStyleBackColor = true;
            // 
            // checkBox_Parilla_Master
            // 
            this.checkBox_Parilla_Master.AutoSize = true;
            this.checkBox_Parilla_Master.Location = new System.Drawing.Point(579, 319);
            this.checkBox_Parilla_Master.Name = "checkBox_Parilla_Master";
            this.checkBox_Parilla_Master.Size = new System.Drawing.Size(58, 17);
            this.checkBox_Parilla_Master.TabIndex = 5;
            this.checkBox_Parilla_Master.Text = "Master";
            this.checkBox_Parilla_Master.UseVisualStyleBackColor = true;
            // 
            // button_Parrilla_guardar
            // 
            this.button_Parrilla_guardar.Location = new System.Drawing.Point(564, 369);
            this.button_Parrilla_guardar.Name = "button_Parrilla_guardar";
            this.button_Parrilla_guardar.Size = new System.Drawing.Size(206, 28);
            this.button_Parrilla_guardar.TabIndex = 6;
            this.button_Parrilla_guardar.Text = "Guardar";
            this.button_Parrilla_guardar.UseVisualStyleBackColor = true;
            this.button_Parrilla_guardar.Click += new System.EventHandler(this.button_Parrilla_guardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Parrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Parrilla_guardar);
            this.Controls.Add(this.checkBox_Parilla_Master);
            this.Controls.Add(this.checkBox_Parrilla_Referencia);
            this.Controls.Add(this.checkBox_Parrilla_Calificado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Parrilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parrilla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox_Parrilla_Calificado;
        private System.Windows.Forms.CheckBox checkBox_Parrilla_Referencia;
        private System.Windows.Forms.CheckBox checkBox_Parilla_Master;
        private System.Windows.Forms.Button button_Parrilla_guardar;
        private System.Windows.Forms.TextBox textBox1;
    }
}