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
    public partial class frmNuevoSigno : Form
    {
        public frmNuevoSigno()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string medida = txtMedida.Text;
            int estado = 1;
            string sql = "INSERT into catalogo_signos (nombre, descripcion, estado, medida, estadodesc) VALUES ('" + nombre + "', '" + descripcion + "','" + estado +"','" + medida + "', 'Habilitado')";
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Signo guardado correctamente");
                frmPrincipal frm2 = new frmPrincipal();
                frm2.Visible = true;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aviso" + ex);
            }
           

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

        private void frmNuevoSigno_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescripcion.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMedida.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                string medida = txtMedida.Text;
                int estado = 1;
                string sql = "INSERT into catalogo_signos (nombre, descripcion, estado, medida, estadodesc) VALUES ('" + nombre + "', '" + descripcion + "','" + estado + "','" + medida + "', 'Habilitado')";
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Signo guardado correctamente");
                    frmPrincipal frm2 = new frmPrincipal();
                    frm2.Visible = true;
                    this.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aviso" + ex);
                }
                e.Handled = true;
            }
        }
    }
    }

