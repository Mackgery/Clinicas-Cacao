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
    public partial class frmContra : Form
    {
        public frmContra()
        {
            InitializeComponent();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Usuario = Session.usuario;
            usuario.Pass = txtPass.Text;
            usuario.Newpass = txtnPass.Text;
            usuario.Conpass = txtConf.Text;

            try
            {
                Controlador controlador = new Controlador();
                string respuesta = controlador.ctrlnuevacontra(usuario);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Contraseña actualizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }
    }
}
