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
    public partial class frmEditElimUs : Form
    {
        public int validar = 0;
       public frmEditElimUs()
        {
            InitializeComponent();
            CargarTabla(null);
        }

        private void FrmPrueba_Load(object sender, EventArgs e)
        {
            txtNombres.Focus();  
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            CargarTabla(dato);
        }

        private void CargarTabla (string dato)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Controlador ctrl = new Controlador();
            dtgvUsuarios.DataSource = ctrl.consulta(dato);
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            Usuarios usuario = new Usuarios();
            usuario.Id =int.Parse(dtgvUsuarios.CurrentRow.Cells[3].Value.ToString());
            usuario.Nombres = txtNombres.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Usuario = txtUsuario.Text;
            usuario.Newpass = txtContra.Text;
            try
            {
                Controlador control = new Controlador();
                if (string.IsNullOrEmpty(txtContra.Text))
                {
                    string respuesta = control.ctrlactualiza(usuario);
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Usuario actualizado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
                else
                {
                    string respuesta = control.ctrlacttodo(usuario);
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Usuario actualizado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: ", ex.Message);
            }
            btnEliminar.Visible = false;
            btnEditar.Location = new Point(582, 318);
            btnEditar.Visible = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtUsuario.Enabled = false;
            txtContra.Enabled = false;
            validar = 1;
            CargarTabla(null);
        }

        private void dtgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
                    control.ctrlelimina(usuario);
                    MessageBox.Show("Usuario eliminado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                /*DialogResult r = MessageBox.Show("¿Seguro que desea eliminar este usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                                             
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: ", ex.Message);
            }
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtUsuario.Enabled = false;
            btnEditar.Visible = false;
            btnEliminar.Location = new Point(582, 318);
            validar = 2;
            CargarTabla(null);
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
                txtUsuario.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (btnEditar.Visible == true)
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Id = int.Parse(dtgvUsuarios.CurrentRow.Cells[3].Value.ToString());
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
                                limpiar();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar: ", ex.Message);
                    }

                }
                else
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
                    CargarTabla(null);
                    limpiar();
                }
                e.Handled = true;
            }
        }

        private void dtgvUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

        private void dtgvUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombres.Text = dtgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtApellidos.Text = dtgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtUsuario.Text = dtgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                if (validar == 1)
                {
                    btnEditar.Visible = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtUsuario.Enabled = true;
                }
                e.SuppressKeyPress = true;
            }
        }
        private void limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtUsuario.Text = "";
            txtContra.Text = "";
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            txtNombres.Text = dtgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtApellidos.Text = dtgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtUsuario.Text = dtgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            if(validar  == 1) { 
            btnEditar.Visible = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtUsuario.Enabled = true;
            txtContra.Enabled = true;
            }
        }
    }
}
