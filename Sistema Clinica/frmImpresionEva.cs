using Microsoft.Reporting.WinForms;
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
    public partial class frmImpresionEva : Form
    {
        public frmImpresionEva()
        {
            InitializeComponent();
        }

        private void frmImpresionEva_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.GetConnection();
            conexion.Open();
            DataTable dt = new DataTable();
            string sql;
            sql = "SELECT e.`evaluacion`, e.`laboratorios`, e.`receta`, CONCAT (p.`nombres`, ' ', p.`apellidos`) AS completo FROM evaluacion e INNER JOIN consulta c ON c.`ID_consulta` = e.`ID_consulta` INNER JOIN paciente p ON c.`ID_paciente` = p.`ID_paciente` WHERE e.`ID_consulta` = '" + Consulta.id_cons + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion);
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();

            this.Visible = false;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }

}
