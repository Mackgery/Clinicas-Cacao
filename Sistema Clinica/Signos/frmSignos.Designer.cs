
namespace Sistema_Clinica
{
    partial class frmSignos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSignos = new System.Windows.Forms.ComboBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnActSigno = new System.Windows.Forms.Button();
            this.txtsigno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsigno);
            this.groupBox1.Controls.Add(this.cmbSignos);
            this.groupBox1.Controls.Add(this.txtValor2);
            this.groupBox1.Controls.Add(this.txtValor1);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signos Vitales";
            // 
            // cmbSignos
            // 
            this.cmbSignos.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.cmbSignos.FormattingEnabled = true;
            this.cmbSignos.Location = new System.Drawing.Point(168, 31);
            this.cmbSignos.Name = "cmbSignos";
            this.cmbSignos.Size = new System.Drawing.Size(131, 23);
            this.cmbSignos.TabIndex = 1;
            this.cmbSignos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSignos_KeyDown);
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(168, 161);
            this.txtValor2.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(131, 23);
            this.txtValor2.TabIndex = 3;
            this.txtValor2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor2_KeyDown);
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(168, 93);
            this.txtValor1.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(131, 23);
            this.txtValor1.TabIndex = 2;
            this.txtValor1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor1_KeyDown);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(168, 226);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(131, 44);
            this.txtObservacion.TabIndex = 4;
            this.txtObservacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObservacion_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Signo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Observacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor 2";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(69, 378);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Añadir";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(228, 378);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 28);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Cancelar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lblPaciente.Location = new System.Drawing.Point(149, 32);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(0, 16);
            this.lblPaciente.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Paciente: ";
            // 
            // btnRe
            // 
            this.btnRe.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRe.Location = new System.Drawing.Point(228, 342);
            this.btnRe.Margin = new System.Windows.Forms.Padding(4);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(100, 28);
            this.btnRe.TabIndex = 20;
            this.btnRe.Text = "Regresar";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnActSigno
            // 
            this.btnActSigno.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActSigno.Location = new System.Drawing.Point(69, 342);
            this.btnActSigno.Margin = new System.Windows.Forms.Padding(4);
            this.btnActSigno.Name = "btnActSigno";
            this.btnActSigno.Size = new System.Drawing.Size(100, 28);
            this.btnActSigno.TabIndex = 21;
            this.btnActSigno.Text = "Actualizar";
            this.btnActSigno.UseVisualStyleBackColor = true;
            this.btnActSigno.Click += new System.EventHandler(this.btnActSigno_Click);
            // 
            // txtsigno
            // 
            this.txtsigno.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsigno.Location = new System.Drawing.Point(168, 62);
            this.txtsigno.Margin = new System.Windows.Forms.Padding(4);
            this.txtsigno.Name = "txtsigno";
            this.txtsigno.Size = new System.Drawing.Size(131, 23);
            this.txtsigno.TabIndex = 8;
            // 
            // frmSignos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(409, 423);
            this.Controls.Add(this.btnActSigno);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmSignos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signos Vitales";
            this.Load += new System.EventHandler(this.frmSignos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnRe;
        public System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.Button btnActSigno;
        public System.Windows.Forms.TextBox txtsigno;
        public System.Windows.Forms.TextBox txtValor2;
        public System.Windows.Forms.TextBox txtValor1;
        public System.Windows.Forms.TextBox txtObservacion;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.ComboBox cmbSignos;
    }
}