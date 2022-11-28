using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaParaElControlOperativoDelAreaDeCapturas.Modelo;

namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    public partial class ReferenceDialog : Form
    {
        public ReferenceDialog()
        {
            InitializeComponent();
        }

        private void add_reference_btn_Click(object sender, EventArgs e)
        {
            if(reference_txt.Text == "")
            {
                MessageBox.Show("Favor de llenar la referencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                ProgramasSemana.reference = reference_txt.Text;
                this.Close();
            }
        }

        private void reference_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
