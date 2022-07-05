using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaElControlOperativoDelAreaDeCapturas.Clases
{
    class CConexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "127.0.0.1";
        static string bd = "bd";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";


        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se logro conectar");

            }
            catch (MySqlException e)
            {
                MessageBox.Show("No logro conectar" + e.ToString());
            }
            return conex;
        }

    }
}
