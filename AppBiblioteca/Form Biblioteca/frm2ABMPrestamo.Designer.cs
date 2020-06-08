namespace Form_Biblioteca
{
    partial class frm2ABMPrestamo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodigoCl = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigoEj = new System.Windows.Forms.Label();
            this.lblDatosEjemplar = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtCodigoEjemplar = new System.Windows.Forms.TextBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.lblPlazoRestante = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarEjemplar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nombre";
            // 
            // lblCodigoCl
            // 
            this.lblCodigoCl.AutoSize = true;
            this.lblCodigoCl.Location = new System.Drawing.Point(29, 49);
            this.lblCodigoCl.Name = "lblCodigoCl";
            this.lblCodigoCl.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoCl.TabIndex = 34;
            this.lblCodigoCl.Text = "Código";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Location = new System.Drawing.Point(29, 16);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(70, 13);
            this.lblDatosCliente.TabIndex = 33;
            this.lblDatosCliente.Text = "Datos Cliente";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(39, 224);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(167, 20);
            this.txtApellidoCliente.TabIndex = 31;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(39, 153);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(167, 20);
            this.txtNombreCliente.TabIndex = 30;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(39, 75);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(167, 20);
            this.txtCodigoCliente.TabIndex = 29;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(302, 197);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 48;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(302, 125);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 47;
            this.lblTitulo.Text = "Título";
            // 
            // lblCodigoEj
            // 
            this.lblCodigoEj.AutoSize = true;
            this.lblCodigoEj.Location = new System.Drawing.Point(302, 49);
            this.lblCodigoEj.Name = "lblCodigoEj";
            this.lblCodigoEj.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEj.TabIndex = 46;
            this.lblCodigoEj.Text = "Código";
            // 
            // lblDatosEjemplar
            // 
            this.lblDatosEjemplar.AutoSize = true;
            this.lblDatosEjemplar.Location = new System.Drawing.Point(302, 16);
            this.lblDatosEjemplar.Name = "lblDatosEjemplar";
            this.lblDatosEjemplar.Size = new System.Drawing.Size(77, 13);
            this.lblDatosEjemplar.TabIndex = 45;
            this.lblDatosEjemplar.Text = "Datos ejemplar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(312, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 43;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(312, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 42;
            // 
            // txtCodigoEjemplar
            // 
            this.txtCodigoEjemplar.Location = new System.Drawing.Point(312, 75);
            this.txtCodigoEjemplar.Name = "txtCodigoEjemplar";
            this.txtCodigoEjemplar.ReadOnly = true;
            this.txtCodigoEjemplar.Size = new System.Drawing.Size(167, 20);
            this.txtCodigoEjemplar.TabIndex = 41;
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(556, 16);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(477, 368);
            this.lstPrestamos.TabIndex = 52;
            // 
            // lblPlazoRestante
            // 
            this.lblPlazoRestante.AutoSize = true;
            this.lblPlazoRestante.Location = new System.Drawing.Point(302, 307);
            this.lblPlazoRestante.Name = "lblPlazoRestante";
            this.lblPlazoRestante.Size = new System.Drawing.Size(79, 13);
            this.lblPlazoRestante.TabIndex = 58;
            this.lblPlazoRestante.Text = "Plazo Restante";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(29, 309);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(58, 13);
            this.lblFechaAlta.TabIndex = 57;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(29, 276);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(87, 13);
            this.lblPrestamo.TabIndex = 56;
            this.lblPrestamo.Text = "Datos Préstamos";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(312, 335);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(167, 20);
            this.textBox7.TabIndex = 54;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(212, 75);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(53, 20);
            this.btnBuscarCliente.TabIndex = 59;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarEjemplar
            // 
            this.btnBuscarEjemplar.Location = new System.Drawing.Point(489, 75);
            this.btnBuscarEjemplar.Name = "btnBuscarEjemplar";
            this.btnBuscarEjemplar.Size = new System.Drawing.Size(53, 20);
            this.btnBuscarEjemplar.TabIndex = 60;
            this.btnBuscarEjemplar.Text = "Buscar";
            this.btnBuscarEjemplar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 46);
            this.button1.TabIndex = 61;
            this.button1.Text = "Confirmar devolución";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(679, 461);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 46);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Fecha Tentativa de devolución";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Fecha Devolución";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 46);
            this.button2.TabIndex = 67;
            this.button2.Text = "Confirmar devolución";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 46);
            this.button3.TabIndex = 68;
            this.button3.Text = "Confirmar devolución";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(864, 461);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 46);
            this.button4.TabIndex = 69;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "El préstamo indicado no fue devuelto en la fecha establecida";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(39, 335);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(167, 20);
            this.dtpFechaAlta.TabIndex = 71;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(312, 401);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker2.TabIndex = 72;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(39, 404);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker3.TabIndex = 73;
            // 
            // frm3ABMPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 528);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarEjemplar);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblPlazoRestante);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigoEj);
            this.Controls.Add(this.lblDatosEjemplar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtCodigoEjemplar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCodigoCl);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Name = "frm3ABMPrestamo";
            this.Text = "frm3Devolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodigoCl;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoEj;
        private System.Windows.Forms.Label lblDatosEjemplar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtCodigoEjemplar;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label lblPlazoRestante;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarEjemplar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}