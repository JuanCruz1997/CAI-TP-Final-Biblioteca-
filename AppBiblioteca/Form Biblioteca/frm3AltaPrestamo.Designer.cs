namespace Form_Biblioteca
{
    partial class frm3AltaPrestamo
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
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigoEjemplar = new System.Windows.Forms.TextBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.btnConfirmarNuevoPrestamo = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblFechaTentativaDevolucion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTentativaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoCl = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.gbDatosPrestamo = new System.Windows.Forms.GroupBox();
            this.gbDatosEjemplar = new System.Windows.Forms.GroupBox();
            this.btnActualizarDatosEjemplar = new System.Windows.Forms.Button();
            this.btnTraerEjemplares = new System.Windows.Forms.Button();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnActualizarDatosCliente = new System.Windows.Forms.Button();
            this.btnTraerClientes = new System.Windows.Forms.Button();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblPrecioPorDía = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gbDatosPrestamo.SuspendLayout();
            this.gbDatosEjemplar.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(10, 145);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 48;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(10, 106);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 47;
            this.lblTitulo.Text = "Título";
            // 
            // lblCodigoEj
            // 
            this.lblCodigoEj.AutoSize = true;
            this.lblCodigoEj.Location = new System.Drawing.Point(10, 37);
            this.lblCodigoEj.Name = "lblCodigoEj";
            this.lblCodigoEj.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEj.TabIndex = 46;
            this.lblCodigoEj.Text = "Código";
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(56, 143);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(167, 20);
            this.txtAutor.TabIndex = 43;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(56, 103);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(167, 20);
            this.txtTitulo.TabIndex = 42;
            // 
            // txtCodigoEjemplar
            // 
            this.txtCodigoEjemplar.Location = new System.Drawing.Point(56, 37);
            this.txtCodigoEjemplar.Name = "txtCodigoEjemplar";
            this.txtCodigoEjemplar.Size = new System.Drawing.Size(167, 20);
            this.txtCodigoEjemplar.TabIndex = 52;
            this.txtCodigoEjemplar.TextChanged += new System.EventHandler(this.txtCodigoEjemplar_TextChanged);
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(282, 70);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(58, 13);
            this.lblFechaAlta.TabIndex = 57;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // btnConfirmarNuevoPrestamo
            // 
            this.btnConfirmarNuevoPrestamo.Location = new System.Drawing.Point(22, 333);
            this.btnConfirmarNuevoPrestamo.Name = "btnConfirmarNuevoPrestamo";
            this.btnConfirmarNuevoPrestamo.Size = new System.Drawing.Size(182, 46);
            this.btnConfirmarNuevoPrestamo.TabIndex = 58;
            this.btnConfirmarNuevoPrestamo.Text = "Confirmar Nuevo Préstamo";
            this.btnConfirmarNuevoPrestamo.UseVisualStyleBackColor = true;
            this.btnConfirmarNuevoPrestamo.Click += new System.EventHandler(this.btnConfirmarNuevoPrestamo_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(211, 333);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(169, 46);
            this.btnLimpiarCampos.TabIndex = 59;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblFechaTentativaDevolucion
            // 
            this.lblFechaTentativaDevolucion.AutoSize = true;
            this.lblFechaTentativaDevolucion.Location = new System.Drawing.Point(282, 34);
            this.lblFechaTentativaDevolucion.Name = "lblFechaTentativaDevolucion";
            this.lblFechaTentativaDevolucion.Size = new System.Drawing.Size(85, 13);
            this.lblFechaTentativaDevolucion.TabIndex = 64;
            this.lblFechaTentativaDevolucion.Text = "Fecha Tentativa";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(386, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 46);
            this.btnSalir.TabIndex = 60;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaAlta.Enabled = false;
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(374, 67);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(124, 20);
            this.dtpFechaAlta.TabIndex = 71;
            // 
            // dtpFechaTentativaDevolucion
            // 
            this.dtpFechaTentativaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaTentativaDevolucion.Enabled = false;
            this.dtpFechaTentativaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTentativaDevolucion.Location = new System.Drawing.Point(377, 28);
            this.dtpFechaTentativaDevolucion.Name = "dtpFechaTentativaDevolucion";
            this.dtpFechaTentativaDevolucion.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaTentativaDevolucion.TabIndex = 73;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(11, 145);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 83;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 82;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoCl
            // 
            this.lblCodigoCl.AutoSize = true;
            this.lblCodigoCl.Location = new System.Drawing.Point(11, 37);
            this.lblCodigoCl.Name = "lblCodigoCl";
            this.lblCodigoCl.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoCl.TabIndex = 81;
            this.lblCodigoCl.Text = "Código";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Enabled = false;
            this.txtApellidoCliente.Location = new System.Drawing.Point(61, 141);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(167, 20);
            this.txtApellidoCliente.TabIndex = 79;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(61, 101);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(167, 20);
            this.txtNombreCliente.TabIndex = 78;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(61, 37);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(167, 20);
            this.txtCodigoCliente.TabIndex = 55;
            this.txtCodigoCliente.TextChanged += new System.EventHandler(this.txtCodigoCliente_TextChanged);
            // 
            // gbDatosPrestamo
            // 
            this.gbDatosPrestamo.Controls.Add(this.lblPrecioPorDía);
            this.gbDatosPrestamo.Controls.Add(this.txtPrecio);
            this.gbDatosPrestamo.Controls.Add(this.txtPlazo);
            this.gbDatosPrestamo.Controls.Add(this.lblPlazo);
            this.gbDatosPrestamo.Controls.Add(this.lblFechaTentativaDevolucion);
            this.gbDatosPrestamo.Controls.Add(this.dtpFechaAlta);
            this.gbDatosPrestamo.Controls.Add(this.lblFechaAlta);
            this.gbDatosPrestamo.Controls.Add(this.dtpFechaTentativaDevolucion);
            this.gbDatosPrestamo.Location = new System.Drawing.Point(22, 209);
            this.gbDatosPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosPrestamo.Name = "gbDatosPrestamo";
            this.gbDatosPrestamo.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosPrestamo.Size = new System.Drawing.Size(532, 104);
            this.gbDatosPrestamo.TabIndex = 87;
            this.gbDatosPrestamo.TabStop = false;
            this.gbDatosPrestamo.Text = "Datos Préstamo";
            // 
            // gbDatosEjemplar
            // 
            this.gbDatosEjemplar.Controls.Add(this.btnActualizarDatosEjemplar);
            this.gbDatosEjemplar.Controls.Add(this.btnTraerEjemplares);
            this.gbDatosEjemplar.Controls.Add(this.lblCodigoEj);
            this.gbDatosEjemplar.Controls.Add(this.lblTitulo);
            this.gbDatosEjemplar.Controls.Add(this.txtCodigoEjemplar);
            this.gbDatosEjemplar.Controls.Add(this.txtTitulo);
            this.gbDatosEjemplar.Controls.Add(this.lblAutor);
            this.gbDatosEjemplar.Controls.Add(this.txtAutor);
            this.gbDatosEjemplar.Location = new System.Drawing.Point(22, 10);
            this.gbDatosEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosEjemplar.Name = "gbDatosEjemplar";
            this.gbDatosEjemplar.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosEjemplar.Size = new System.Drawing.Size(267, 195);
            this.gbDatosEjemplar.TabIndex = 88;
            this.gbDatosEjemplar.TabStop = false;
            this.gbDatosEjemplar.Text = "Datos Ejemplar";
            // 
            // btnActualizarDatosEjemplar
            // 
            this.btnActualizarDatosEjemplar.Location = new System.Drawing.Point(56, 60);
            this.btnActualizarDatosEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarDatosEjemplar.Name = "btnActualizarDatosEjemplar";
            this.btnActualizarDatosEjemplar.Size = new System.Drawing.Size(79, 28);
            this.btnActualizarDatosEjemplar.TabIndex = 53;
            this.btnActualizarDatosEjemplar.Text = "Actualizar";
            this.btnActualizarDatosEjemplar.UseVisualStyleBackColor = true;
            this.btnActualizarDatosEjemplar.Click += new System.EventHandler(this.btnActualizarDatosEjemplar_Click);
            // 
            // btnTraerEjemplares
            // 
            this.btnTraerEjemplares.Location = new System.Drawing.Point(143, 60);
            this.btnTraerEjemplares.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraerEjemplares.Name = "btnTraerEjemplares";
            this.btnTraerEjemplares.Size = new System.Drawing.Size(79, 28);
            this.btnTraerEjemplares.TabIndex = 54;
            this.btnTraerEjemplares.Text = "Ejemplares...";
            this.btnTraerEjemplares.UseVisualStyleBackColor = true;
            this.btnTraerEjemplares.Click += new System.EventHandler(this.btnTraerEjemplares_Click);
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.btnActualizarDatosCliente);
            this.gbDatosCliente.Controls.Add(this.btnTraerClientes);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Controls.Add(this.lblCodigoCl);
            this.gbDatosCliente.Controls.Add(this.txtCodigoCliente);
            this.gbDatosCliente.Controls.Add(this.txtApellidoCliente);
            this.gbDatosCliente.Controls.Add(this.lblApellido);
            this.gbDatosCliente.Controls.Add(this.txtNombreCliente);
            this.gbDatosCliente.Location = new System.Drawing.Point(293, 10);
            this.gbDatosCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosCliente.Size = new System.Drawing.Size(262, 195);
            this.gbDatosCliente.TabIndex = 89;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos Cliente";
            // 
            // btnActualizarDatosCliente
            // 
            this.btnActualizarDatosCliente.Location = new System.Drawing.Point(61, 59);
            this.btnActualizarDatosCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarDatosCliente.Name = "btnActualizarDatosCliente";
            this.btnActualizarDatosCliente.Size = new System.Drawing.Size(79, 28);
            this.btnActualizarDatosCliente.TabIndex = 51;
            this.btnActualizarDatosCliente.Text = "Actualizar";
            this.btnActualizarDatosCliente.UseVisualStyleBackColor = true;
            this.btnActualizarDatosCliente.Click += new System.EventHandler(this.btnActualizarDatosCliente_Click);
            // 
            // btnTraerClientes
            // 
            this.btnTraerClientes.Location = new System.Drawing.Point(144, 59);
            this.btnTraerClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraerClientes.Name = "btnTraerClientes";
            this.btnTraerClientes.Size = new System.Drawing.Size(83, 29);
            this.btnTraerClientes.TabIndex = 57;
            this.btnTraerClientes.Text = "Clientes...";
            this.btnTraerClientes.UseVisualStyleBackColor = true;
            this.btnTraerClientes.Click += new System.EventHandler(this.btnTraerClientes_Click);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Enabled = false;
            this.txtPlazo.Location = new System.Drawing.Point(100, 28);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.ReadOnly = true;
            this.txtPlazo.Size = new System.Drawing.Size(122, 20);
            this.txtPlazo.TabIndex = 84;
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(12, 34);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(33, 13);
            this.lblPlazo.TabIndex = 85;
            this.lblPlazo.Text = "Plazo";
            // 
            // lblPrecioPorDía
            // 
            this.lblPrecioPorDía.AutoSize = true;
            this.lblPrecioPorDía.Location = new System.Drawing.Point(12, 68);
            this.lblPrecioPorDía.Name = "lblPrecioPorDía";
            this.lblPrecioPorDía.Size = new System.Drawing.Size(74, 13);
            this.lblPrecioPorDía.TabIndex = 56;
            this.lblPrecioPorDía.Text = "Precio por día";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(101, 63);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(122, 20);
            this.txtPrecio.TabIndex = 55;
            // 
            // frm3AltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 399);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnConfirmarNuevoPrestamo);
            this.Controls.Add(this.gbDatosPrestamo);
            this.Controls.Add(this.gbDatosEjemplar);
            this.Controls.Add(this.gbDatosCliente);
            this.KeyPreview = true;
            this.Name = "frm3AltaPrestamo";
            this.Text = "Alta de nuevo préstamo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm3AltaPrestamo_FormClosed);
            this.Load += new System.EventHandler(this.frm3AltaPrestamo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm3AltaPrestamo_KeyDown);
            this.gbDatosPrestamo.ResumeLayout(false);
            this.gbDatosPrestamo.PerformLayout();
            this.gbDatosEjemplar.ResumeLayout(false);
            this.gbDatosEjemplar.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoEj;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigoEjemplar;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Button btnConfirmarNuevoPrestamo;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label lblFechaTentativaDevolucion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaTentativaDevolucion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoCl;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.GroupBox gbDatosPrestamo;
        private System.Windows.Forms.GroupBox gbDatosEjemplar;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.Button btnTraerEjemplares;
        private System.Windows.Forms.Button btnTraerClientes;
        private System.Windows.Forms.Button btnActualizarDatosEjemplar;
        private System.Windows.Forms.Button btnActualizarDatosCliente;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblPrecioPorDía;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}