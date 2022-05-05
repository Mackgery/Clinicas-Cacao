
namespace Sistema_Clinica
{
    partial class frmCatalogoSig
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSignos = new System.Windows.Forms.Label();
            this.cmbSignos = new System.Windows.Forms.ComboBox();
            this.cmbSignos2 = new System.Windows.Forms.ComboBox();
            this.lbltexto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Habilitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Deshabilitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSignos
            // 
            this.lblSignos.AutoSize = true;
            this.lblSignos.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignos.Location = new System.Drawing.Point(63, 28);
            this.lblSignos.Name = "lblSignos";
            this.lblSignos.Size = new System.Drawing.Size(140, 20);
            this.lblSignos.TabIndex = 3;
            this.lblSignos.Text = "Signos Vitales";
            // 
            // cmbSignos
            // 
            this.cmbSignos.FormattingEnabled = true;
            this.cmbSignos.Location = new System.Drawing.Point(68, 93);
            this.cmbSignos.Name = "cmbSignos";
            this.cmbSignos.Size = new System.Drawing.Size(121, 21);
            this.cmbSignos.TabIndex = 5;
            // 
            // cmbSignos2
            // 
            this.cmbSignos2.FormattingEnabled = true;
            this.cmbSignos2.Location = new System.Drawing.Point(67, 93);
            this.cmbSignos2.Name = "cmbSignos2";
            this.cmbSignos2.Size = new System.Drawing.Size(121, 21);
            this.cmbSignos2.TabIndex = 8;
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexto.Location = new System.Drawing.Point(76, 48);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(0, 20);
            this.lbltexto.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(13, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCatalogoSig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(256, 210);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.cmbSignos2);
            this.Controls.Add(this.cmbSignos);
            this.Controls.Add(this.lblSignos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmCatalogoSig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCatalogoSig";
            this.Load += new System.EventHandler(this.frmCatalogoSig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSignos;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lbltexto;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cmbSignos;
        public System.Windows.Forms.ComboBox cmbSignos2;
    }
}