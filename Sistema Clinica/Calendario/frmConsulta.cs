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
    public partial class frmConsulta : Form
    {
        public int valor = 0, ampm, prueba;
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {   
            cmbHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAMPM.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHora.Items.Add("1:00");
            cmbHora.Items.Add("2:00");
            cmbHora.Items.Add("3:00");
            cmbHora.Items.Add("4:00");
            cmbHora.Items.Add("5:00");
            cmbHora.Items.Add("6:00");
            cmbHora.Items.Add("7:00");
            cmbHora.Items.Add("8:00");
            cmbHora.Items.Add("9:00");
            cmbHora.Items.Add("10:00");
            cmbHora.Items.Add("11:00");
            cmbHora.Items.Add("12:00");
            cmbAMPM.Items.Add("AM");
            cmbAMPM.Items.Add("PM");
            cmbEstado.Items.Add("Activa");
            cmbEstado.Items.Add("Atendida");
            cmbEstado.Items.Add("Cancelada");
            cmbEstado.SelectedIndex = 0;
            cmbAMPM.SelectedIndex = ampm;
            cmbHora.SelectedIndex = valor;
            int dato = Consulta.Id_cons;
            CargarTabla(dato);
        }

        private void CargarTabla(int dato)
        {
            List<Consulta> lista = new List<Consulta>();
            Controlador ctrl = new Controlador();
            dtgSignos.DataSource = ctrl.Signosconsulta(dato);
        }

      

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmCalendario frm = new frmCalendario();
            frm.Visible = true;
            this.Visible = false;
        }
        

        private void btnSignos_Click(object sender, EventArgs e)
        {
            frmSignos frm = new frmSignos();
            frm.Visible = true;
            frm.txtsigno.Visible = false;
            frm.btnActSigno.Visible = false;
            frm.btnRegresar.Visible = false;
            frm.btnRe.Location = new Point(228, 378);
            frm.Visible = true;
            if (string.IsNullOrEmpty(Consulta.nombre_prov))
            {
                frm.lblPaciente.Text = Consulta.nompac + " " + Consulta.apellido;
            }
            else
            {
                frm.lblPaciente.Text = Consulta.nombre_prov;
            }
            this.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nomprov = null;
            if (string.IsNullOrEmpty(txtPaciente.Text))
            {
                Consulta.idpac = 1;
            }
            if (string.IsNullOrEmpty(txtNomProv.Text))
            {
            }
            else
            {
                nomprov = txtNomProv.Text;
            }
            Consulta cons = new Consulta();
            frmPrincipal frmp = new frmPrincipal();
            int indice = cmbEstado.SelectedIndex;
            cons.Idpac = Consulta.idpac;
            cons.Nombre_prov = nomprov;
            cons.Motivo = txtMotivo.Text;
            cons.Fecha_sig = dtmFecha.Text;
            cons.Estado = cmbEstado.Items[indice].ToString();
            cons.Uscrea = frmp.id_usuario;
            string a = cmbHora.Text;
            cons.Hora = cmbHora.Text;
            cons.Nompac = txtPaciente.Text;
            if (cmbAMPM.SelectedIndex == 1)
            {
                switch (cmbHora.SelectedIndex)
                {
                    case 0:
                        cons.Hora = "13:00";
                    break;
                    case 1:
                        cons.Hora = "14:00";
                        break;
                    case 2:
                        cons.Hora = "15:00";
                        break;
                    case 3:
                        cons.Hora = "16:00";
                        break;
                    case 4:
                        cons.Hora = "17:00";
                        break;
                    case 5:
                        cons.Hora = "18:00";
                        break;
                    case 6:
                        cons.Hora = "19:00";
                        break;
                    case 7:
                        cons.Hora = "20:00";
                        break;
                    case 8:
                        cons.Hora = "21:00";
                        break;
                    case 9:
                        cons.Hora = "22:00";
                        break;
                    case 10:
                        cons.Hora = "23:00";
                        break;
                    case 11:
                        cons.Hora = "24:00";
                        break;
                }
            }
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlregistroconsulta(cons);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult r = MessageBox.Show("Consulta registrada correctamente, ¿Desea añadir signos vitales a este paciente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        MySqlDataReader reader;
                        string sql;
                            sql = "SELECT ID_consulta FROM consulta WHERE fecha_sig = '" + cons.Fecha_sig + "' AND hora = '" + cons.Hora + "'";
                        try
                        {
                            MySqlConnection conexion = Conexion.GetConnection();
                            conexion.Open();
                            MySqlCommand comando = new MySqlCommand(sql, conexion);
                            reader = comando.ExecuteReader();
                            while (reader.Read())
                            {
                                Consulta.Id_cons = int.Parse(reader.GetString(0));
                            }
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine(ex.Message.ToString());
                        }
                        frmSignos frm = new frmSignos();
                        frm.Visible = true;
                        frm.txtsigno.Visible = false;
                        frm.btnActSigno.Visible = false;
                        frm.btnRe.Visible = false;
                        this.Visible = false;
                        if (string.IsNullOrEmpty(cons.Nombre_prov))
                        {
                            frm.lblPaciente.Text = Consulta.nompac + " " + Consulta.apellido;
                        }
                        else
                        {
                            frm.lblPaciente.Text = cons.Nombre_prov;
                        }

                    }
                    else
                    {
                        frmPrincipal frm2 = new frmPrincipal();
                        frm2.Visible = true;
                        this.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void frmConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Session ss = new Session();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Consulta cons = new Consulta();
            frmPrincipal frmp = new frmPrincipal();
            int indice = cmbEstado.SelectedIndex;
            cons.Idpac = Consulta.idpac;
            cons.Nombre_prov = txtNomProv.Text;
            cons.Motivo = txtMotivo.Text;
            cons.Fecha_sig = dtmFecha.Text;
            cons.Estado = cmbEstado.Items[indice].ToString();
            cons.Usmod = frmp.id_usuario;
            cons.Hora = cmbHora.Text;
            if (cmbAMPM.SelectedIndex == 1)
            {
                switch (cmbHora.SelectedIndex)
                {
                    case 0:
                        cons.Hora = "13:00";
                        break;
                    case 1:
                        cons.Hora = "14:00";
                        break;
                    case 2:
                        cons.Hora = "15:00";
                        break;
                    case 3:
                        cons.Hora = "16:00";
                        break;
                    case 4:
                        cons.Hora = "17:00";
                        break;
                    case 5:
                        cons.Hora = "18:00";
                        break;
                    case 6:
                        cons.Hora = "19:00";
                        break;
                    case 7:
                        cons.Hora = "20:00";
                        break;
                    case 8:
                        cons.Hora = "21:00";
                        break;
                    case 9:
                        cons.Hora = "22:00";
                        break;
                    case 10:
                        cons.Hora = "23:00";
                        break;
                    case 11:
                        cons.Hora = "24:00";
                        break;
                }
            }
            try
            {
                Controlador control = new Controlador();
                string respuesta = control.ctrlractualizaconsulta(cons);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Consulta editada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dtgSignos_DoubleClick(object sender, EventArgs e)
        {
            int id_sign = int.Parse(dtgSignos.CurrentRow.Cells[0].Value.ToString());
            string nombre = dtgSignos.CurrentRow.Cells[1].Value.ToString();
            string valor1 = dtgSignos.CurrentRow.Cells[2].Value.ToString();
            string valor2 = dtgSignos.CurrentRow.Cells[3].Value.ToString();
            string observacion = dtgSignos.CurrentRow.Cells[4].Value.ToString();
            frmSignos frm = new frmSignos();
            frm.Visible = true;
            frm.cmbSignos.Visible = false;
            frm.cmbSignos.Enabled = false;
            frm.txtsigno.Location = new Point(168, 31);
            frm.btnActSigno.Location = new Point(69, 378);
            frm.btnRegresar.Visible = false;
            frm.btnGuardar.Visible = false;
            frm.btnRe.Location = new Point(228, 378);
            if (string.IsNullOrEmpty(Consulta.nombre_prov))
            {
                frm.lblPaciente.Text = Consulta.nompac + " " + Consulta.apellido;
            }
            else
            {
                frm.lblPaciente.Text = Consulta.nombre_prov;
            }
            frm.txtsigno.Enabled = false;
            frm.txtsigno.Text = nombre;
            frm.txtValor1.Text = valor1;
            frm.txtValor2.Text = valor2;
            frm.txtObservacion.Text = observacion;
            frm.ID_signo = id_sign;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
           
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            frmCalendario frm = new frmCalendario();
            frm.Visible = true;
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmPacientes frm = new frmPacientes();
            frm.Visible = true;
            this.Visible = false;
        }

     
    }
}
