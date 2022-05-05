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
    public partial class frmPacientesCRUD : Form
    {
        public frmPacientesCRUD()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            int indice = cmbSexo.SelectedIndex;
            int indice2 = cmbSangre.SelectedIndex;
            Pacientes paciente = new Pacientes();
            paciente.Nombres = txtNombres.Text;
            paciente.Apellidos = txtApellidos.Text;
            paciente.DPI1 = txtDPI.Text;
            paciente.Sexo = cmbSexo.Items[indice].ToString();
            paciente.Nacimiento = this.dtFechaNac.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Celular = txtCelular.Text;
            paciente.Tipo_sangre = cmbSangre.Items[indice2].ToString();
            paciente.Alergias = txtAlergias.Text;
            paciente.Iduscrea = frm.id_usuario;
            

            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlregistroPaciente(paciente);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Paciente registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmPacientesCRUD_Load(object sender, EventArgs e)
        {
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.Items.Add("Hombre");
            cmbSexo.Items.Add("Mujer");
            cmbSexo.SelectedIndex = 0;
            cmbSangre.Items.Add("A+");
            cmbSangre.Items.Add("A-");
            cmbSangre.Items.Add("B+");
            cmbSangre.Items.Add("B-");
            cmbSangre.Items.Add("O+");
            cmbSangre.Items.Add("O-");
            cmbSangre.Items.Add("AB+");
            cmbSangre.Items.Add("AB-");
            cmbSangre.SelectedIndex = 0;
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
