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
    public partial class frmSignos : Form
    {
        public int ID_signo, valor = 0;
        public frmSignos()
        {
            InitializeComponent();
            cargarSignos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

     

        private void cargarSignos()
        {
            cmbSignos.DataSource = null;
            cmbSignos.Items.Clear();
            string sql = "SELECT id_sign, nombre FROM catalogo_signos WHERE estado = 1 AND visibilidad = 1 ORDER BY nombre ASC";
            MySqlConnection conexion = Conexion.GetConnection();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cmbSignos.ValueMember = "id_sign";
                cmbSignos.DisplayMember = "nombre";
                cmbSignos.DataSource = dt;
            } catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void limpiar()
        {
            txtObservacion.Text = "";
            txtValor1.Text = "";
            txtValor2.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Signos signo = new Signos();
            signo.Id_signo = int.Parse(cmbSignos.SelectedValue.ToString());
            signo.Valor1 = txtValor1.Text;
            signo.Valor2 = txtValor2.Text;
            signo.Observacion = txtObservacion.Text;
            signo.Id_consulta = Consulta.Id_cons;

            try
            { 
                Controlador control = new Controlador();
                string respuesta = control.ctrlsignos(signo);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult r = MessageBox.Show("Signo registrado correctamete ¿Desea añadir otro signo a esta consulta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        limpiar();
                        cargarSignos();
                    }
                    else
                    {
                        this.Visible = false;
                    }
                }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSignos_Load(object sender, EventArgs e)
        {
                cmbSignos.Focus();
                ActiveControl = cmbSignos;
                cmbSignos.DroppedDown = true;   
        }

        private void cmbSignos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor1.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtValor1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtValor2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtObservacion.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtObservacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Signos signo = new Signos();
                signo.Id_signo = int.Parse(cmbSignos.SelectedValue.ToString());
                signo.Valor1 = txtValor1.Text;
                signo.Valor2 = txtValor2.Text;
                signo.Observacion = txtObservacion.Text;
                signo.Id_consulta = Consulta.Id_cons;

                try
                {
                    Controlador control = new Controlador();
                    string respuesta = control.ctrlsignos(signo);
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult r = MessageBox.Show("Signo registrado correctamete ¿Desea añadir otro signo a esta consulta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (r == DialogResult.Yes)
                        {
                            MySqlConnection conexion = Conexion.GetConnection();
                            conexion.Open();
                            string sql2 = "UPDATE catalogo_signos SET visibilidad = 0 WHERE id_sign = '" + signo.Id_signo + "'";
                            limpiar();
                            MySqlCommand comando = new MySqlCommand(sql2, conexion);
                            comando.ExecuteNonQuery();
                            cargarSignos();
                        }
                        else
                        {
                            frmPrincipal frm = new frmPrincipal();
                            frm.Visible = true;
                            this.Visible = false;
                            MySqlConnection conexion = Conexion.GetConnection();
                            conexion.Open();
                            string sql2 = "UPDATE catalogo_signos SET visibilidad = 1 WHERE estado = 1";
                            MySqlCommand comando = new MySqlCommand(sql2, conexion);
                            comando.ExecuteNonQuery();
                        }
                        // MessageBox.Show("Signo registrado correctamete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                e.SuppressKeyPress = true;
            }
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnActSigno_Click(object sender, EventArgs e)
        {
            Signos sign = new Signos();
            sign.Id_signos = ID_signo;
            sign.Valor1 = txtValor1.Text;
            sign.Valor2 = txtValor2.Text;
            sign.Observacion = txtObservacion.Text;
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlractualizasigno(sign);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Signo editado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSignoev frm = new frmSignoev();
                    frm.Refresh();
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
