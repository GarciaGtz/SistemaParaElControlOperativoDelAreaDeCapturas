namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    partial class ProgramasSemana
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
            this.btn_exportPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(696, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 412);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // checkBox_Parrilla_Calificado
            // 
            this.checkBox_Parrilla_Calificado.AutoSize = true;
            this.checkBox_Parrilla_Calificado.Location = new System.Drawing.Point(20, 50);
            this.checkBox_Parrilla_Calificado.Name = "checkBox_Parrilla_Calificado";
            this.checkBox_Parrilla_Calificado.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Parrilla_Calificado.TabIndex = 3;
            this.checkBox_Parrilla_Calificado.Text = "Calificado";
            this.checkBox_Parrilla_Calificado.UseVisualStyleBackColor = true;
            // 
            // checkBox_Parrilla_Referencia
            // 
            this.checkBox_Parrilla_Referencia.AutoSize = true;
            this.checkBox_Parrilla_Referencia.Location = new System.Drawing.Point(20, 83);
            this.checkBox_Parrilla_Referencia.Name = "checkBox_Parrilla_Referencia";
            this.checkBox_Parrilla_Referencia.Size = new System.Drawing.Size(95, 17);
            this.checkBox_Parrilla_Referencia.TabIndex = 4;
            this.checkBox_Parrilla_Referencia.Text = "Con referencia";
            this.checkBox_Parrilla_Referencia.UseVisualStyleBackColor = true;
            // 
            // checkBox_Parilla_Master
            // 
            this.checkBox_Parilla_Master.AutoSize = true;
            this.checkBox_Parilla_Master.Location = new System.Drawing.Point(20, 117);
            this.checkBox_Parilla_Master.Name = "checkBox_Parilla_Master";
            this.checkBox_Parilla_Master.Size = new System.Drawing.Size(58, 17);
            this.checkBox_Parilla_Master.TabIndex = 5;
            this.checkBox_Parilla_Master.Text = "Master";
            this.checkBox_Parilla_Master.UseVisualStyleBackColor = true;
            // 
            // button_Parrilla_guardar
            // 
            this.button_Parrilla_guardar.Location = new System.Drawing.Point(20, 153);
            this.button_Parrilla_guardar.Name = "button_Parrilla_guardar";
            this.button_Parrilla_guardar.Size = new System.Drawing.Size(164, 28);
            this.button_Parrilla_guardar.TabIndex = 6;
            this.button_Parrilla_guardar.Text = "Guardar estatus";
            this.button_Parrilla_guardar.UseVisualStyleBackColor = true;
            this.button_Parrilla_guardar.Click += new System.EventHandler(this.button_Parrilla_guardar_Click);
            // 
            // btn_exportPDF
            // 
            this.btn_exportPDF.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_exportPDF.Location = new System.Drawing.Point(20, 67);
            this.btn_exportPDF.Name = "btn_exportPDF";
            this.btn_exportPDF.Size = new System.Drawing.Size(164, 32);
            this.btn_exportPDF.TabIndex = 8;
            this.btn_exportPDF.Text = "Exportar PDF";
            this.btn_exportPDF.UseVisualStyleBackColor = false;
            this.btn_exportPDF.Click += new System.EventHandler(this.btn_exportPDF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estatus:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox_Parrilla_Calificado);
            this.panel1.Controls.Add(this.button_Parrilla_guardar);
            this.panel1.Controls.Add(this.checkBox_Parrilla_Referencia);
            this.panel1.Controls.Add(this.checkBox_Parilla_Master);
            this.panel1.Location = new System.Drawing.Point(696, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 194);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_exportPDF);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(696, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 150);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Utilidades:";
            // 
            // ProgramasSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramasSemana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parrilla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button btn_exportPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}