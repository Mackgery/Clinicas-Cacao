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
    public partial class frmCatalogoSig : Form
    {
        public int inicializar = 0;
        public string estado;
        public int id_signo = 0;
        public frmCatalogoSig()
        {
            InitializeComponent();
        }

        private void frmCatalogoSig_Load(object sender, EventArgs e)
        {
            CargarTabla(null);
            estados();
        }
        private void estados()
        {
            cmbEstado.Items.Add("Habilitado");
            cmbEstado.Items.Add("Deshabilitado");
            cmbEstado.SelectedIndex = 0;
        }
        private void CargarTabla(string dato)
        {
            List<Catalogo_signos> lista = new List<Catalogo_signos>();
            Controlador ctrl = new Controlador();
            dtvgcats.DataSource = ctrl.consultasignos(dato);
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtMedida.Text = "";
            cmbEstado.Text = "";
        }



        public void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor primero seleccione un signo de la lista");
            }
            else
            {
                int id_sign = int.Parse(dtvgcats.CurrentRow.Cells[0].Value.ToString());
                string sql = "UPDATE catalogo_signos SET estado = 0 WHERE id_sign = '" + id_sign + "'";
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Actualizado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aviso" + ex);
                }
                CargarTabla(null);
                limpiar();
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            CargarTabla(dato);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string medida = txtMedida.Text;
            int id_sign = 0;
            int estado = int.Parse(dtvgcats.CurrentRow.Cells[1].Value.ToString());
            id_sign = int.Parse(dtvgcats.CurrentRow.Cells[0].Value.ToString());
            int indice = cmbEstado.SelectedIndex;
            string estadodesc = cmbEstado.Items[indice].ToString();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor primero seleccione un signo de la lista");
            }
            else
            {
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                string sql = "UPDATE catalogo_signos SET nombre = '" + nombre + "', descripcion = '" + descripcion + "', medida = '" + medida + "', estadodesc = '" + estadodesc + "' WHERE id_sign = '" + id_sign + "'";
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    int resultado = comando.ExecuteNonQuery();
                    MessageBox.Show("Actualizado correctamente", "Aviso", MessageBoxButtons.OK);
//                    DialogResult r = MessageBox.Show("Signo actualizado correctamente, ¿Desea cambiar su estado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al modificar : " + ex.Message);
                }
                lbltexto.Visible = false;
                txtDescripcion.Enabled = false;
                txtMedida.Enabled = false;
                txtNombre.Enabled = false;
                cmbEstado.Enabled = false;
                btnActualizar.Visible = false;
                dtvgcats.Location = new Point(12, 71);
                CargarTabla(null);
                limpiar();
                cmbEstado.SelectedIndex = 0;
            }

            
        }


        private void cargarEstado()
        {
            id_signo = int.Parse(dtvgcats.CurrentRow.Cells[0].Value.ToString());
            MySqlDataReader reader;
            string sql;
            sql = "SELECT estadodesc FROM catalogo_signos WHERE id_sign = '" + id_signo + "'";
            try
            {
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    estado = reader.GetString(0);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
            if(estado == "Habilitado")
            {
                cmbEstado.SelectedIndex = 0;
            }else
            {
                cmbEstado.SelectedIndex = 1;
            }
        }

        private void dtvgcats_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = dtvgcats.CurrentRow.Cells[2].Value.ToString();
            txtDescripcion.Text = dtvgcats.CurrentRow.Cells[3].Value.ToString();
            txtMedida.Text = dtvgcats.CurrentRow.Cells[4].Value.ToString();
            cargarEstado();
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            txtMedida.Enabled = true;
            btnActualizar.Visible = true;
            cmbEstado.Enabled = true;
            id_signo = int.Parse(dtvgcats.CurrentRow.Cells[0].Value.ToString());
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

