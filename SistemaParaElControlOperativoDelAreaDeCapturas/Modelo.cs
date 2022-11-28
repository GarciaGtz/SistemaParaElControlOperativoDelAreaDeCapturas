using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.Win32.SafeHandles;

namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    class Modelo
    {
        public class Usuario
        {
            public string nombre_Usuario { get; set; }
            public string contrasena_Usuario { get; set; }
        }

        public class Respuesta
        {
            public string acceso { get; set; }
            public string mensaje { get; set; }
            public string token { get; set; }
            public Tipo tipo_Usuario { get; set; }
        }

        public class Tipo
        {
            public bool administrador { get; set; }
            public bool usuario { get; set; }
            public bool usuario_web { get; set; }
        }
        public static string accessToken;
        public string porUsuario(string usuario, string password)
        {
            var url = $"http://localhost:9000/users/login";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            Usuario usuarioObj = new Usuario
            {
                nombre_Usuario = usuario,
                contrasena_Usuario = password
            };


            string jsonString = JsonSerializer.Serialize(usuarioObj);

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(jsonString);
                streamWriter.Flush();
                streamWriter.Close();
            }

            Console.WriteLine("DATOS", jsonString);

            try
            {

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return ("ERROR AL SOLICITAR INFORMACION.");
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Console.WriteLine(responseBody);
                            // Do something with responseBody
                            Respuesta respuestaJson =
                                                JsonSerializer.Deserialize<Respuesta>(responseBody);
                            accessToken = respuestaJson.token;

                            if (respuestaJson.acceso != "true")
                            {
                                return respuestaJson.mensaje;
                            }
                            else
                            {
                                if (respuestaJson.tipo_Usuario.usuario == true)
                                {
                                    return "";
                                }
                                else
                                {
                                    return "USUARIO SIN PERMISOS PARA ACCEDER A SISTEMA.";
                                }

                            }

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return ("ERROR AL SOLICITAR INFORMACION.");
            }
        }


    }
}