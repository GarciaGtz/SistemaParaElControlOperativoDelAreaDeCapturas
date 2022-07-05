using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void button_IniciarSesionIS_Click(object sender, EventArgs e)
        {
            Clases.CConexion objetoconexion = new Clases.CConexion();
            objetoconexion.establecerConexion();
        }
    }
}
