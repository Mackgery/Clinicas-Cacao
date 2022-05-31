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
            cmbCatSign.DropDownStyle = ComboBoxStyle.DropDownList;
           
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
            frmCalendario frm = new frmCalendario();
            frm.Visible = true;
            this.Visible = false;
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmUsuariosCRUD frm = new frmUsuariosCRUD();
            frmEditElimUs frm2 = new frmEditElimUs();
            //Catalogo_signos cats = null;
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
                    frm2.btnEditar.Visible = false;
                    frm2.txtNombres.Enabled = false;
                    frm2.txtApellidos.Enabled = false;
                    frm2.txtUsuario.Enabled = false;
                    frm2.Text = "Editar usuarios";
                    frm2.txtContra.Enabled = false;
                    frm2.validar = 1;
                    //cats.Cambio = 1;
                    
                    break;
                case 2:
                    frm2.Visible = true;
                    this.Visible = false;
                    frm2.txtNombres.Enabled = false;
                    frm2.txtApellidos.Enabled = false;
                    frm2.txtUsuario.Enabled = false;
                    frm2.btnEditar.Visible = false;
                    frm2.btnEliminar.Location = new Point(582,318);
                    frm2.Text = "Eliminar usuarios";
                    frm2.validar = 2;
                    frm2.txtContra.Visible = false;
                    //cats.Cambio = 2;
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
                    frm2.Text = "Editar Paciente";
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
                    frm2.validar = 1;
                    
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
                    frm2.Text = "Eliminar Paciente";
                    frm2.validar = 2;
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
            Catalogo_signos cats = new Catalogo_signos();
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
                    frm.lbltexto.Visible = false;
                    frm.txtDescripcion.Enabled = false;
                    frm.txtMedida.Enabled = false;
                    frm.txtNombre.Enabled = false;
                    frm.cmbEstado.Enabled = false;
                    frm.btnActualizar.Visible = false;
                    frm.dtvgcats.Location = new Point(12, 71);
                    break;
                
            }
        }

        private void grpUsu_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
