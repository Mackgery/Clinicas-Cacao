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
    public partial class frmEditElim : Form
    {
        public frmEditElim()
        {
            InitializeComponent();
        }

        private void dtgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEditElim_Load(object sender, EventArgs e)
        {
            getlista();
        }

        private void getlista()
        {
            MySqlConnection conexion = Conexion.GetConnection();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = ("SELECT Nombres, Apellidos, Usuario FROM usuario");
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dtgvUsuarios.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String usuario = txtBuscar.Text;
            MySqlDataReader reader = null;

            string sql = "SELECT Nombres, Apellidos, Usuario FROM usuario Where Usuario = '" + usuario + "'";
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtNombres.Text = reader.GetString(0);
                        txtApellidos.Text = reader.GetString(1);
                        txtUsuario.Text = reader.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar"+ ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Nombres = txtNombres.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Usuario = txtUsuario.Text;
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlactualiza(usuario);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Seguro que desea actualizar este usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        MessageBox.Show("Usuario actualizado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPrincipal frm = new frmPrincipal();
                        frm.Visible = true;
                        this.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: ", ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Usuario = txtUsuario.Text;
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlcomprueba(usuario);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Seguro que desea eliminar este usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        control.ctrlelimina(usuario);
                        MessageBox.Show("Usuario eliminado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: ", ex.Message);
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
