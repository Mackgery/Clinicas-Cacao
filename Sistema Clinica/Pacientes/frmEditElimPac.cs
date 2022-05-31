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
        public int validar = 0;
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
            paciente.Dpicom = txtDPI.Text;
           
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: ", ex.Message);
            }
            btnEliminar.Visible = false;
            btnEditar.Location = new Point(916, 419);
            Text = "Editar Paciente";
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            cmbSangre.Enabled = false;
            txtTelefono.Enabled = false;
            txtCelular.Enabled = false;
            dtmNacimiento.Enabled = false;
            txtAlergias.Enabled = false;
            cmbSexo.Enabled = false;
            txtDPI.Enabled = false;
            btnEditar.Visible = false;
            validar = 1;
            CargarTabla(null);
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

      

        private void CargarTabla(string dato)
        {
            List<Pacientes> lista = new List<Pacientes>();
            Controlador ctrl = new Controlador();
            dtgvPacientes.DataSource = ctrl.consultapac(dato);
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
                    control.ctrleliminapac(paciente);
                    MessageBox.Show("Paciente eliminado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
/*                    DialogResult r = MessageBox.Show("¿Seguro que desea eliminar este paciente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                    }*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: ", ex.Message);
            }
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            cmbSangre.Enabled = false;
            txtTelefono.Enabled = false;
            txtCelular.Enabled = false;
            dtmNacimiento.Enabled = false;
            txtAlergias.Enabled = false;
            cmbSexo.Enabled = false;
            txtDPI.Enabled = false;
            btnEditar.Visible = false;
            btnEliminar.Location = new Point(916, 419);
            Text = "Eliminar Paciente";
            CargarTabla(null);
            limpiar();
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

        private void dtgvPacientes_DoubleClick(object sender, EventArgs e)
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
            if (validar == 1)
            {
                txtNombres.Enabled = true;
                txtApellidos.Enabled = true;
                cmbSangre.Enabled = true;
                txtTelefono.Enabled = true;
                txtCelular.Enabled = true;
                dtmNacimiento.Enabled = true;
                txtAlergias.Enabled = true;
                cmbSexo.Enabled = true;
                txtDPI.Enabled = true;
                btnEditar.Visible = true;
            }
        }

        private void txtDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
            e.Handled = char.IsWhiteSpace(e.KeyChar);

        }
    }
}
