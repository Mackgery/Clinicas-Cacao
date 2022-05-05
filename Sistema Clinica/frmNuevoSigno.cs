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
            string sql = "INSERT into catalogo_signos (nombre, descripcion, estado, medida) VALUES ('" + nombre + "', '" + descripcion + "','" + estado +"','" + medida + "')";
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Signo guardado correctamente");
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
    }
    }

