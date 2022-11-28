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
using Ubiety.Dns.Core.Common;
using System.Security.Cryptography.Xml;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace SistemaParaElControlOperativoDelAreaDeCapturas
{
    public partial class ProgramasSemana : Form
    {
        private static string dateEnd;
        private static string dateStart;
        private static string id_programacion;

        public ProgramasSemana(String id, String start, String end)
        {
            dateStart = start;
            dateEnd = end;
            id_programacion = id;
            InitializeComponent();
            //Console.WriteLine(id);
            Cargar(id);
        }

        public void Cargar(String id)
        {

            var url = $"http://localhost:9000/programmations/programs/" + id;
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
                            // Console.WriteLine(responseBody);
                            //textBox1.Text = responseBody ;


                            var json = new WebClient().DownloadString(url);

                            var m = JsonConvert.DeserializeObject<MiClase>(responseBody);


                            for (int i = 0; i < m.semana_Programas.Count; i++)
                            {
                                if (m.semana_Programas[i].programa_Estatus.Referencia)
                                {
                                    m.semana_Programas[i].Referenciado = "Si";
                                }
                                else
                                {
                                    m.semana_Programas[i].Referenciado = "No";
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

                                if (m.semana_Programas[i].userLogs != null)
                                {
                                    m.semana_Programas[i].CalificadoLogs = m.semana_Programas[i].userLogs.logs_calificado.nombre_Usuario;
                                    m.semana_Programas[i].MasterLogs = m.semana_Programas[i].userLogs.logs_master.nombre_Usuario;
                                    m.semana_Programas[i].ReferenciaLogs = m.semana_Programas[i].userLogs.logs_referencia.nombre_Usuario;

                                    if (m.semana_Programas[i].userLogs.logs_referencia.nombre_Usuario != null)
                                    {
                                        DateTime dateTime3 = Convert.ToDateTime(m.semana_Programas[i].userLogs.logs_referencia.fecha_modificado);

                                        m.semana_Programas[i].ReferenciaFecha = dateTime3.ToString();
                                    }
                                    if (m.semana_Programas[i].userLogs.logs_master.nombre_Usuario != null)
                                    {
                                        DateTime dateTime3 = Convert.ToDateTime(m.semana_Programas[i].userLogs.logs_master.fecha_modificado);

                                        m.semana_Programas[i].MasterFecha = dateTime3.ToString();
                                    }
                                    if (m.semana_Programas[i].userLogs.logs_calificado.nombre_Usuario != null)
                                    {
                                        DateTime dateTime3 = Convert.ToDateTime(m.semana_Programas[i].userLogs.logs_calificado.fecha_modificado);

                                        m.semana_Programas[i].CalificadoFecha = dateTime3.ToString();
                                    }
                                }

                                DateTime dateTime = Convert.ToDateTime(m.semana_Programas[i].hora_Inicio);

                                m.semana_Programas[i].hora_Inicio = dateTime.ToString();

                                DateTime dateTime2 = Convert.ToDateTime(m.semana_Programas[i].hora_Fin);

                                m.semana_Programas[i].hora_Fin = dateTime2.ToString();

                            }


                            Console.WriteLine(m.semana_Programas);
                            dataGridView1.DataSource = m.semana_Programas;
                            dataGridView1.Columns["_id"].Visible = false;
                            dataGridView1.Columns["programa_Estatus"].Visible = false;
                            dataGridView1.Columns["userLogs"].Visible = false;
                            dataGridView1.Columns["hora_Inicio"].HeaderText = "Hora inicio";
                            dataGridView1.Columns["hora_Fin"].HeaderText = "Hora Fin";
                            dataGridView1.Columns["programa_Nombre"].HeaderText = "Nombre de programa";
                            dataGridView1.Columns["programa_Subnombre"].HeaderText = "Sub nombre";
                            dataGridView1.Columns["programa_Referencia"].HeaderText = "Referencia";
                            dataGridView1.Columns["hora_Inicio"].Width = 160;
                            dataGridView1.Columns["hora_Fin"].Width = 160;

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
            public string programa_Subnombre { get; set; }
            public MiClase3 programa_Estatus { get; set; }
            public string programa_Referencia { get; set; }
            public string Referenciado { get; set; }
            public string Calificado { get; set; }
            public string Master { get; set; }
            public Logs userLogs { get; set; }

            public string CalificadoLogs { get; set; }
            public string MasterLogs { get; set; }
            public string ReferenciaLogs { get; set; }

            public string CalificadoFecha { get; set; }
            public string MasterFecha { get; set; }
            public string ReferenciaFecha { get; set; }


        }

        public class Logs
        {
            public Log logs_referencia { get; set; }
            public Log logs_calificado { get; set; }
            public Log logs_master { get; set; }

        }

        public class Log
        {
            public string nombre_Usuario { get; set; }

            public string fecha_modificado { get; set; }
        }

        public class MiClase3
        {
            public Boolean Calificado { get; set; }
            public Boolean Referencia { get; set; }
            public Boolean Master { get; set; }

        }




        private void button_Parrilla_guardar_Click(object sender, EventArgs e)
        {

        
            Console.WriteLine(reference);
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

            Console.WriteLine(Modelo.accessToken);

            var url = $"http://localhost:9000/programs/update/status/" + id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            string njsonData = $"{{\"programa_Estatus\":{{\"Referencia\":{referencia},\"Calificado\":{calificado},\"Master\":{master}}},\"programa_Referencia\":\"{reference}\"}}";
            Console.WriteLine(njsonData);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer " + Modelo.accessToken);
            request.Accept = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(njsonData);
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
                            // Console.WriteLine(responseBody);
                            //textBox1.Text = responseBody ;

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }

            Cargar(id_programacion);
        }

        public static string reference;

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
                if (dataGridView1.Rows[e.RowIndex].Cells["programa_Referencia"].Value.ToString() != "")
                {
                    reference = dataGridView1.Rows[e.RowIndex].Cells["programa_Referencia"].Value.ToString();
                }
                if (dataGridView1.Rows[e.RowIndex].Cells["referenciado"].Value.ToString() == "Si")
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

                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count - 3);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)

                            {
                                if (col.HeaderText.ToString() == "_id" || col.HeaderText.ToString() == "programa_Estatus" || col.HeaderText.ToString() == "userLogs")
                                {

                                }
                                else
                                {
                                    if (col.HeaderText.ToString() == "programa_Nombre")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Nombre"));

                                        pTable.AddCell(pCell);
                                    }
                                    else if (col.HeaderText.ToString() == "hora_Inicio")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Fecha Inicio"));

                                        pTable.AddCell(pCell);
                                    }
                                    else if (col.HeaderText.ToString() == "hora_Fin")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Fecha Fin"));

                                        pTable.AddCell(pCell);
                                    }
                                    else if (col.HeaderText.ToString() == "CalificadoLogs")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Calificado por"));

                                        pTable.AddCell(pCell);
                                    }
                                    else if (col.HeaderText.ToString() == "MasterLogs")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Master por"));

                                        pTable.AddCell(pCell);
                                    }
                                    else if (col.HeaderText.ToString() == "ReferenciaLogs")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Referencia por"));

                                        pTable.AddCell(pCell);
                                    }
                                    else if (col.HeaderText.ToString() == "CalificadoFecha")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Fecha de calificaciÃ³n"));

                                        pTable.AddCell(pCell);
                                    }
                                    else if (col.HeaderText.ToString() == "MasterFecha")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Fecha de master"));

                                        pTable.AddCell(pCell);
                                    }
                                    else if (col.HeaderText.ToString() == "ReferenciaFecha")
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase("Fecha de referencia"));

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


                                    if (c == 0 || c == 5 || c == 10)
                                    {

                                    }
                                    else if (c == 6)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell("");
                                        }
                                    }
                                    else if (c == 11)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell("");
                                        }
                                    }
                                    else if (c == 12)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell("");
                                        }
                                    }
                                    else if (c == 13)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell("");
                                        }
                                    }
                                    else if (c == 14)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell("");
                                        }
                                    }
                                    else if (c == 15)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell("");
                                        }
                                    }
                                    else if (c == 16)
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                        else
                                        {
                                            pTable.AddCell("");
                                        }
                                    }
                                    else
                                    {
                                        if (dcell.Value != null)
                                        {
                                            pTable.AddCell(dcell.Value.ToString());
                                        }
                                    }
                                    /*
                                    */
                                    c++;



                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4.Rotate(), 50f, 50f, 130f, 50f);
                                PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance("D:\\Archivos de programa x86\\Visual\\repos\\SistemaParaElControlOperativoDelAreaDeCapturas\\SistemaParaElControlOperativoDelAreaDeCapturas\\logo-televisa.png");
                                pic.ScalePercent(50);
                                pic.SetAbsolutePosition(100, 490);
                                document.Add(pic);

                                PdfContentByte cb = writer.DirectContent;

                                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                                cb.SetFontAndSize(bf, 12);

                                cb.BeginText();
                                cb.SetTextMatrix(230, 520);
                                cb.ShowText("TELEVISA REGIONAL");
                                cb.EndText();

                                cb.BeginText();
                                cb.SetTextMatrix(400, 520);
                                cb.ShowText("ProgramaciÃ³n del " + dateStart + " al " + dateEnd);
                                cb.EndText();

                                cb.BeginText();
                                cb.SetTextMatrix(100, 480);
                                cb.ShowText("HERMOSILLO");
                                cb.EndText();

                                cb.BeginText();
                                cb.SetTextMatrix(610, 480);
                                cb.ShowText("C12-HERMOSILLO-12.1");
                                cb.EndText();

                                cb.BeginText();
                                cb.SetTextMatrix(320, 480);
                                cb.ShowText("XHAK-TV (HERMOSILLO)");
                                cb.EndText();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Se exportÃ³ el archivo correctamente!", "info");

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

            private void btn_Parilla_IngRef_Click(object sender, EventArgs e)
            {
            checkBox_Parrilla_Referencia.Checked = true;
            ReferenceDialog rfd = new ReferenceDialog();
            rfd.ShowDialog();
            }
    }
}

