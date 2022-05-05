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
    public partial class frmConsulta : Form
    {
        public int prueba;
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnSignos_Click(object sender, EventArgs e)
        {
            frmSignos frm = new frmSignos();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea añadir signos vitales a este paciente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                frmSignos frm = new frmSignos();
                frm.Visible = true;
                this.Visible = false;
            }
        }

        private void frmConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Session ss = new Session();
        }
    }
}
