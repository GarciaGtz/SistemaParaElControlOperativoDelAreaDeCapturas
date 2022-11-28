using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    class Control
    {
        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            string datosUsuario;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.porUsuario(usuario, password);
                Console.WriteLine(datosUsuario);
                
                if (datosUsuario != "")
                {
                    respuesta = datosUsuario;
                }
                
            }
            return respuesta;
        }

     
    }
}
