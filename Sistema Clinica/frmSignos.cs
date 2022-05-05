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
        public frmSignos()
        {
            InitializeComponent();
            cargarSignos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmConsulta frm = new frmConsulta();
            frm.Visible = true;
            this.Visible = false;
        }

        private void cmbSignos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarSignos()
        {
            cmbSignos.DataSource = null;
            cmbSignos.Items.Clear();
            string sql = "SELECT id_sign, nombre FROM catalogo_signos WHERE estado = 1 ORDER BY nombre ASC";

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Signos signo = new Signos();
            signo.Id_signo = int.Parse(cmbSignos.SelectedValue.ToString());
            signo.Valor1 = txtValor1.Text;
            signo.Valor2 = txtValor2.Text;
            signo.Observacion = txtObservacion.Text;
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
                    MessageBox.Show("Signo registrado correctamete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
