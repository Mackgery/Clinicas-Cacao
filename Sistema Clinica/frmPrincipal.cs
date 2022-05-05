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
    public partial class frmPrincipal : Form
    {
        public int id_usuario = Session.id_usuario;

        public frmPrincipal()
        {
            InitializeComponent();

            grpUsu.Text = Session.usuario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPacientes.DropDownStyle = ComboBoxStyle.DropDownList;
            /*cmbUsuarios.Items.Add("Usuarios");
            cmbUsuarios.SelectedIndex = 3;
            */
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientesCRUD frm = new frmPacientesCRUD();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsulta frm = new frmConsulta();
            frm.Visible = true;
            this.Visible = false;
            frm.btnSignos.Visible = false;
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmUsuariosCRUD frm = new frmUsuariosCRUD();
            frmEditElimUs frm2 = new frmEditElimUs();
            int indice = cmbUsuarios.SelectedIndex;

            indice.ToString();

            switch (indice)
            {
                case 0:
                    frm.Visible = true;
                    this.Visible = false;
                    break;
                case 1:
                    frm2.Visible = true;
                    this.Visible = false; 
                    frm2.btnEliminar.Visible = false;
                    frm2.btnEditar.Location = new Point(582, 318);
                    break;
                case 2:
                    frm2.Visible = true;
                    this.Visible = false;
                    frm2.txtNombres.Enabled = false;
                    frm2.txtApellidos.Enabled = false;
                    frm2.txtUsuario.Enabled = false;
                    frm2.btnEditar.Visible = false;
                    frm2.btnEliminar.Location = new Point(582,318);
                    break;
                

            }
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmPacientesCRUD frm = new frmPacientesCRUD();
            frmEditElimPac frm2 = new frmEditElimPac();
            int indice = cmbPacientes.SelectedIndex;

            indice.ToString();

            switch (indice)
            {
                case 0:
                    frm.Visible = true;
                    this.Visible = false;
                    break;
                case 1:
                    frm2.Visible = true;
                    this.Visible = false;
                    frm2.btnEliminar.Visible = false;
                    frm2.btnEditar.Location = new Point(916, 419);
                    break;
                case 2:
                    frm2.Visible = true;
                    this.Visible = false;
                    frm2.txtNombres.Enabled = false;
                    frm2.txtApellidos.Enabled = false;
                    frm2.cmbSangre.Enabled = false;
                    frm2.txtTelefono.Enabled = false;
                    frm2.txtCelular.Enabled = false;
                    frm2.dtmNacimiento.Enabled = false;
                    frm2.txtAlergias.Enabled = false;
                    frm2.cmbSexo.Enabled = false;
                    frm2.txtDPI.Enabled = false;
                    frm2.btnEditar.Visible = false;
                    frm2.btnEliminar.Location = new Point(916, 419);
                    break;
                
            }
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            frmCatalogoSig frm = new frmCatalogoSig();
            frm.Visible = true;
            this.Visible = false;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Session ss = new Session();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin frm = new frmLogin();
            frm.Visible = true;

            Session ss = new Session();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmContra frm = new frmContra();
            frm.Visible = true;
            this.Visible = false;
        }

        public void cmbCatSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmCatalogoSig frm = new frmCatalogoSig();
            frmNuevoSigno frm2 = new frmNuevoSigno();
            Usuarios usuario = new Usuarios();
            int indice = cmbCatSign.SelectedIndex;
            usuario.Indice = indice;

            indice.ToString();

            switch (indice)
            {
                case 0:
                    frm2.Visible = true;
                    this.Visible = false;
                    break;
                case 1:
                    frm.Visible = true;
                    this.Visible = false;
                    frm.lbltexto.Text = "Deshabilitados";
                    frm.button1.Visible = true;
                    frm.cmbSignos.Visible = false;
                    frm.button2.Visible = false;
                    frm.button1.Location = new Point(94, 140);
                    frm.lbltexto.Location = new Point(58, 48);
                    frm.btnCancelar.Location = new Point(94, 169);
                    break;
                case 2:
                    frm.Visible = true;
                    this.Visible = false;
                    frm.lbltexto.Text = "Habilitados";
                    frm.button2.Visible = true;
                    frm.button1.Visible = false;
                    frm.cmbSignos2.Visible = false;
                    frm.button2.Location = new Point(94, 140);
                    frm.lbltexto.Location = new Point(76, 48);
                    frm.btnCancelar.Location = new Point(94, 169);

                    break;
                
            }
        }

        private void grpUsu_Enter(object sender, EventArgs e)
        {

        }
    }
}
