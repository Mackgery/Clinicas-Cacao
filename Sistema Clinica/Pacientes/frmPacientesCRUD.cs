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
    public partial class frmPacientesCRUD : Form
    {
        public int codigo1;
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
            paciente.Codigo = int.Parse(txtCodigo.Text);
            

            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlregistroPaciente(paciente);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombres.Focus();
                }
                else
                {
                    MessageBox.Show("Paciente registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPrincipal frm2 = new frmPrincipal();
                    frm2.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmPacientesCRUD_Load(object sender, EventArgs e)
        {
            txtNombres.Focus();
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.Items.Add("Hombre");
            cmbSexo.Items.Add("Mujer");
            cmbSexo.SelectedIndex = 0;
            cmbSangre.Items.Add("Sin seleccionar");
            cmbSangre.Items.Add("A+");
            cmbSangre.Items.Add("A-");
            cmbSangre.Items.Add("B+");
            cmbSangre.Items.Add("B-");   
            cmbSangre.Items.Add("O+");
            cmbSangre.Items.Add("O-");
            cmbSangre.Items.Add("AB+");
            cmbSangre.Items.Add("AB-");
            cmbSangre.SelectedIndex = 0;
            txtCodigo.Enabled = false;
            MySqlDataReader reader;
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                string sql = "SELECT codigo FROM paciente ORDER BY codigo DESC LIMIT 1";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                codigo1 = int.Parse(reader.GetString(0));
                }
            
            int codigo = codigo1 + 1;
            txtCodigo.Text = codigo.ToString();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            txtNombres.Text= "";
            txtApellidos.Text = "";
            txtDPI.Text = "";
            dtFechaNac.Text = "";
            txtTelefono.Text = "";
            //txtCelular.Text = "";
            txtAlergias.Text= "";
            cmbSangre.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAlergias_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlergias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                        frmPrincipal frm2 = new frmPrincipal();
                        frm2.Visible = true;
                        this.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                limpiar();
                e.SuppressKeyPress = true;
            }
        }

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtApellidos.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtApellidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDPI.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDPI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSexo.Focus();
                ActiveControl = cmbSexo;
                e.SuppressKeyPress = true;
                cmbSexo.DroppedDown = true;
            }
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cmbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmbSexo_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cmbSexo_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
                /*dtFechaNac.Focus();
                if (dtFechaNac.Focus())
                {
                    SendKeys.Send("{F4}");
                }*/
                txtTelefono.Focus();
                e.SuppressKeyPress = true;
                
            }
        }

        private void dtFechaNac_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCelular.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSangre.Focus();
                ActiveControl = cmbSangre;
                e.SuppressKeyPress = true;
                cmbSangre.DroppedDown = true;
            }
        }

        private void cmbSangre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAlergias.Focus();
                e.SuppressKeyPress = true;

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

