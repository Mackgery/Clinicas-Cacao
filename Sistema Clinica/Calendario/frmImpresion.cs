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
        public frmImpresion()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titulos = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
            Font texto = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            e.Graphics.DrawString(lbltitulo.Text, titulos, Brushes.Black, 50, 130);
            e.Graphics.DrawString(txtContenido.Text, titulos, Brushes.Black, 50, 230);
        }

        private void btnImpR_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();

        }

        private void frmImpresion_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
            this.Visible = false;
        }

        public void imprimir()
        {
            printPreviewDialog1.Show();
        }
    }
}
