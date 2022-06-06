
namespace Sistema_Clinica
{
    partial class frmCalendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnNConsulta = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.btnElimC = new System.Windows.Forms.Button();
            this.btnEConsulta = new System.Windows.Forms.Button();
            this.btnEva = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvConsultas = new System.Windows.Forms.DataGridView();
            this.Nombre_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_sig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblmod = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navbar1 = new Sistema_Clinica.navbar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsultas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(427, 30);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 1;
            // 
            // btnNConsulta
            // 
            this.btnNConsulta.Location = new System.Drawing.Point(700, 64);
            this.btnNConsulta.Name = "btnNConsulta";
            this.btnNConsulta.Size = new System.Drawing.Size(155, 36);
            this.btnNConsulta.TabIndex = 3;
            this.btnNConsulta.Text = "Nueva Consulta";
            this.btnNConsulta.UseVisualStyleBackColor = true;
            this.btnNConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPaciente.Location = new System.Drawing.Point(697, 28);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(158, 16);
            this.lblPaciente.TabIndex = 4;
            this.lblPaciente.Text = "Nombre de paciente";
            // 
            // btnElimC
            // 
            this.btnElimC.Location = new System.Drawing.Point(700, 291);
            this.btnElimC.Name = "btnElimC";
            this.btnElimC.Size = new System.Drawing.Size(155, 36);
            this.btnElimC.TabIndex = 5;
            this.btnElimC.Text = "Eliminar Consulta";
            this.btnElimC.UseVisualStyleBackColor = true;
            this.btnElimC.Click += new System.EventHandler(this.btnElimC_Click);
            // 
            // btnEConsulta
            // 
            this.btnEConsulta.Location = new System.Drawing.Point(700, 139);
            this.btnEConsulta.Name = "btnEConsulta";
            this.btnEConsulta.Size = new System.Drawing.Size(155, 36);
            this.btnEConsulta.TabIndex = 6;
            this.btnEConsulta.Text = "Editar Consulta";
            this.btnEConsulta.UseVisualStyleBackColor = true;
            this.btnEConsulta.Click += new System.EventHandler(this.btnEConsulta_Click);
            // 
            // btnEva
            // 
            this.btnEva.Location = new System.Drawing.Point(700, 214);
            this.btnEva.Name = "btnEva";
            this.btnEva.Size = new System.Drawing.Size(155, 36);
            this.btnEva.TabIndex = 7;
            this.btnEva.Text = "Evaluacion";
            this.btnEva.UseVisualStyleBackColor = true;
            this.btnEva.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha:";
            // 
            // dtgvConsultas
            // 
            this.dtgvConsultas.AllowUserToAddRows = false;
            this.dtgvConsultas.AllowUserToDeleteRows = false;
            this.dtgvConsultas.AutoGenerateColumns = false;
            this.dtgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idpacDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nompacDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.Nombre_prov,
            this.motivoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Fecha_sig});
            this.dtgvConsultas.DataSource = this.consultaBindingSource;
            this.dtgvConsultas.Location = new System.Drawing.Point(17, 64);
            this.dtgvConsultas.Name = "dtgvConsultas";
            this.dtgvConsultas.ReadOnly = true;
            this.dtgvConsultas.Size = new System.Drawing.Size(621, 337);
            this.dtgvConsultas.TabIndex = 2;
            this.dtgvConsultas.DoubleClick += new System.EventHandler(this.dtgvConsultas_DoubleClick);
            // 
            // Nombre_prov
            // 
            this.Nombre_prov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre_prov.DataPropertyName = "Nombre_prov";
            this.Nombre_prov.HeaderText = "Nombre provisional";
            this.Nombre_prov.Name = "Nombre_prov";
            this.Nombre_prov.ReadOnly = true;
            this.Nombre_prov.Width = 112;
            // 
            // Fecha_sig
            // 
            this.Fecha_sig.DataPropertyName = "Fecha_sig";
            this.Fecha_sig.HeaderText = "Fecha_sig";
            this.Fecha_sig.Name = "Fecha_sig";
            this.Fecha_sig.ReadOnly = true;
            this.Fecha_sig.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(574, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(697, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 16);
            this.lblCodigo.TabIndex = 30;
            this.lblCodigo.Text = "Codigo";
            // 
            // dtmFecha
            // 
            this.dtmFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFecha.Location = new System.Drawing.Point(69, 29);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(81, 20);
            this.dtmFecha.TabIndex = 31;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(700, 364);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(155, 36);
            this.btnRegresar.TabIndex = 32;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nota :";
            // 
            // lblmod
            // 
            this.lblmod.AutoSize = true;
            this.lblmod.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lblmod.Location = new System.Drawing.Point(77, 416);
            this.lblmod.Name = "lblmod";
            this.lblmod.Size = new System.Drawing.Size(395, 16);
            this.lblmod.TabIndex = 33;
            this.lblmod.Text = "Para seleccionar un paciente  presione doble click sobre el";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtgvConsultas);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.lblmod);
            this.panel1.Controls.Add(this.btnNConsulta);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblPaciente);
            this.panel1.Controls.Add(this.dtmFecha);
            this.panel1.Controls.Add(this.btnElimC);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.btnEConsulta);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnEva);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 475);
            this.panel1.TabIndex = 35;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpacDataGridViewTextBoxColumn
            // 
            this.idpacDataGridViewTextBoxColumn.DataPropertyName = "Idpac";
            this.idpacDataGridViewTextBoxColumn.HeaderText = "Idpac";
            this.idpacDataGridViewTextBoxColumn.Name = "idpacDataGridViewTextBoxColumn";
            this.idpacDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpacDataGridViewTextBoxColumn.Visible = false;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Width = 55;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 65;
            // 
            // nompacDataGridViewTextBoxColumn
            // 
            this.nompacDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nompacDataGridViewTextBoxColumn.DataPropertyName = "Nompac";
            this.nompacDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nompacDataGridViewTextBoxColumn.Name = "nompacDataGridViewTextBoxColumn";
            this.nompacDataGridViewTextBoxColumn.ReadOnly = true;
            this.nompacDataGridViewTextBoxColumn.Width = 74;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 74;
            // 
            // motivoDataGridViewTextBoxColumn
            // 
            this.motivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.motivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo";
            this.motivoDataGridViewTextBoxColumn.HeaderText = "Motivo";
            this.motivoDataGridViewTextBoxColumn.Name = "motivoDataGridViewTextBoxColumn";
            this.motivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.motivoDataGridViewTextBoxColumn.Width = 64;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 65;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataSource = typeof(Sistema_Clinica.Consulta);
            // 
            // navbar1
            // 
            this.navbar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navbar1.Location = new System.Drawing.Point(-2, -7);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(1350, 146);
            this.navbar1.TabIndex = 36;
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1346, 628);
            this.Controls.Add(this.navbar1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCalendario";
            this.Text = "Calendario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsultas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnNConsulta;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvConsultas;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.Button btnEConsulta;
        public System.Windows.Forms.Button btnElimC;
        public System.Windows.Forms.Button btnEva;
        public System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_sig;
        public System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblmod;
        private System.Windows.Forms.Panel panel1;
        private navbar navbar1;
    }
}