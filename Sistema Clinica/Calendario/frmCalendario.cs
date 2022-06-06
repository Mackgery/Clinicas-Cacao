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
    public partial class frmCalendario : Form
    {
        public int hora1, ampm, id, vista = 0, dato;
        public frmCalendario()
        {
            InitializeComponent();
        }

        private void frmCalendario_Load(object sender, EventArgs e)
        {
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.Add("Activa");
            cmbEstado.Items.Add("Atendida");
            cmbEstado.Items.Add("Cancelada");
            cmbEstado.SelectedIndex = 0;
            btnEConsulta.Enabled = false;
            btnElimC.Enabled = false;
            btnEva.Enabled = false;
            int indice = cmbEstado.SelectedIndex;
            string dato = dtmFecha.Text;
            string dato2 = cmbEstado.Items[indice].ToString();
            CargarTabla(dato, dato2);
        }

        private void CargarTabla(string dato, string dato2)
        {
            List<Consprueba> lista = new List<Consprueba>();
            Controlador ctrl = new Controlador();
            dtgvConsultas.DataSource = ctrl.consultas(dato, dato2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsulta frm = new frmConsulta();
            frm.Visible = true;
            this.Visible = false;
            frm.btnSignos.Visible = false;
            frm.lblsignos.Visible = false;
            frm.lblnota.Visible = false;
            frm.lbllinea1.Visible = false;
            frm.lbllinea3.Visible = false;
            frm.lbllinea4.Visible = false;
            frm.btnEditar.Visible = false;
            frm.dtgSignos.Visible = false;
            frm.lblCodigo.Visible = false;
            frm.lblCodi.Visible = false;
            frm.txtPaciente.Visible = false;
            frm.txtNomProv.Location = new Point(287, 75);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indice = cmbEstado.SelectedIndex;
            string dato = dtmFecha.Text;
            string dato2 = cmbEstado.Items[indice].ToString();
            CargarTabla(dato, dato2);
        }

    

        private void btnElimC_Click(object sender, EventArgs e)
        {
            Consulta cons = new Consulta();
            cons.Id = int.Parse(dtgvConsultas.CurrentRow.Cells[0].Value.ToString());
            try
            {
                Controlador control = new Controlador();
                
                    DialogResult r = MessageBox.Show("¿Seguro que desea eliminar esta Consulta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        control.ctrleliminaconsulta(cons);
                        MessageBox.Show("Consulta eliminada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                    int indice1 = cmbEstado.SelectedIndex;
                    string dato1 = dtmFecha.Text;
                    string dato3 = cmbEstado.Items[indice1].ToString();
                    CargarTabla(dato1, dato3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: ", ex.Message);
            }
            int indice = cmbEstado.SelectedIndex;
            string dato = dtmFecha.Text;
            string dato2 = cmbEstado.Items[indice].ToString();
            CargarTabla(dato, dato2);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(dtgvConsultas.CurrentRow.Cells[0].Value.ToString());
            frmEvaluacion frm1 = new frmEvaluacion();
            frm1.id_cons = dato;
            modelo modelo = new modelo();
            if (modelo.existeEvaluacion(dato))
            {
                DialogResult r = MessageBox.Show("Esta consulta ya cuenta con evaluacion" + "\r\n" + "¿Desea cargar los datos de la evaluacion y editarlos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    vista = 1;
                    cargadatos();
                    frmEvaluacion frm = new frmEvaluacion();
                    MySqlDataReader reader2;
                    string sql2;
                    sql2 = "SELECT p.`nombres`, p.`apellidos`, c.`nombre_provisional`, p.`fecha_nacimiento`, p.`alergias`, p.`tipo_sangre`, c.`motivo`, e.`evaluacion`, e.`laboratorios`, e.`receta`, p.`codigo` FROM evaluacion e INNER JOIN consulta c ON c.`ID_consulta` = e.`ID_consulta` INNER JOIN paciente p ON c.`ID_paciente` = p.`ID_paciente` WHERE e.ID_consulta = '" + dato +"'";
                    
                        MySqlConnection conexion = Conexion.GetConnection();
                        conexion.Open();
                        MySqlCommand comando = new MySqlCommand(sql2, conexion);
                        reader2 = comando.ExecuteReader();
                        while (reader2.Read())
                        {
                            string nombre = reader2[0].ToString();
                            string apellidos = reader2[1].ToString();
                            string nombreprov = reader2[2].ToString();
                            string fechanac = reader2[3].ToString();
                            string alergias = reader2[4].ToString();
                            string tiposan = reader2[5].ToString();
                            string motivo = reader2[6].ToString();
                            frm.txtEvaluacion.Text = reader2[7].ToString();
                            frm.txtLaboratorios.Text = reader2[8].ToString();
                            frm.txtReceta.Text = reader2[9].ToString();
                            string codigo = reader2[10].ToString();
                            if (string.IsNullOrEmpty(nombre))
                            {
                                frm.textBox1.Text = "Nombre provisional: " + nombreprov + "\r\n" + "Motivo: " + motivo;
                                frm.id_cons = dato;
                            }
                            else
                            {
                                frm.textBox1.Text = "Codigo: " + codigo + "\r\n" + "Nombre: " + nombre + " " + apellidos + "\r\n" + "Fecha de Nacimiento: " + fechanac + "\r\n" + "Alergias: " + alergias + "\r\n" + "Tipo de sangre " + tiposan + "\r\n" + "Motivo: " + motivo;
                                frm.id_cons = dato;
                            }
                        }
                        frm.textBox1.Enabled = false;
                        frm.btnEditar.Visible = true;
                        frm.btnImpL.Visible = true;
                        frm.btnImpR.Visible = true;
                        frm.btnEditar.Location = new Point(189, 438);
                        frm.btnImpL.Location = new Point(267, 481);
                        frm.btnImpR.Location = new Point(105, 481);
                        frm.btnGuardar.Location = new Point(20, 438);
                        frm.btnRegresar.Location = new Point(356, 438);
                        frm.btnGuardar.Visible = false;
                        frm.txtEvaluacion.Enabled = false;
                        frm.txtLaboratorios.Enabled = false;
                        frm.txtReceta.Enabled = false;
                        frm.btnhab.Visible = true;
                        frm.btnhab.Location = new Point(20, 438);
                        frm.Visible = true;
                        this.Visible = false;
                        frm.valor = 1;
                    }
                else
                {
                  
                }
            }
            else
            {
                cargadatos();
            }
           
        }

        private void cargadatos()
        {
            dato = int.Parse(dtgvConsultas.CurrentRow.Cells[0].Value.ToString());
            MySqlDataReader reader = null;
            string sql;
            sql = "SELECT p.`nombres`, p.`apellidos`, c.`nombre_provisional`, p.`fecha_nacimiento`, p.`alergias`, p.`tipo_sangre`, c.`motivo`, p.`codigo` " +
                "FROM consulta c INNER JOIN paciente p ON  c.`ID_paciente` = p.`ID_paciente` WHERE ID_consulta ='" + dato + "'";
            try
            {
                MySqlConnection conexion = Conexion.GetConnection();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Evaluacion.nombre = reader[0].ToString();
                    Evaluacion.apellidos = reader[1].ToString();
                    Evaluacion.nombreprov = reader[2].ToString();
                    Evaluacion.fechanac = reader[3].ToString();
                    Evaluacion.alergias = reader[4].ToString();
                    Evaluacion.tiposan = reader[5].ToString();
                    Evaluacion.motivo = reader[6].ToString();
                    if (reader[7] != DBNull.Value)
                    {
                        Evaluacion.codigo = int.Parse(reader[7].ToString());
                    }
                }
                frmEvaluacion frm = new frmEvaluacion();
                frm.textBox1.Enabled = false;
                
                if(vista == 0) { 
                frm.Visible = true;
                this.Visible = false;
                frm.btnEditar.Visible = false;
                frm.btnImpL.Visible = false;
                frm.btnImpR.Visible = false;
                frm.btnGuardar.Location = new Point(117, 438);
                frm.btnRegresar.Location = new Point(334, 438);
                frm.btnhab.Visible = false;
                }
                else
                {
                    frm.btnEditar.Visible = true;
                    frm.btnImpL.Visible = true;
                    frm.btnImpR.Visible = true;
                    frm.btnEditar.Location = new Point(189, 438);
                    frm.btnImpL.Location = new Point(267, 481);
                    frm.btnImpR.Location = new Point(105, 481);
                    frm.btnGuardar.Location = new Point(20, 438);
                    frm.btnRegresar.Location = new Point(356, 438);
                    frm.btnGuardar.Visible = false;
                    frm.txtEvaluacion.Enabled = false;
                    frm.txtLaboratorios.Enabled = false;
                    frm.txtReceta.Enabled = false;
                    frm.btnhab.Visible = true;
                    frm.btnhab.Location = new Point(20, 438);

                }
                if (string.IsNullOrEmpty(Evaluacion.nombre))
                {
                    frm.textBox1.Text = "Nombre provisional: " + Evaluacion.nombreprov + "\r\n" + "Motivo: " + Evaluacion.motivo;
                    frm.id_cons = dato;
                    Consulta.id_cons = dato;
                }
                else
                {
                    frm.textBox1.Text = "Codigo: " + Evaluacion.codigo + "\r\n" + "Nombre: " + Evaluacion.nombre + " " + Evaluacion.apellidos + "\r\n" + "Fecha de Nacimiento: " + Evaluacion.fechanac + "\r\n" + "Alergias: " + Evaluacion.alergias + "\r\n" + "Motivo: " + Evaluacion.motivo;
                    frm.id_cons = dato;
                    Consulta.id_cons = dato;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void dtgvConsultas_DoubleClick(object sender, EventArgs e)
        {
            Consulta.id_cons = int.Parse(dtgvConsultas.CurrentRow.Cells[0].Value.ToString()); 
            string nombre = dtgvConsultas.CurrentRow.Cells[4].Value.ToString();
            string apellido = dtgvConsultas.CurrentRow.Cells[5].Value.ToString();
            string nomprov = dtgvConsultas.CurrentRow.Cells[6].Value.ToString();
            string codigo = dtgvConsultas.CurrentRow.Cells[3].Value.ToString();
            string motivo = dtgvConsultas.CurrentRow.Cells[7].Value.ToString();
            string fecha_sig = dtgvConsultas.CurrentRow.Cells[9].Value.ToString();
            frmConsulta frm = new frmConsulta();
            if (codigo == "0")
            {
                codigo = "Sin codigo";
            }
            string completo = "Paciente: " + nombre + " " + apellido;
            string cod = "Codigo : " + codigo;
            if (string.IsNullOrEmpty(apellido))
            {
                lblCodigo.Text = cod;
                lblPaciente.Text = "Paciente: " + nomprov;

            }else
            {
                lblCodigo.Text = cod;
                lblPaciente.Text = completo;
            }
            btnEConsulta.Enabled = true;
            btnElimC.Enabled = true;
            btnEva.Enabled = true;
        }

        private void btnEConsulta_Click(object sender, EventArgs e)
        {
            id =int.Parse(dtgvConsultas.CurrentRow.Cells[0].Value.ToString());
            string nombre = dtgvConsultas.CurrentRow.Cells[4].Value.ToString();
            string apellido = dtgvConsultas.CurrentRow.Cells[5].Value.ToString();
            string nomprov = dtgvConsultas.CurrentRow.Cells[6].Value.ToString();
            string codigo = dtgvConsultas.CurrentRow.Cells[3].Value.ToString();
            string motivo = dtgvConsultas.CurrentRow.Cells[7].Value.ToString();
            string hora = dtgvConsultas.CurrentRow.Cells[2].Value.ToString();
            DateTime fecha_sig = DateTime.Parse(dtgvConsultas.CurrentRow.Cells[9].Value.ToString());
            string completo = nombre + " " + apellido;
            frmConsulta frm = new frmConsulta();
            switch (hora)
            {
                case "1:00:00":
                    hora1 = 0;
                    break;
                case "2:00:00":
                    hora1 = 1;
                    break;
                case "3:00:00":
                    hora1 = 2;
                    break;
                case "4:00:00":
                    hora1 = 3;
                    break;
                case "5:00:00":
                    hora1 = 4;
                    break;
                case "6:00:00":
                    hora1 = 5;
                    break;
                case "7:00:00":
                    hora1 = 6;
                    break;
                case "8:00:00":
                    hora1 = 7;
                    break;
                case "9:00:00":
                    hora1 = 8;
                    break;
                case "10:00:00":
                    hora1 = 9;
                    break;
                case "11:00:00":
                    hora1 = 10;
                    break;
                case "12:00:00":
                    hora1 = 11;
                    break;
                case "13:00:00":
                    hora1 = 0;
                    ampm = 1;
                    break;
                case "14:00:00":
                    hora1 = 1;
                    ampm = 1;
                    break;
                case "15:00:00":
                    hora1 = 2;
                    ampm = 1;
                    break;
                case "16:00:00":
                    hora1 = 3;
                    ampm = 1;
                    break;
                case "17:00:00":
                    hora1 = 4;
                    ampm = 1;
                    break;
                case "18:00:00":
                    hora1 = 5;
                    ampm = 1;
                    break;
            }

            if (string.IsNullOrEmpty(apellido))
            {
                frm.txtNomProv.Text = nomprov;
                frm.txtMotivo.Text = motivo;
                frm.lblCodigo.Text = codigo;
                frm.dtmFecha.Value = fecha_sig;
                frm.txtPaciente.Text = nomprov;
                frm.lblCodigo.Enabled = false;
                frm.lblCodigo.BackColor = Color.PaleVioletRed;
                frm.valor = hora1;
                frm.ampm = ampm;
                frm.btnSignos.Visible = false;
                frm.lblsignos.Visible = false;
                //frm.txtNomProv.Enabled = false;
                frm.pictureBox1.Visible = false;
                frm.lblsignos.Visible = true;
                frm.btnSignos.Visible = true;
                frm.Visible = true;
                this.Visible = false;
                frm.btnGuardar.Visible = false;
                frm.btnEditar.Visible = true;
               // frm.btnEditar.Location = new Point(316, 705);
                frm.txtPaciente.Visible = false;
                frm.txtNomProv.Location = new Point(287, 75);
                Consulta.id_cons = int.Parse(dtgvConsultas.CurrentRow.Cells[0].Value.ToString());

            }
            else
            {
                frm.txtPaciente.Text = completo;
                frm.txtMotivo.Text = motivo;
                frm.lblCodigo.Text = codigo;
                frm.dtmFecha.Value = fecha_sig;
                frm.txtPaciente.Enabled = false;
                frm.lblCodigo.Enabled = false;
                frm.valor = hora1;
                frm.ampm = ampm;
                frm.btnSignos.Visible = false;
                frm.lblsignos.Visible = false;
                frm.txtNomProv.Visible = false;
                frm.pictureBox1.Visible = false;
                frm.lblsignos.Visible = true;
                frm.btnSignos.Visible = true;
                frm.Visible = true;
                this.Visible = false;
                frm.btnGuardar.Visible = false;
                frm.btnEditar.Visible = true;
                //frm.btnEditar.Location = new Point(316, 705);
                Consulta.id_cons = int.Parse(dtgvConsultas.CurrentRow.Cells[0].Value.ToString());
            }
            Consulta.id = int.Parse(dtgvConsultas.CurrentRow.Cells[0].Value.ToString());
            Consulta.id_cons = int.Parse(dtgvConsultas.CurrentRow.Cells[0].Value.ToString());
            Consulta.idpac = int.Parse(dtgvConsultas.CurrentRow.Cells[1].Value.ToString());
            Consulta.nombre_prov = dtgvConsultas.CurrentRow.Cells[6].Value.ToString();
            Consulta.nompac = dtgvConsultas.CurrentRow.Cells[4].Value.ToString();
            Consulta.apellido = dtgvConsultas.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
