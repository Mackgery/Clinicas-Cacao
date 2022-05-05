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
    public partial class frmEditElimPac : Form
    {
       
        public frmEditElimPac()
        {
            InitializeComponent();
            CargarTabla(null);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            CargarTabla(dato);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            Pacientes paciente = new Pacientes();
            frmPrincipal frm = new frmPrincipal();
            paciente.Id = int.Parse(dtgvPacientes.CurrentRow.Cells[9].Value.ToString());
            paciente.Nombres = txtNombres.Text;
            paciente.Apellidos = txtApellidos.Text;
            paciente.DPI1 = txtDPI.Text;
            paciente.Sexo = cmbSexo.Text;
            paciente.Nacimiento = dtmNacimiento.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Celular = txtCelular.Text;
            paciente.Tipo_sangre = cmbSangre.Text;
            paciente.Alergias = txtAlergias.Text;
            paciente.Idusmod = frm.id_usuario;
           
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlactualizapaciente(paciente);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Seguro que desea actualizar este Paciente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        MessageBox.Show("Paciente actualizado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.Visible = true;
                        this.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: ", ex.Message);
            }
            limpiar();

        }

        private void frmEditElimPac_Load(object sender, EventArgs e)
        {
            txtNombres.Focus();
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

        private void frmEditElimPac_formClosed(object sender, EventArgs e)
        {
            Application.Exit();
            Session ss = new Session();
        }

        private void frmEditElimPac_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Session ss = new Session();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      

        private void CargarTabla(string dato)
        {
            List<Pacientes> lista = new List<Pacientes>();
            Controlador ctrl = new Controlador();
            dtgvPacientes.DataSource = ctrl.consultapac(dato);
        }

        private void dtgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombres.Text = dtgvPacientes.CurrentRow.Cells[0].Value.ToString();
            txtApellidos.Text = dtgvPacientes.CurrentRow.Cells[1].Value.ToString();
            txtDPI.Text = dtgvPacientes.CurrentRow.Cells[2].Value.ToString();
            cmbSexo.Text = dtgvPacientes.CurrentRow.Cells[3].Value.ToString();
            dtmNacimiento.Text = dtgvPacientes.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dtgvPacientes.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = dtgvPacientes.CurrentRow.Cells[6].Value.ToString();
            cmbSangre.Text = dtgvPacientes.CurrentRow.Cells[7].Value.ToString();
            txtAlergias.Text = dtgvPacientes.CurrentRow.Cells[8].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pacientes paciente = new Pacientes();
            paciente.Nombres = txtNombres.Text;
            paciente.Apellidos = txtApellidos.Text;
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlcompruebapaciente(paciente);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Seguro que desea eliminar este paciente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        control.ctrleliminapac(paciente);
                        MessageBox.Show("Paciente eliminado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: ", ex.Message);
            }
            CargarTabla(null);
            limpiar();
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvPacientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombres.Text = dtgvPacientes.CurrentRow.Cells[0].Value.ToString();
                txtApellidos.Text = dtgvPacientes.CurrentRow.Cells[1].Value.ToString();
                txtDPI.Text = dtgvPacientes.CurrentRow.Cells[2].Value.ToString();
                cmbSexo.Text = dtgvPacientes.CurrentRow.Cells[3].Value.ToString();
                dtmNacimiento.Text = dtgvPacientes.CurrentRow.Cells[4].Value.ToString();
                txtTelefono.Text = dtgvPacientes.CurrentRow.Cells[5].Value.ToString();
                txtCelular.Text = dtgvPacientes.CurrentRow.Cells[6].Value.ToString();
                cmbSangre.Text = dtgvPacientes.CurrentRow.Cells[7].Value.ToString();
                txtAlergias.Text = dtgvPacientes.CurrentRow.Cells[8].Value.ToString();

                e.SuppressKeyPress = true;
            }
        }

        private void limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDPI.Text = "";
            cmbSexo.Text = "";
            dtmNacimiento.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            cmbSangre.Text = "";
            txtAlergias.Text = "";
        }
    }
}
