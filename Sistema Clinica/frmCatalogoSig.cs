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
        public frmCatalogoSig()
        {
            InitializeComponent();
        }

        private void frmCatalogoSig_Load(object sender, EventArgs e)
        {
            getlist();

        }

        private void getlist()
        {
            try
            {
                cmbSignos.DataSource = null;
                cmbSignos.Items.Clear();
                cmbSignos2.DataSource = null;
                cmbSignos2.Items.Clear();
                string sql = "SELECT id_sign, nombre FROM catalogo_signos WHERE estado = 1 ORDER BY nombre ASC";
                string sql2 = "SELECT id_sign, nombre FROM catalogo_signos WHERE estado = 0 ORDER BY nombre ASC";
                MySqlConnection conexion = Conexion.GetConnection();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    MySqlDataAdapter data = new MySqlDataAdapter(comando);
                    MySqlCommand comando2 = new MySqlCommand(sql2, conexion);
                    MySqlDataAdapter data2 = new MySqlDataAdapter(comando2);
                    DataTable dt2 = new DataTable();
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    data2.Fill(dt2);

                    cmbSignos.ValueMember = "id_sign";
                    cmbSignos.DisplayMember = "nombre";
                    cmbSignos.DataSource = dt;
                    cmbSignos2.ValueMember = "id_sign";
                    cmbSignos2.DisplayMember = "nombre";
                    cmbSignos2.DataSource = dt2;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar" + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }


                /*                conexion.Open();
                                MySqlCommand comando = new MySqlCommand();
                                comando.Connection = conexion;
                                comando.CommandText = ("SELECT nombre FROM catalogo_signos");
                                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                                adaptar.SelectCommand = comando;
                                DataTable tabla = new DataTable();
                                adaptar.Fill(tabla);
                                dtgvSignos.DataSource = tabla;
                            */
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

      

        public void button1_Click(object sender, EventArgs e)
        {
            int id_sign = int.Parse(cmbSignos2.SelectedValue.ToString());
            string sql = "UPDATE catalogo_signos SET estado = 1 WHERE id_sign = '" + id_sign + "'";
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Actualizado correctamente");
            }catch(Exception ex)
            {
                MessageBox.Show("Aviso" + ex);
            }
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Visible = true;
            this.Visible = false;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int id_sign = int.Parse(cmbSignos.SelectedValue.ToString());
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

        }
    }
    }


