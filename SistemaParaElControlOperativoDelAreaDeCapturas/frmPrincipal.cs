using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();

            this.txtNombre.AutoSize = true;
            txtNombre.Text = "Hola Bienvenido! " ;
        }



        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void menuCerrarSession_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin frm = new frmLogin();
            frm.Visible = true;

        }

        private void subMenuParrilla_Click(object sender, EventArgs e)
        {
            Parrilla parrilla = new Parrilla();
            parrilla.Visible = true;
        }

  
    }
}
