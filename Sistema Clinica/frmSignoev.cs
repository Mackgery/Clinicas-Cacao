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
    public partial class frmSignoev : Form
    {
        public int data;
        public frmSignoev()
        {
            InitializeComponent();
        }

        private void frmSignoev_Load(object sender, EventArgs e)
        {
            data = Consulta.id_cons;
            CargarTabla(data);
        }
        private void CargarTabla(int dato)
        {
            List<Consulta> lista = new List<Consulta>();
            Controlador ctrl = new Controlador();
            dtgSignos.DataSource = ctrl.Signosconsulta(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSignos_Click(object sender, EventArgs e)
        {
            frmSignos frm = new frmSignos();
            frm.Visible = true;
            frm.txtsigno.Visible = false;
            frm.btnActSigno.Visible = false;
            frm.btnRegresar.Visible = false;
            frm.btnRe.Location = new Point(228, 378);
            frm.Visible = true;
            if (string.IsNullOrEmpty(Consulta.nombre_prov))
            {
                frm.lblPaciente.Text = Consulta.nompac + " " + Consulta.apellido;
            }
            else
            {
                frm.lblPaciente.Text = Consulta.nombre_prov;
            }
        }

        private void dtgSignos_DoubleClick(object sender, EventArgs e)
        {
            int id_sign = int.Parse(dtgSignos.CurrentRow.Cells[0].Value.ToString());
            string nombre = dtgSignos.CurrentRow.Cells[1].Value.ToString();
            string valor1 = dtgSignos.CurrentRow.Cells[2].Value.ToString();
            string valor2 = dtgSignos.CurrentRow.Cells[3].Value.ToString();
            string observacion = dtgSignos.CurrentRow.Cells[4].Value.ToString();
            frmSignos frm = new frmSignos();
            frm.Visible = true;
            frm.cmbSignos.Visible = false;
            frm.cmbSignos.Enabled = false;
            frm.txtsigno.Location = new Point(168, 31);
            frm.btnActSigno.Location = new Point(69, 378);
            frm.btnRegresar.Visible = false;
            frm.btnGuardar.Visible = false;
            frm.btnRe.Location = new Point(228, 378);
            if (string.IsNullOrEmpty(Consulta.nombre_prov))
            {
                frm.lblPaciente.Text = Consulta.nompac + " " + Consulta.apellido;
            }
            else
            {
                frm.lblPaciente.Text = Consulta.nombre_prov;
            }
            frm.txtsigno.Enabled = false;
            frm.txtsigno.Text = nombre;
            frm.txtValor1.Text = valor1;
            frm.txtValor2.Text = valor2;
            frm.txtObservacion.Text = observacion;
            frm.ID_signo = id_sign;
        }
    }
}
