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
    public partial class frmEvaluacion : Form
    {
        public int id_cons, valor = 0;
        public frmEvaluacion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
                frmCalendario frm = new frmCalendario();
                frm.Visible = true;
                this.Visible = false;
            }
        

        private void frmEvaluacion_Load(object sender, EventArgs e)
        {
            id_cons = Consulta.id_cons;
            txtEvaluacion.Focus();
            txtEvaluacion.Text = id_cons.ToString();
        }

       

        private void btnEditar_Click(object sender, EventArgs e)
        {
         
            EvaDatos evaluacion = new EvaDatos();
            evaluacion.Id_consulta = id_cons;
            evaluacion.Evaluacion = txtEvaluacion.Text;
            evaluacion.Laboratorios = txtLaboratorios.Text;
            evaluacion.Receta = txtReceta.Text;
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlactualizaEvaluacion(evaluacion);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Evaluacion editada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEvaluacion.Enabled = false;
                    txtLaboratorios.Enabled = false;
                    txtReceta.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int valor = 0;
            EvaDatos evaluacion = new EvaDatos();
            evaluacion.Id_consulta = id_cons;
            evaluacion.Evaluacion = txtEvaluacion.Text;
            evaluacion.Laboratorios = txtLaboratorios.Text;
            evaluacion.Receta = txtReceta.Text;
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlregistroEvaluacion(evaluacion);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valor = 0;

                }
                else
                {
                    MessageBox.Show("Evaluacion registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valor = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (valor == 1)
            {
                btnEditar.Visible = true;
                btnImpL.Visible = true;
                btnImpR.Visible = true;
                btnEditar.Location = new Point(189, 438);
                btnImpL.Location = new Point(267, 481);
                btnImpR.Location = new Point(105, 481);
                btnGuardar.Location = new Point(20, 438);
                btnRegresar.Location = new Point(356, 438);
                btnGuardar.Visible = false;
                txtEvaluacion.Enabled = false;
                txtLaboratorios.Enabled = false;
                txtReceta.Enabled = false;
                btnhab.Visible = true;
                btnhab.Location = new Point(20, 438);
            }
        }

      

      

        private void btnImpR_Click(object sender, EventArgs e)
        {
            frmImpresion frm = new frmImpresion();
            frm.lbltitulo.Text = "Receta";
            frm.txtContenido.Text = txtReceta.Text;
            frm.imprimir();
        }

        private void btnImpL_Click(object sender, EventArgs e)
        {
            frmImpresion frm = new frmImpresion();
            frm.lbltitulo.Text = "Laboratorios";
            frm.txtContenido.Text = txtLaboratorios.Text;
            frm.Visible = true;
        }

        private void txtEvaluacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLaboratorios.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtLaboratorios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReceta.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtReceta_KeyDown(object sender, KeyEventArgs e)
        {
            int valor = 0;
            EvaDatos evaluacion = new EvaDatos();
            evaluacion.Id_consulta = id_cons;
            evaluacion.Evaluacion = txtEvaluacion.Text;
            evaluacion.Laboratorios = txtLaboratorios.Text;
            evaluacion.Receta = txtReceta.Text;
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlregistroEvaluacion(evaluacion);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valor = 0;

                }
                else
                {
                    MessageBox.Show("Evaluacion registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valor = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (valor == 1)
            {
                btnEditar.Visible = true;
                btnImpL.Visible = true;
                btnImpR.Visible = true;
                btnEditar.Location = new Point(189, 438);
                btnImpL.Location = new Point(267, 481);
                btnImpR.Location = new Point(105, 481);
                btnGuardar.Location = new Point(20, 438);
                btnRegresar.Location = new Point(356, 438);
                btnGuardar.Visible = false;
                txtEvaluacion.Enabled = false;
                txtLaboratorios.Enabled = false;
                txtReceta.Enabled = false;
                btnhab.Visible = true;
                btnhab.Location = new Point(20, 438);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmSignoev frm = new frmSignoev();
            frm.Visible = true;
        }

        private void btnhab_Click(object sender, EventArgs e)
        {
            txtEvaluacion.Enabled = true;
            txtLaboratorios.Enabled = true;
            txtReceta.Enabled = true;          
            btnImpL.Enabled = false;
            btnImpR.Enabled = false;
            txtEvaluacion.Focus();
        }
    }
}
