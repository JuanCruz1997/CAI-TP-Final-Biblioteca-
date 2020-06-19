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
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigoEj = new System.Windows.Forms.Label();
            this.lblDatosEjemplar = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtCodigoEjemplar = new System.Windows.Forms.TextBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.lblPlazoRestante = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblDatosPrestamo = new System.Windows.Forms.Label();
            this.txtPlazoRestante = new System.Windows.Forms.TextBox();
            this.btnBuscarEjemplar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblFechaTentativaDevolucion = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.btnConfirmarDevolución = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTentativaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.chkAbiertos = new System.Windows.Forms.CheckBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoCl = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.btnEliminarPréstamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(29, 210);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 48;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(29, 138);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 47;
            this.lblTitulo.Text = "Título";
            // 
            // lblCodigoEj
            // 
            this.lblCodigoEj.AutoSize = true;
            this.lblCodigoEj.Location = new System.Drawing.Point(29, 62);
            this.lblCodigoEj.Name = "lblCodigoEj";
            this.lblCodigoEj.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEj.TabIndex = 46;
            this.lblCodigoEj.Text = "Código";
            // 
            // lblDatosEjemplar
            // 
            this.lblDatosEjemplar.AutoSize = true;
            this.lblDatosEjemplar.Location = new System.Drawing.Point(29, 29);
            this.lblDatosEjemplar.Name = "lblDatosEjemplar";
            this.lblDatosEjemplar.Size = new System.Drawing.Size(78, 13);
            this.lblDatosEjemplar.TabIndex = 45;
            this.lblDatosEjemplar.Text = "Datos Ejemplar";
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(39, 237);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(167, 20);
            this.txtAutor.TabIndex = 43;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(39, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 42;
            // 
            // txtCodigoEjemplar
            // 
            this.txtCodigoEjemplar.Location = new System.Drawing.Point(39, 88);
            this.txtCodigoEjemplar.Name = "txtCodigoEjemplar";
            this.txtCodigoEjemplar.Size = new System.Drawing.Size(167, 20);
            this.txtCodigoEjemplar.TabIndex = 41;
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(556, 23);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(477, 381);
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
            // lblDatosPrestamo
            // 
            this.lblDatosPrestamo.AutoSize = true;
            this.lblDatosPrestamo.Location = new System.Drawing.Point(29, 276);
            this.lblDatosPrestamo.Name = "lblDatosPrestamo";
            this.lblDatosPrestamo.Size = new System.Drawing.Size(87, 13);
            this.lblDatosPrestamo.TabIndex = 56;
            this.lblDatosPrestamo.Text = "Datos Préstamos";
            // 
            // txtPlazoRestante
            // 
            this.txtPlazoRestante.Enabled = false;
            this.txtPlazoRestante.Location = new System.Drawing.Point(312, 335);
            this.txtPlazoRestante.Name = "txtPlazoRestante";
            this.txtPlazoRestante.ReadOnly = true;
            this.txtPlazoRestante.Size = new System.Drawing.Size(167, 20);
            this.txtPlazoRestante.TabIndex = 54;
            // 
            // btnBuscarEjemplar
            // 
            this.btnBuscarEjemplar.Location = new System.Drawing.Point(216, 88);
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
            this.button1.Text = "Confirmar Nuevo Préstamo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(666, 461);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(169, 46);
            this.btnLimpiarCampos.TabIndex = 62;
            this.btnLimpiarCampos.Text = "Limpiar Campos/\r\nActualizar Préstamos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // lblFechaTentativaDevolucion
            // 
            this.lblFechaTentativaDevolucion.AutoSize = true;
            this.lblFechaTentativaDevolucion.Location = new System.Drawing.Point(29, 378);
            this.lblFechaTentativaDevolucion.Name = "lblFechaTentativaDevolucion";
            this.lblFechaTentativaDevolucion.Size = new System.Drawing.Size(157, 13);
            this.lblFechaTentativaDevolucion.TabIndex = 64;
            this.lblFechaTentativaDevolucion.Text = "Fecha Tentativa de Devolución";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(302, 378);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(94, 13);
            this.lblFechaDevolucion.TabIndex = 66;
            this.lblFechaDevolucion.Text = "Fecha Devolución";
            this.lblFechaDevolucion.Visible = false;
            // 
            // btnConfirmarDevolución
            // 
            this.btnConfirmarDevolución.Location = new System.Drawing.Point(249, 461);
            this.btnConfirmarDevolución.Name = "btnConfirmarDevolución";
            this.btnConfirmarDevolución.Size = new System.Drawing.Size(182, 46);
            this.btnConfirmarDevolución.TabIndex = 67;
            this.btnConfirmarDevolución.Text = "Confirmar Devolución";
            this.btnConfirmarDevolución.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(864, 461);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 46);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(554, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "El préstamo indicado no fue devuelto en la fecha establecida";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaAlta.Enabled = false;
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(39, 335);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(167, 20);
            this.dtpFechaAlta.TabIndex = 71;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(312, 401);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(167, 20);
            this.dtpFechaDevolucion.TabIndex = 72;
            this.dtpFechaDevolucion.Visible = false;
            // 
            // dtpFechaTentativaDevolucion
            // 
            this.dtpFechaTentativaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaTentativaDevolucion.Enabled = false;
            this.dtpFechaTentativaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTentativaDevolucion.Location = new System.Drawing.Point(39, 404);
            this.dtpFechaTentativaDevolucion.Name = "dtpFechaTentativaDevolucion";
            this.dtpFechaTentativaDevolucion.Size = new System.Drawing.Size(167, 20);
            this.dtpFechaTentativaDevolucion.TabIndex = 73;
            // 
            // chkAbiertos
            // 
            this.chkAbiertos.AutoSize = true;
            this.chkAbiertos.Checked = true;
            this.chkAbiertos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAbiertos.Location = new System.Drawing.Point(556, 408);
            this.chkAbiertos.Margin = new System.Windows.Forms.Padding(2);
            this.chkAbiertos.Name = "chkAbiertos";
            this.chkAbiertos.Size = new System.Drawing.Size(174, 17);
            this.chkAbiertos.TabIndex = 74;
            this.chkAbiertos.Text = "Mostrar sólo préstamos abiertos";
            this.chkAbiertos.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(485, 88);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(53, 20);
            this.btnBuscarCliente.TabIndex = 84;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(302, 210);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 83;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(302, 138);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 82;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoCl
            // 
            this.lblCodigoCl.AutoSize = true;
            this.lblCodigoCl.Location = new System.Drawing.Point(302, 62);
            this.lblCodigoCl.Name = "lblCodigoCl";
            this.lblCodigoCl.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoCl.TabIndex = 81;
            this.lblCodigoCl.Text = "Código";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Location = new System.Drawing.Point(302, 29);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(70, 13);
            this.lblDatosCliente.TabIndex = 80;
            this.lblDatosCliente.Text = "Datos Cliente";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Enabled = false;
            this.txtApellidoCliente.Location = new System.Drawing.Point(312, 237);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(167, 20);
            this.txtApellidoCliente.TabIndex = 79;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(312, 166);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(167, 20);
            this.txtNombreCliente.TabIndex = 78;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(312, 88);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(167, 20);
            this.txtCodigoCliente.TabIndex = 77;
            // 
            // btnEliminarPréstamo
            // 
            this.btnEliminarPréstamo.Location = new System.Drawing.Point(466, 461);
            this.btnEliminarPréstamo.Name = "btnEliminarPréstamo";
            this.btnEliminarPréstamo.Size = new System.Drawing.Size(169, 46);
            this.btnEliminarPréstamo.TabIndex = 85;
            this.btnEliminarPréstamo.Text = "Eliminar préstamo";
            this.btnEliminarPréstamo.UseVisualStyleBackColor = true;
            // 
            // frm2ABMPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 528);
            this.Controls.Add(this.btnEliminarPréstamo);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoCl);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.chkAbiertos);
            this.Controls.Add(this.dtpFechaTentativaDevolucion);
            this.Controls.Add(this.dtpFechaDevolucion);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmarDevolución);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.lblFechaTentativaDevolucion);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarEjemplar);
            this.Controls.Add(this.lblPlazoRestante);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblDatosPrestamo);
            this.Controls.Add(this.txtPlazoRestante);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigoEj);
            this.Controls.Add(this.lblDatosEjemplar);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtCodigoEjemplar);
            this.Name = "frm2ABMPrestamo";
            this.Text = "Gestionar préstamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoEj;
        private System.Windows.Forms.Label lblDatosEjemplar;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtCodigoEjemplar;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label lblPlazoRestante;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblDatosPrestamo;
        private System.Windows.Forms.TextBox txtPlazoRestante;
        private System.Windows.Forms.Button btnBuscarEjemplar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label lblFechaTentativaDevolucion;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Button btnConfirmarDevolución;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtpFechaTentativaDevolucion;
        private System.Windows.Forms.CheckBox chkAbiertos;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoCl;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Button btnEliminarPréstamo;
    }
}