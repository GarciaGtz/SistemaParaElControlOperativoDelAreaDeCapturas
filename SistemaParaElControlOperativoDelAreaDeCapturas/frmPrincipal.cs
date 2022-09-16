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
        int tipoUsuario;

        public frmPrincipal()
        {
            InitializeComponent();

            this.txtNombre.AutoSize = true;
            txtNombre.Text = "Hola! " + Session.nombre;
            

            tipoUsuario = Session.id_tipo;

            if (tipoUsuario == 1)
            {
                this.subMenuRegistrarUsuario.Visible = true;
                this.menuEstatus.Visible = true;
            }
            else
            {
                this.subMenuRegistrarUsuario.Visible = false;
                
            }
        }

        private void subMenuRegistrarUsuario_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Visible = true;
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

            Session ss = new Session();
        }

        private void subMenuParrilla_Click(object sender, EventArgs e)
        {
            Parrilla parrilla = new Parrilla();
            parrilla.Visible = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
