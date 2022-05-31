
namespace Sistema_Clinica
{
    partial class frmSignoev
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
            this.dtgSignos = new System.Windows.Forms.DataGridView();
            this.Id_signos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsignos = new System.Windows.Forms.Label();
            this.lbllinea4 = new System.Windows.Forms.Label();
            this.lbllinea3 = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.lbllinea1 = new System.Windows.Forms.Label();
            this.btnSignos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.valor1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSignos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dtgSignos.Location = new System.Drawing.Point(343, 36);
            this.dtgSignos.Name = "dtgSignos";
            this.dtgSignos.ReadOnly = true;
            this.dtgSignos.Size = new System.Drawing.Size(450, 165);
            this.dtgSignos.TabIndex = 23;
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
            // Id_consulta
            // 
            this.Id_consulta.DataPropertyName = "Id_consulta";
            this.Id_consulta.HeaderText = "Id_consulta";
            this.Id_consulta.Name = "Id_consulta";
            this.Id_consulta.ReadOnly = true;
            this.Id_consulta.Visible = false;
            // 
            // lblsignos
            // 
            this.lblsignos.AutoSize = true;
            this.lblsignos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignos.Location = new System.Drawing.Point(475, 9);
            this.lblsignos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsignos.Name = "lblsignos";
            this.lblsignos.Size = new System.Drawing.Size(160, 24);
            this.lblsignos.TabIndex = 24;
            this.lblsignos.Text = "Signos Vitales";
            // 
            // lbllinea4
            // 
            this.lbllinea4.AutoSize = true;
            this.lbllinea4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinea4.Location = new System.Drawing.Point(78, 100);
            this.lbllinea4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinea4.Name = "lbllinea4";
            this.lbllinea4.Size = new System.Drawing.Size(88, 16);
            this.lbllinea4.TabIndex = 41;
            this.lbllinea4.Text = "desea editar";
            // 
            // lbllinea3
            // 
            this.lbllinea3.AutoSize = true;
            this.lbllinea3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinea3.Location = new System.Drawing.Point(78, 84);
            this.lbllinea3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinea3.Name = "lbllinea3";
            this.lbllinea3.Size = new System.Drawing.Size(222, 16);
            this.lbllinea3.TabIndex = 40;
            this.lbllinea3.Text = "dar doble click sobre el signo que ";
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.Location = new System.Drawing.Point(30, 68);
            this.lblnota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(50, 16);
            this.lblnota.TabIndex = 38;
            this.lblnota.Text = "Nota:";
            // 
            // lbllinea1
            // 
            this.lbllinea1.AutoSize = true;
            this.lbllinea1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinea1.Location = new System.Drawing.Point(78, 68);
            this.lbllinea1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllinea1.Name = "lbllinea1";
            this.lbllinea1.Size = new System.Drawing.Size(190, 16);
            this.lbllinea1.TabIndex = 37;
            this.lbllinea1.Text = "Para editar los signos vitales";
            // 
            // btnSignos
            // 
            this.btnSignos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.btnSignos.Location = new System.Drawing.Point(825, 36);
            this.btnSignos.Name = "btnSignos";
            this.btnSignos.Size = new System.Drawing.Size(145, 38);
            this.btnSignos.TabIndex = 36;
            this.btnSignos.Text = "Agregar signo";
            this.btnSignos.UseVisualStyleBackColor = true;
            this.btnSignos.Click += new System.EventHandler(this.btnSignos_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(825, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 42;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // signosBindingSource
            // 
            this.signosBindingSource.DataSource = typeof(Sistema_Clinica.Signos);
            // 
            // frmSignoev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(982, 216);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbllinea4);
            this.Controls.Add(this.lbllinea3);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.lbllinea1);
            this.Controls.Add(this.btnSignos);
            this.Controls.Add(this.lblsignos);
            this.Controls.Add(this.dtgSignos);
            this.Name = "frmSignoev";
            this.Text = "Signos Evaluacion";
            this.Load += new System.EventHandler(this.frmSignoev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSignos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgSignos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_signos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_consulta;
        private System.Windows.Forms.BindingSource signosBindingSource;
        public System.Windows.Forms.Label lblsignos;
        public System.Windows.Forms.Label lbllinea4;
        public System.Windows.Forms.Label lbllinea3;
        public System.Windows.Forms.Label lblnota;
        public System.Windows.Forms.Label lbllinea1;
        public System.Windows.Forms.Button btnSignos;
        public System.Windows.Forms.Button button1;
    }
}