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
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
            CargarTabla(null);

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {

        }

        private void CargarTabla(string dato)
        {
            List<Pacientes> lista = new List<Pacientes>();
            Controlador ctrl = new Controlador();
            dtgvPacientes.DataSource = ctrl.consultapac(dato);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            CargarTabla(dato);
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmConsulta frm = new frmConsulta();
            frm.Visible = true;
            this.Visible = false;
            frm.btnSignos.Visible = false;
            frm.lblsignos.Visible = false;
            frm.lblnota.Visible = false;
            frm.lbllinea1.Visible = false;
            frm.lbllinea3.Visible = false;
            frm.lbllinea4.Visible = false;
            frm.btnEditar.Visible = false;
            frm.dtgSignos.Visible = false;
            frm.lblCodigo.Visible = false;
            frm.lblCodi.Visible = false;
            frm.txtPaciente.Visible = false;
            frm.txtNomProv.Location = new Point(177, 74);
        }

        private void dtgvPacientes_DoubleClick(object sender, EventArgs e)
        {
            frmConsulta frm = new frmConsulta();
            frm.txtPaciente.Text = dtgvPacientes.CurrentRow.Cells[0].Value.ToString();
            Consulta.idpac = int.Parse(dtgvPacientes.CurrentRow.Cells[9].Value.ToString());
            Consulta.nompac = dtgvPacientes.CurrentRow.Cells[0].Value.ToString();
            Consulta.apellido = dtgvPacientes.CurrentRow.Cells[1].Value.ToString();
            frm.lblCodigo.Text = dtgvPacientes.CurrentRow.Cells[10].Value.ToString();

            frm.Visible = true;
            this.Visible = false;
            frm.btnSignos.Visible = false;
            frm.lblsignos.Visible = false;
            frm.lblnota.Visible = false;
            frm.lbllinea1.Visible = false;
            frm.lbllinea3.Visible = false;
            frm.lbllinea4.Visible = false;
            frm.btnEditar.Visible = false;
            frm.dtgSignos.Visible = false;
            frm.lblCodigo.Visible = true;
            frm.lblCodi.Visible = true;
            frm.txtNomProv.Visible = false;
            frm.txtPaciente.Enabled = false;
            frm.lblCodigo.Enabled = false;
            //frm.txtNomProv.Enabled = false;
        }

       
    }
}
