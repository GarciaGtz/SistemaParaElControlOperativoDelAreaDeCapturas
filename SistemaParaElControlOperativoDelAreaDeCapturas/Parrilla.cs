using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    public partial class Parrilla : Form
    {
        public Parrilla()
        {
            InitializeComponent();
            var url = $"http://localhost:9000/programmations/list";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            //Console.WriteLine(responseBody);
                            //textBox1.Text = responseBody ;


                            var json = new WebClient().DownloadString(url);

                            var m = JsonConvert.DeserializeObject<List<MiClase>>(responseBody);
                            Console.WriteLine(m[0]._id);

                            dataGridView1.DataSource = m;

                            dataGridView1.Columns["_id"].Visible = false;
                            dataGridView1.Columns["semana_Inicio"].MinimumWidth = 142;
                            dataGridView1.Columns["semana_Inicio"].HeaderText = "Inicio de semana";
                            dataGridView1.Columns["semana_Fin"].MinimumWidth = 142;
                            dataGridView1.Columns["semana_Fin"].HeaderText = "Fin de semana";
                        }
                    }
                }
                }
            catch (WebException ex)
            {
                // Handle error
            }
        }

        public class MiClase
        {
            public string _id { get; set; }
            public string semana_Inicio { get; set; }
            public string semana_Fin { get; set; }

            public List<MiClase2> semana_Programas { get; set; }
        }


        public class MiClase2
        {
      
            public string programa_Nombre { get; set; }
            public MiClase3 programa_Estatus { get; set; }
        }

        public class MiClase3
        {

            public string Calificado { get; set; }
            public string Referencia { get; set; }
            public string Master { get; set; }

        }




        private void button_Parrilla_guardar_Click(object sender, EventArgs e)
        {
            if(id == "")
            {
                    
            }
            else
            {
                ProgramasSemana frm = new ProgramasSemana(id, dateStart, dateEnd);
                frm.Visible = true;
                this.Visible = false;
            }
        }

        private static string dateEnd;
        private static string dateStart;
        private static string id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            else
            {
                id = dataGridView1.Rows[e.RowIndex].Cells["_id"].Value.ToString();
                dateStart = dataGridView1.Rows[e.RowIndex].Cells["semana_Inicio"].Value.ToString();
                dateEnd = dataGridView1.Rows[e.RowIndex].Cells["semana_Fin"].Value.ToString();
                Console.WriteLine(e.RowIndex);
            }
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

