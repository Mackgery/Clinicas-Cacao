using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Clinica
{
    public partial class frmImpresion : Form
    {
        //Bitmap memoryImage;
        public frmImpresion()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);*/
          /*  Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            e.Graphics.DrawImage(memoryImage, 0, 0);*/


            /*            Font titulos = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
                        Font texto = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
                        e.Graphics.DrawString(lbltitulo.Text, titulos, Brushes.Black, 50, 130);
                        e.Graphics.DrawString(txtContenido.Text, titulos, Brushes.Black, 50, 230);*/
        }

        private void btnImpR_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();

        }

        private void frmImpresion_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            DataTable dt = new DataTable();
            string sql;
            sql = "SELECT CONCAT (p.`nombres`, ' ', p.`apellidos`) AS completo,  e.`receta` FROM evaluacion e INNER JOIN consulta c ON c.`ID_consulta` = e.`ID_consulta` INNER JOIN paciente p ON c.`ID_paciente` = p.`ID_paciente` WHERE e.`ID_consulta` = '" + Consulta.id_cons + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();


//            printPreviewDialog1.Show();
            this.Visible = false;
            this.reportViewer1.RefreshReport();
        }

        public void imprimir()
        {
            printPreviewDialog1.Show();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
