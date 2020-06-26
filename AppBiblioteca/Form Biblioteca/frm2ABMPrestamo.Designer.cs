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
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtCodigoEjemplar = new System.Windows.Forms.TextBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.lblPlazoRestante = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.txtPlazoRestante = new System.Windows.Forms.TextBox();
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
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoCl = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.btnEliminarPréstamo = new System.Windows.Forms.Button();
            this.gbBuscarPrestamos = new System.Windows.Forms.GroupBox();
            this.gbDatosPrestamo = new System.Windows.Forms.GroupBox();
            this.gbDatosEjemplar = new System.Windows.Forms.GroupBox();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblBuscarCodEjemplar = new System.Windows.Forms.Label();
            this.lblBuscarCodCliente = new System.Windows.Forms.Label();
            this.txtBuscarCodEjemplar = new System.Windows.Forms.TextBox();
            this.txtBuscarCodCliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbBuscarPrestamos.SuspendLayout();
            this.gbDatosPrestamo.SuspendLayout();
            this.gbDatosEjemplar.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(14, 176);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(42, 17);
            this.lblAutor.TabIndex = 48;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(14, 130);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 17);
            this.lblTitulo.TabIndex = 47;
            this.lblTitulo.Text = "Título";
            // 
            // lblCodigoEj
            // 
            this.lblCodigoEj.AutoSize = true;
            this.lblCodigoEj.Location = new System.Drawing.Point(14, 45);
            this.lblCodigoEj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoEj.Name = "lblCodigoEj";
            this.lblCodigoEj.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoEj.TabIndex = 46;
            this.lblCodigoEj.Text = "Código";
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(75, 176);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(221, 22);
            this.txtAutor.TabIndex = 43;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(75, 127);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(221, 22);
            this.textBox4.TabIndex = 42;
            // 
            // txtCodigoEjemplar
            // 
            this.txtCodigoEjemplar.Location = new System.Drawing.Point(75, 45);
            this.txtCodigoEjemplar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEjemplar.Name = "txtCodigoEjemplar";
            this.txtCodigoEjemplar.Size = new System.Drawing.Size(221, 22);
            this.txtCodigoEjemplar.TabIndex = 41;
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.ItemHeight = 16;
            this.lstPrestamos.Location = new System.Drawing.Point(712, 124);
            this.lstPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(604, 324);
            this.lstPrestamos.TabIndex = 52;
            this.lstPrestamos.SelectedIndexChanged += new System.EventHandler(this.lstPrestamos_SelectedIndexChanged);
            // 
            // lblPlazoRestante
            // 
            this.lblPlazoRestante.AutoSize = true;
            this.lblPlazoRestante.Location = new System.Drawing.Point(355, 103);
            this.lblPlazoRestante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlazoRestante.Name = "lblPlazoRestante";
            this.lblPlazoRestante.Size = new System.Drawing.Size(104, 17);
            this.lblPlazoRestante.TabIndex = 58;
            this.lblPlazoRestante.Text = "Plazo Restante";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(9, 39);
            this.lblFechaAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(75, 17);
            this.lblFechaAlta.TabIndex = 57;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // txtPlazoRestante
            // 
            this.txtPlazoRestante.Enabled = false;
            this.txtPlazoRestante.Location = new System.Drawing.Point(484, 100);
            this.txtPlazoRestante.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlazoRestante.Name = "txtPlazoRestante";
            this.txtPlazoRestante.ReadOnly = true;
            this.txtPlazoRestante.Size = new System.Drawing.Size(55, 22);
            this.txtPlazoRestante.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 57);
            this.button1.TabIndex = 61;
            this.button1.Text = "Confirmar Nuevo Préstamo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(839, 490);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(225, 57);
            this.btnLimpiarCampos.TabIndex = 62;
            this.btnLimpiarCampos.Text = "Limpiar Campos/\r\nActualizar Préstamos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // lblFechaTentativaDevolucion
            // 
            this.lblFechaTentativaDevolucion.AutoSize = true;
            this.lblFechaTentativaDevolucion.Location = new System.Drawing.Point(9, 105);
            this.lblFechaTentativaDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaTentativaDevolucion.Name = "lblFechaTentativaDevolucion";
            this.lblFechaTentativaDevolucion.Size = new System.Drawing.Size(110, 17);
            this.lblFechaTentativaDevolucion.TabIndex = 64;
            this.lblFechaTentativaDevolucion.Text = "Fecha Tentativa";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(355, 39);
            this.lblFechaDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(121, 17);
            this.lblFechaDevolucion.TabIndex = 66;
            this.lblFechaDevolucion.Text = "Fecha Devolución";
            this.lblFechaDevolucion.Visible = false;
            // 
            // btnConfirmarDevolución
            // 
            this.btnConfirmarDevolución.Location = new System.Drawing.Point(305, 490);
            this.btnConfirmarDevolución.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarDevolución.Name = "btnConfirmarDevolución";
            this.btnConfirmarDevolución.Size = new System.Drawing.Size(243, 57);
            this.btnConfirmarDevolución.TabIndex = 67;
            this.btnConfirmarDevolución.Text = "Confirmar Devolución";
            this.btnConfirmarDevolución.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1091, 490);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(225, 57);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(151, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "El préstamo indicado no fue devuelto en la fecha establecida";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaAlta.Enabled = false;
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(127, 39);
            this.dtpFechaAlta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(164, 22);
            this.dtpFechaAlta.TabIndex = 71;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(484, 39);
            this.dtpFechaDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(164, 22);
            this.dtpFechaDevolucion.TabIndex = 72;
            this.dtpFechaDevolucion.Visible = false;
            // 
            // dtpFechaTentativaDevolucion
            // 
            this.dtpFechaTentativaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaTentativaDevolucion.Enabled = false;
            this.dtpFechaTentativaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTentativaDevolucion.Location = new System.Drawing.Point(127, 98);
            this.dtpFechaTentativaDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaTentativaDevolucion.Name = "dtpFechaTentativaDevolucion";
            this.dtpFechaTentativaDevolucion.Size = new System.Drawing.Size(164, 22);
            this.dtpFechaTentativaDevolucion.TabIndex = 73;
            // 
            // chkAbiertos
            // 
            this.chkAbiertos.AutoSize = true;
            this.chkAbiertos.Checked = true;
            this.chkAbiertos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAbiertos.Location = new System.Drawing.Point(712, 454);
            this.chkAbiertos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAbiertos.Name = "chkAbiertos";
            this.chkAbiertos.Size = new System.Drawing.Size(233, 21);
            this.chkAbiertos.TabIndex = 74;
            this.chkAbiertos.Text = "Mostrar sólo préstamos abiertos";
            this.chkAbiertos.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(526, 57);
            this.btnBuscarPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(71, 25);
            this.btnBuscarPrestamo.TabIndex = 84;
            this.btnBuscarPrestamo.Text = "Buscar";
            this.btnBuscarPrestamo.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 179);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 83;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 127);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 82;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoCl
            // 
            this.lblCodigoCl.AutoSize = true;
            this.lblCodigoCl.Location = new System.Drawing.Point(15, 45);
            this.lblCodigoCl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoCl.Name = "lblCodigoCl";
            this.lblCodigoCl.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoCl.TabIndex = 81;
            this.lblCodigoCl.Text = "Código";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Enabled = false;
            this.txtApellidoCliente.Location = new System.Drawing.Point(81, 173);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(221, 22);
            this.txtApellidoCliente.TabIndex = 79;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(81, 124);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(221, 22);
            this.txtNombreCliente.TabIndex = 78;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(81, 45);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(221, 22);
            this.txtCodigoCliente.TabIndex = 77;
            // 
            // btnEliminarPréstamo
            // 
            this.btnEliminarPréstamo.Location = new System.Drawing.Point(581, 490);
            this.btnEliminarPréstamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPréstamo.Name = "btnEliminarPréstamo";
            this.btnEliminarPréstamo.Size = new System.Drawing.Size(225, 57);
            this.btnEliminarPréstamo.TabIndex = 85;
            this.btnEliminarPréstamo.Text = "Eliminar préstamo";
            this.btnEliminarPréstamo.UseVisualStyleBackColor = true;
            // 
            // gbBuscarPrestamos
            // 
            this.gbBuscarPrestamos.Controls.Add(this.txtBuscarCodCliente);
            this.gbBuscarPrestamos.Controls.Add(this.txtBuscarCodEjemplar);
            this.gbBuscarPrestamos.Controls.Add(this.lblBuscarCodCliente);
            this.gbBuscarPrestamos.Controls.Add(this.lblBuscarCodEjemplar);
            this.gbBuscarPrestamos.Controls.Add(this.btnBuscarPrestamo);
            this.gbBuscarPrestamos.Location = new System.Drawing.Point(712, 8);
            this.gbBuscarPrestamos.Name = "gbBuscarPrestamos";
            this.gbBuscarPrestamos.Size = new System.Drawing.Size(604, 109);
            this.gbBuscarPrestamos.TabIndex = 86;
            this.gbBuscarPrestamos.TabStop = false;
            this.gbBuscarPrestamos.Text = "Buscar";
            // 
            // gbDatosPrestamo
            // 
            this.gbDatosPrestamo.Controls.Add(this.label3);
            this.gbDatosPrestamo.Controls.Add(this.lblFechaTentativaDevolucion);
            this.gbDatosPrestamo.Controls.Add(this.dtpFechaAlta);
            this.gbDatosPrestamo.Controls.Add(this.lblFechaAlta);
            this.gbDatosPrestamo.Controls.Add(this.dtpFechaTentativaDevolucion);
            this.gbDatosPrestamo.Controls.Add(this.txtPlazoRestante);
            this.gbDatosPrestamo.Controls.Add(this.lblPlazoRestante);
            this.gbDatosPrestamo.Controls.Add(this.lblFechaDevolucion);
            this.gbDatosPrestamo.Controls.Add(this.dtpFechaDevolucion);
            this.gbDatosPrestamo.Location = new System.Drawing.Point(30, 275);
            this.gbDatosPrestamo.Name = "gbDatosPrestamo";
            this.gbDatosPrestamo.Size = new System.Drawing.Size(675, 173);
            this.gbDatosPrestamo.TabIndex = 87;
            this.gbDatosPrestamo.TabStop = false;
            this.gbDatosPrestamo.Text = "Datos Préstamo";
            // 
            // gbDatosEjemplar
            // 
            this.gbDatosEjemplar.Controls.Add(this.button3);
            this.gbDatosEjemplar.Controls.Add(this.lblCodigoEj);
            this.gbDatosEjemplar.Controls.Add(this.lblTitulo);
            this.gbDatosEjemplar.Controls.Add(this.txtCodigoEjemplar);
            this.gbDatosEjemplar.Controls.Add(this.textBox4);
            this.gbDatosEjemplar.Controls.Add(this.lblAutor);
            this.gbDatosEjemplar.Controls.Add(this.txtAutor);
            this.gbDatosEjemplar.Location = new System.Drawing.Point(30, 12);
            this.gbDatosEjemplar.Name = "gbDatosEjemplar";
            this.gbDatosEjemplar.Size = new System.Drawing.Size(316, 229);
            this.gbDatosEjemplar.TabIndex = 88;
            this.gbDatosEjemplar.TabStop = false;
            this.gbDatosEjemplar.Text = "Datos Ejemplar";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.button2);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Controls.Add(this.lblCodigoCl);
            this.gbDatosCliente.Controls.Add(this.txtCodigoCliente);
            this.gbDatosCliente.Controls.Add(this.txtApellidoCliente);
            this.gbDatosCliente.Controls.Add(this.lblApellido);
            this.gbDatosCliente.Controls.Add(this.txtNombreCliente);
            this.gbDatosCliente.Location = new System.Drawing.Point(375, 12);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(330, 229);
            this.gbDatosCliente.TabIndex = 89;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos Cliente";
            // 
            // lblBuscarCodEjemplar
            // 
            this.lblBuscarCodEjemplar.AutoSize = true;
            this.lblBuscarCodEjemplar.Location = new System.Drawing.Point(7, 39);
            this.lblBuscarCodEjemplar.Name = "lblBuscarCodEjemplar";
            this.lblBuscarCodEjemplar.Size = new System.Drawing.Size(130, 17);
            this.lblBuscarCodEjemplar.TabIndex = 85;
            this.lblBuscarCodEjemplar.Text = "Código de ejemplar";
            // 
            // lblBuscarCodCliente
            // 
            this.lblBuscarCodCliente.AutoSize = true;
            this.lblBuscarCodCliente.Location = new System.Drawing.Point(7, 77);
            this.lblBuscarCodCliente.Name = "lblBuscarCodCliente";
            this.lblBuscarCodCliente.Size = new System.Drawing.Size(117, 17);
            this.lblBuscarCodCliente.TabIndex = 86;
            this.lblBuscarCodCliente.Text = "Código de cliente";
            // 
            // txtBuscarCodEjemplar
            // 
            this.txtBuscarCodEjemplar.Location = new System.Drawing.Point(143, 36);
            this.txtBuscarCodEjemplar.Name = "txtBuscarCodEjemplar";
            this.txtBuscarCodEjemplar.Size = new System.Drawing.Size(376, 22);
            this.txtBuscarCodEjemplar.TabIndex = 87;
            // 
            // txtBuscarCodCliente
            // 
            this.txtBuscarCodCliente.Location = new System.Drawing.Point(143, 77);
            this.txtBuscarCodCliente.Name = "txtBuscarCodCliente";
            this.txtBuscarCodCliente.Size = new System.Drawing.Size(376, 22);
            this.txtBuscarCodCliente.TabIndex = 88;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 84;
            this.button2.Text = "Clientes...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 35);
            this.button3.TabIndex = 49;
            this.button3.Text = "Ejemplares...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frm2ABMPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 566);
            this.Controls.Add(this.btnEliminarPréstamo);
            this.Controls.Add(this.chkAbiertos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmarDevolución);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.gbBuscarPrestamos);
            this.Controls.Add(this.gbDatosPrestamo);
            this.Controls.Add(this.gbDatosEjemplar);
            this.Controls.Add(this.gbDatosCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm2ABMPrestamo";
            this.Text = "Gestionar préstamos";
            this.gbBuscarPrestamos.ResumeLayout(false);
            this.gbBuscarPrestamos.PerformLayout();
            this.gbDatosPrestamo.ResumeLayout(false);
            this.gbDatosPrestamo.PerformLayout();
            this.gbDatosEjemplar.ResumeLayout(false);
            this.gbDatosEjemplar.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoEj;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtCodigoEjemplar;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label lblPlazoRestante;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.TextBox txtPlazoRestante;
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
        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoCl;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Button btnEliminarPréstamo;
        private System.Windows.Forms.GroupBox gbBuscarPrestamos;
        private System.Windows.Forms.GroupBox gbDatosPrestamo;
        private System.Windows.Forms.GroupBox gbDatosEjemplar;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtBuscarCodCliente;
        private System.Windows.Forms.TextBox txtBuscarCodEjemplar;
        private System.Windows.Forms.Label lblBuscarCodCliente;
        private System.Windows.Forms.Label lblBuscarCodEjemplar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}