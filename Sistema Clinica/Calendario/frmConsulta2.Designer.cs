
namespace Sistema_Clinica
{
    partial class frmConsulta2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta2));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.lblsignos = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnSignos = new System.Windows.Forms.Button();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbAMPM = new System.Windows.Forms.ComboBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbllinea4 = new System.Windows.Forms.Label();
            this.lbllinea3 = new System.Windows.Forms.Label();
            this.lbllinea2 = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.lbllinea1 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.dtgSignos = new System.Windows.Forms.DataGridView();
            this.Id_signos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCodi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomProv = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSignos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(458, 507);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(113, 39);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "Cancelar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(68, 507);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 39);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(216, 507);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 39);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado de la cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Motivo";
            // 
            // dtmFecha
            // 
            this.dtmFecha.CustomFormat = "";
            this.dtmFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFecha.Location = new System.Drawing.Point(177, 202);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(138, 21);
            this.dtmFecha.TabIndex = 10;
            // 
            // lblsignos
            // 
            this.lblsignos.AutoSize = true;
            this.lblsignos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignos.Location = new System.Drawing.Point(342, 136);
            this.lblsignos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsignos.Name = "lblsignos";
            this.lblsignos.Size = new System.Drawing.Size(100, 16);
            this.lblsignos.TabIndex = 11;
            this.lblsignos.Text = "Signos Vitales";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(177, 133);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(138, 48);
            this.txtMotivo.TabIndex = 20;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(177, 264);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(138, 24);
            this.cmbEstado.TabIndex = 21;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // btnSignos
            // 
            this.btnSignos.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignos.Location = new System.Drawing.Point(481, 133);
            this.btnSignos.Name = "btnSignos";
            this.btnSignos.Size = new System.Drawing.Size(50, 33);
            this.btnSignos.TabIndex = 23;
            this.btnSignos.Text = "+";
            this.btnSignos.UseVisualStyleBackColor = true;
            this.btnSignos.Click += new System.EventHandler(this.btnSignos_Click);
            // 
            // cmbHora
            // 
            this.cmbHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(459, 201);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(72, 24);
            this.cmbHora.TabIndex = 25;
            // 
            // cmbAMPM
            // 
            this.cmbAMPM.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.cmbAMPM.FormattingEnabled = true;
            this.cmbAMPM.Location = new System.Drawing.Point(552, 202);
            this.cmbAMPM.Name = "cmbAMPM";
            this.cmbAMPM.Size = new System.Drawing.Size(55, 24);
            this.cmbAMPM.TabIndex = 26;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(177, 74);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(138, 23);
            this.txtPaciente.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbllinea4);
            this.groupBox1.Controls.Add(this.lbllinea3);
            this.groupBox1.Controls.Add(this.lbllinea2);
            this.groupBox1.Controls.Add(this.lblnota);
            this.groupBox1.Controls.Add(this.lbllinea1);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Controls.Add(this.dtgSignos);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblCodi);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtPaciente);
            this.groupBox1.Controls.Add(this.cmbAMPM);
            this.groupBox1.Controls.Add(this.cmbHora);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSignos);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Controls.Add(this.lblsignos);
            this.groupBox1.Controls.Add(this.dtmFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNomProv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(40, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la consulta";
            // 
            // lbllinea4
            // 
            this.lbllinea4.AutoSize = true;
            this.lbllinea4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinea4.Location = new System.Drawing.Point(71, 386);
            this.lbllinea4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinea4.Name = "lbllinea4";
            this.lbllinea4.Size = new System.Drawing.Size(88, 16);
            this.lbllinea4.TabIndex = 35;
            this.lbllinea4.Text = "desea editar";
            // 
            // lbllinea3
            // 
            this.lbllinea3.AutoSize = true;
            this.lbllinea3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinea3.Location = new System.Drawing.Point(71, 370);
            this.lbllinea3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinea3.Name = "lbllinea3";
            this.lbllinea3.Size = new System.Drawing.Size(222, 16);
            this.lbllinea3.TabIndex = 34;
            this.lbllinea3.Text = "dar doble click sobre el signo que ";
            // 
            // lbllinea2
            // 
            this.lbllinea2.AutoSize = true;
            this.lbllinea2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinea2.Location = new System.Drawing.Point(71, 354);
            this.lbllinea2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinea2.Name = "lbllinea2";
            this.lbllinea2.Size = new System.Drawing.Size(233, 16);
            this.lbllinea2.TabIndex = 33;
            this.lbllinea2.Text = "\"Ver signos\" y para editarlos puede";
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.Location = new System.Drawing.Point(24, 338);
            this.lblnota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(50, 16);
            this.lblnota.TabIndex = 32;
            this.lblnota.Text = "Nota:";
            // 
            // lbllinea1
            // 
            this.lbllinea1.AutoSize = true;
            this.lbllinea1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinea1.Location = new System.Drawing.Point(71, 338);
            this.lbllinea1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinea1.Name = "lbllinea1";
            this.lbllinea1.Size = new System.Drawing.Size(240, 16);
            this.lbllinea1.TabIndex = 31;
            this.lbllinea1.Text = "Para ver los signos vitales presione  ";
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(345, 421);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(100, 28);
            this.btnVer.TabIndex = 22;
            this.btnVer.Text = "Ver signos";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // dtgSignos
            // 
            this.dtgSignos.AllowUserToAddRows = false;
            this.dtgSignos.AllowUserToDeleteRows = false;
            this.dtgSignos.AutoGenerateColumns = false;
            this.dtgSignos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSignos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_signos,
            this.Nombre,
            this.valor1DataGridViewTextBoxColumn,
            this.valor2DataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.Id_consulta});
            this.dtgSignos.DataSource = this.signosBindingSource;
            this.dtgSignos.Location = new System.Drawing.Point(345, 264);
            this.dtgSignos.Name = "dtgSignos";
            this.dtgSignos.ReadOnly = true;
            this.dtgSignos.Size = new System.Drawing.Size(370, 150);
            this.dtgSignos.TabIndex = 22;
            this.dtgSignos.DoubleClick += new System.EventHandler(this.dtgSignos_DoubleClick);
            // 
            // Id_signos
            // 
            this.Id_signos.DataPropertyName = "Id_signos";
            this.Id_signos.HeaderText = "Id_signos";
            this.Id_signos.Name = "Id_signos";
            this.Id_signos.ReadOnly = true;
            this.Id_signos.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // valor1DataGridViewTextBoxColumn
            // 
            this.valor1DataGridViewTextBoxColumn.DataPropertyName = "Valor1";
            this.valor1DataGridViewTextBoxColumn.HeaderText = "Valor1";
            this.valor1DataGridViewTextBoxColumn.Name = "valor1DataGridViewTextBoxColumn";
            this.valor1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valor2DataGridViewTextBoxColumn
            // 
            this.valor2DataGridViewTextBoxColumn.DataPropertyName = "Valor2";
            this.valor2DataGridViewTextBoxColumn.HeaderText = "Valor2";
            this.valor2DataGridViewTextBoxColumn.Name = "valor2DataGridViewTextBoxColumn";
            this.valor2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Id_consulta
            // 
            this.Id_consulta.DataPropertyName = "Id_consulta";
            this.Id_consulta.HeaderText = "Id_consulta";
            this.Id_consulta.Name = "Id_consulta";
            this.Id_consulta.ReadOnly = true;
            this.Id_consulta.Visible = false;
            // 
            // signosBindingSource
            // 
            this.signosBindingSource.DataSource = typeof(Sistema_Clinica.Signos);
            // 
            // lblCodi
            // 
            this.lblCodi.AutoSize = true;
            this.lblCodi.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lblCodi.Location = new System.Drawing.Point(25, 31);
            this.lblCodi.Name = "lblCodi";
            this.lblCodi.Size = new System.Drawing.Size(52, 16);
            this.lblCodi.TabIndex = 22;
            this.lblCodi.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de la cita";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hora de la cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Provisional";
            // 
            // txtNomProv
            // 
            this.txtNomProv.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProv.Location = new System.Drawing.Point(481, 74);
            this.txtNomProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomProv.Name = "txtNomProv";
            this.txtNomProv.Size = new System.Drawing.Size(138, 23);
            this.txtNomProv.TabIndex = 8;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lblCodigo.Location = new System.Drawing.Point(173, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 16);
            this.lblCodigo.TabIndex = 30;
            // 
            // frmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(771, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmConsulta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsulta_FormClosed);
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSignos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.Button btnSignos;
        public System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblsignos;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DateTimePicker dtmFecha;
        public System.Windows.Forms.TextBox txtMotivo;
        public System.Windows.Forms.Label lblCodi;
        public System.Windows.Forms.ComboBox cmbHora;
        public System.Windows.Forms.ComboBox cmbAMPM;
        private System.Windows.Forms.BindingSource signosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_signos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_consulta;
        public System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.DataGridView dtgSignos;
        public System.Windows.Forms.Button btnVer;
        public System.Windows.Forms.Label lblnota;
        public System.Windows.Forms.Label lbllinea4;
        public System.Windows.Forms.Label lbllinea3;
        public System.Windows.Forms.Label lbllinea2;
        public System.Windows.Forms.Label lbllinea1;
        public System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNomProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}