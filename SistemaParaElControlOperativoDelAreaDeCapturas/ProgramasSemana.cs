using iTextSharp.text.pdf;
using iTextSharp.text;
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
using static System.Net.Mime.MediaTypeNames;

namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    public partial class ProgramasSemana : Form
    {
        private static string dateEnd;
        private static string dateStart;

        public ProgramasSemana(String id, String start, String end)
        {
            dateStart = start;
            dateEnd = end;
            InitializeComponent();
            Console.WriteLine(id);
            var url = $"http://localhost:9000/programmations/programs/"+id;
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
                            Console.WriteLine(responseBody);
                            //textBox1.Text = responseBody ;


                            var json = new WebClient().DownloadString(url);

                            var m = JsonConvert.DeserializeObject<MiClase>(responseBody);
                            /*
                            for (int i = 0; i < m.semana_Programas.Count; i++)
                            {
                                if(m.semana_Programas[i].programa_Dia == "1")
                                {
                                    m.semana_Programas[i].programa_Dia = "Lunes";
                                }else if(m.semana_Programas[i].programa_Dia == "2")
                                {
                                    m.semana_Programas[i].programa_Dia = "Martes";
                                }
                                else if (m.semana_Programas[i].programa_Dia == "3")
                                {
                                    m.semana_Programas[i].programa_Dia = "Miercoles";
                                }
                                else if (m.semana_Programas[i].programa_Dia == "4")
                                {
                                    m.semana_Programas[i].programa_Dia = "Jueves";
                                }
                                else if (m.semana_Programas[i].programa_Dia == "5")
                                {
                                    m.semana_Programas[i].programa_Dia = "Viernes";
                                }
                                else if (m.semana_Programas[i].programa_Dia == "6")
                                {
                                    m.semana_Programas[i].programa_Dia = "Sabado";
                                }
                                else if (m.semana_Programas[i].programa_Dia == "7")
                                {
                                    m.semana_Programas[i].programa_Dia = "Domingo";
                                }

                            }*/

                            for (int i = 0; i < m.semana_Programas.Count; i++)
                            {
                                if (m.semana_Programas[i].programa_Estatus.Referencia)
                                {
                                    m.semana_Programas[i].Referencia = "Si";
                                }
                                else
                                {
                                    m.semana_Programas[i].Referencia = "No";
                                }

                                if (m.semana_Programas[i].programa_Estatus.Calificado)
                                {
                                    m.semana_Programas[i].Calificado = "Si";
                                }
                                else
                                {
                                    m.semana_Programas[i].Calificado = "No";
                                }

                                if (m.semana_Programas[i].programa_Estatus.Master)
                                {
                                    m.semana_Programas[i].Master = "Si";
                                }
                                else
                                {
                                    m.semana_Programas[i].Master = "No";
                                }

                            }
                            Console.WriteLine(m.semana_Programas);
                            dataGridView1.DataSource = m.semana_Programas;
                            dataGridView1.Columns["_id"].Visible = false;
                            dataGridView1.Columns["programa_Estatus"].Visible = false;

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
            public string _id { get; set; }
            //public string programa_Dia { get; set; }
            public string hora_Inicio { get; set; }
            public string hora_Fin { get; set; }
            public string programa_Nombre { get; set; }
            public MiClase3 programa_Estatus { get; set; }
            public string Referencia { get; set; }
            public string Calificado { get; set; }
            public string Master { get; set; }

        }

        public class MiClase3
        {
            public Boolean Calificado { get; set; }
            public Boolean Referencia { get; set; }
            public Boolean Master { get; set; }

        }
         



        private void button_Parrilla_guardar_Click(object sender, EventArgs e)
        {
            string referencia = "";
            string calificado = "";
            string master = "";
            if (checkBox_Parrilla_Referencia.Checked)
            {
                referencia = "true";
            }
            else
            {
                referencia = "false";
            }
            if (checkBox_Parrilla_Calificado.Checked)
            {
                calificado = "true";
            }
            else
            {
                calificado = "false";
            }
            if (checkBox_Parilla_Master.Checked)
            {
                master = "true";
            }
            else
            {
                master = "false";
            }



            var url = $"http://localhost:9000/programs/update/status/"+id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            string jsonData = $"{{\"Referencia\":{referencia},\"Calificado\":{calificado},\"Master\":{master}}}";
            Console.WriteLine(jsonData);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(jsonData);
                streamWriter.Flush();
                streamWriter.Close();
            }

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
                            Console.WriteLine(responseBody);
                            //textBox1.Text = responseBody ;

                        } 
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
        }


        private static string estatus;

        private static string id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["referencia"].Value.ToString() == "Si")
                {
                    checkBox_Parrilla_Referencia.Checked = true;
                }
                else
                {
                    checkBox_Parrilla_Referencia.Checked = false;
                }

                if (dataGridView1.Rows[e.RowIndex].Cells["calificado"].Value.ToString() == "Si")
                {
                    checkBox_Parrilla_Calificado.Checked = true;
                }
                else
                {
                    checkBox_Parrilla_Calificado.Checked = false;
                }

                if (dataGridView1.Rows[e.RowIndex].Cells["master"].Value.ToString() == "Si")
                {
                    checkBox_Parilla_Master.Checked = true;
                }
                else
                {
                    checkBox_Parilla_Master.Checked = false;
                }

                id = dataGridView1.Rows[e.RowIndex].Cells["_id"].Value.ToString();
            }
           
            
        }
        private void btn_exportPDF_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("No se puede guardar el archivo en el disco." + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count-2);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)

                            {
                                if(col.HeaderText.ToString() == "_id" || col.HeaderText.ToString() == "programa_Estatus")
                                {

                                }
                                else
                                {
                                    if(col.HeaderText.ToString() == "programa_Nombre")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Nombre"));

                                        pTable.AddCell(pCell);
                                    }else if (col.HeaderText.ToString() == "hora_Inicio")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Fecha Inicio"));

                                        pTable.AddCell(pCell);
                                    }
                                    else if (col.HeaderText.ToString() == "hora_Fin")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Fecha Fin"));

                                        pTable.AddCell(pCell);
                                    }
                                    else
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                        pTable.AddCell(pCell);
                                    }

                                }

                                

                            }

                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)

                            {

                                var c = 0;
                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {
                                    if(c == 0 || c== 4)
                                    {

                                    }else if (c == 1 || c == 2)
                                    {
                                        Console.WriteLine(dcell.Value.ToString() + "Index:" + dcell.RowIndex);
                                        DateTime dttt = DateTime.Parse(dcell.Value.ToString()).ToUniversalTime();
                                        Console.WriteLine(dttt);
                                        pTable.AddCell(dttt.ToString());
                                    }
                                    else {
                                        Console.WriteLine(dcell.Value.ToString()+ "Index:" +dcell.RowIndex);
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                    c++;



                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 50f, 50f, 130f, 50f);
                                PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance("C:\\Users\\edgar\\Documents\\Onichan\\SistemaParaElControlOperativoDelAreaDeCapturas\\logo-televisa.png");
                                pic.ScalePercent(50);
                                pic.SetAbsolutePosition(50, 770);
                                document.Add(pic);

                                PdfContentByte cb = writer.DirectContent;

                                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                                cb.SetFontAndSize(bf, 12);

                                cb.BeginText();
                                cb.SetTextMatrix(230, 800);
                                cb.ShowText("TELEVISA REGIONAL");
                                cb.EndText();

                                cb.BeginText();
                                cb.SetTextMatrix(190, 760);
                                cb.ShowText("Programación del "+dateStart+" al "+dateEnd);
                                cb.EndText();

                                cb.BeginText();
                                cb.SetTextMatrix(50, 730);
                                cb.ShowText("HERMOSILLO");
                                cb.EndText();

                                cb.BeginText();
                                cb.SetTextMatrix(410, 730);
                                cb.ShowText("C12-HERMOSILLO-12.1");
                                cb.EndText();

                                cb.BeginText();
                                cb.SetTextMatrix(220, 730);
                                cb.ShowText("XHAK-TV (HERMOSILLO)");
                                cb.EndText();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Se exportó el archivo correctamente!", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error al exportar." + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }

        }
    }
    }

