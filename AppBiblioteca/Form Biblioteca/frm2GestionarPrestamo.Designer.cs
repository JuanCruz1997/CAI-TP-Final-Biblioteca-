namespace Form_Biblioteca
{
    partial class frm2GestionarPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevoPrestamo = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblFechaTentativaDevolucion = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.btnConfirmarDevolución = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRojo = new System.Windows.Forms.Label();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTentativaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.chkAbiertos = new System.Windows.Forms.CheckBox();
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.btnEliminarPréstamo = new System.Windows.Forms.Button();
            this.gbBuscarPrestamos = new System.Windows.Forms.GroupBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtBuscarCodCliente = new System.Windows.Forms.TextBox();
            this.txtBuscarCodEjemplar = new System.Windows.Forms.TextBox();
            this.btnEjemplares = new System.Windows.Forms.Button();
            this.lblBuscarCodCliente = new System.Windows.Forms.Label();
            this.lblBuscarCodEjemplar = new System.Windows.Forms.Label();
            this.gbDatosPrestamo = new System.Windows.Forms.GroupBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazoRestanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamoAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoAdapterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbBuscarPrestamos.SuspendLayout();
            this.gbDatosPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoAdapterBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoPrestamo
            // 
            this.btnNuevoPrestamo.Location = new System.Drawing.Point(10, 398);
            this.btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            this.btnNuevoPrestamo.Size = new System.Drawing.Size(182, 46);
            this.btnNuevoPrestamo.TabIndex = 26;
            this.btnNuevoPrestamo.Text = "Nuevo Préstamo...";
            this.btnNuevoPrestamo.UseVisualStyleBackColor = true;
            this.btnNuevoPrestamo.Click += new System.EventHandler(this.btnNuevoPrestamo_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(629, 398);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(169, 46);
            this.btnLimpiarCampos.TabIndex = 29;
            this.btnLimpiarCampos.Text = "Limpiar Campos/\r\nActualizar Préstamos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblFechaTentativaDevolucion
            // 
            this.lblFechaTentativaDevolucion.AutoSize = true;
            this.lblFechaTentativaDevolucion.Location = new System.Drawing.Point(5, 63);
            this.lblFechaTentativaDevolucion.Name = "lblFechaTentativaDevolucion";
            this.lblFechaTentativaDevolucion.Size = new System.Drawing.Size(85, 13);
            this.lblFechaTentativaDevolucion.TabIndex = 64;
            this.lblFechaTentativaDevolucion.Text = "Fecha Tentativa";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(221, 63);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(94, 13);
            this.lblFechaDevolucion.TabIndex = 66;
            this.lblFechaDevolucion.Text = "Fecha Devolución";
            // 
            // btnConfirmarDevolución
            // 
            this.btnConfirmarDevolución.Location = new System.Drawing.Point(212, 398);
            this.btnConfirmarDevolución.Name = "btnConfirmarDevolución";
            this.btnConfirmarDevolución.Size = new System.Drawing.Size(182, 46);
            this.btnConfirmarDevolución.TabIndex = 27;
            this.btnConfirmarDevolución.Text = "Confirmar Devolución";
            this.btnConfirmarDevolución.UseVisualStyleBackColor = true;
            this.btnConfirmarDevolución.Click += new System.EventHandler(this.btnConfirmarDevolución_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(818, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 46);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Enabled = false;
            this.lblRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRojo.ForeColor = System.Drawing.Color.Red;
            this.lblRojo.Location = new System.Drawing.Point(221, 24);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(355, 13);
            this.lblRojo.TabIndex = 70;
            this.lblRojo.Text = "El préstamo indicado no fue devuelto en la fecha establecida";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(319, 60);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaDevolucion.TabIndex = 25;
            // 
            // dtpFechaTentativaDevolucion
            // 
            this.dtpFechaTentativaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaTentativaDevolucion.Enabled = false;
            this.dtpFechaTentativaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTentativaDevolucion.Location = new System.Drawing.Point(96, 60);
            this.dtpFechaTentativaDevolucion.Name = "dtpFechaTentativaDevolucion";
            this.dtpFechaTentativaDevolucion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaTentativaDevolucion.TabIndex = 24;
            // 
            // chkAbiertos
            // 
            this.chkAbiertos.AutoSize = true;
            this.chkAbiertos.Checked = true;
            this.chkAbiertos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAbiertos.Location = new System.Drawing.Point(8, 24);
            this.chkAbiertos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAbiertos.Name = "chkAbiertos";
            this.chkAbiertos.Size = new System.Drawing.Size(174, 17);
            this.chkAbiertos.TabIndex = 23;
            this.chkAbiertos.Text = "Mostrar sólo préstamos abiertos";
            this.chkAbiertos.UseVisualStyleBackColor = true;
            this.chkAbiertos.CheckedChanged += new System.EventHandler(this.chkAbiertos_CheckedChanged);
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(284, 24);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(88, 62);
            this.btnBuscarPrestamo.TabIndex = 22;
            this.btnBuscarPrestamo.Text = "Buscar";
            this.btnBuscarPrestamo.UseVisualStyleBackColor = true;
            this.btnBuscarPrestamo.Click += new System.EventHandler(this.btnBuscarPrestamo_Click);
            // 
            // btnEliminarPréstamo
            // 
            this.btnEliminarPréstamo.Location = new System.Drawing.Point(418, 398);
            this.btnEliminarPréstamo.Name = "btnEliminarPréstamo";
            this.btnEliminarPréstamo.Size = new System.Drawing.Size(169, 46);
            this.btnEliminarPréstamo.TabIndex = 28;
            this.btnEliminarPréstamo.Text = "Eliminar préstamo";
            this.btnEliminarPréstamo.UseVisualStyleBackColor = true;
            this.btnEliminarPréstamo.Click += new System.EventHandler(this.btnEliminarPréstamo_Click);
            // 
            // gbBuscarPrestamos
            // 
            this.gbBuscarPrestamos.Controls.Add(this.btnClientes);
            this.gbBuscarPrestamos.Controls.Add(this.txtBuscarCodCliente);
            this.gbBuscarPrestamos.Controls.Add(this.txtBuscarCodEjemplar);
            this.gbBuscarPrestamos.Controls.Add(this.btnEjemplares);
            this.gbBuscarPrestamos.Controls.Add(this.lblBuscarCodCliente);
            this.gbBuscarPrestamos.Controls.Add(this.lblBuscarCodEjemplar);
            this.gbBuscarPrestamos.Controls.Add(this.btnBuscarPrestamo);
            this.gbBuscarPrestamos.Location = new System.Drawing.Point(9, 10);
            this.gbBuscarPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBuscarPrestamos.Name = "gbBuscarPrestamos";
            this.gbBuscarPrestamos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBuscarPrestamos.Size = new System.Drawing.Size(385, 97);
            this.gbBuscarPrestamos.TabIndex = 0;
            this.gbBuscarPrestamos.TabStop = false;
            this.gbBuscarPrestamos.Text = "Buscar";
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(200, 57);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(79, 29);
            this.btnClientes.TabIndex = 21;
            this.btnClientes.Text = "Clientes...";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtBuscarCodCliente
            // 
            this.txtBuscarCodCliente.Location = new System.Drawing.Point(107, 63);
            this.txtBuscarCodCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarCodCliente.Name = "txtBuscarCodCliente";
            this.txtBuscarCodCliente.Size = new System.Drawing.Size(90, 20);
            this.txtBuscarCodCliente.TabIndex = 20;
            // 
            // txtBuscarCodEjemplar
            // 
            this.txtBuscarCodEjemplar.Location = new System.Drawing.Point(107, 29);
            this.txtBuscarCodEjemplar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarCodEjemplar.Name = "txtBuscarCodEjemplar";
            this.txtBuscarCodEjemplar.Size = new System.Drawing.Size(90, 20);
            this.txtBuscarCodEjemplar.TabIndex = 18;
            // 
            // btnEjemplares
            // 
            this.btnEjemplares.Location = new System.Drawing.Point(200, 24);
            this.btnEjemplares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEjemplares.Name = "btnEjemplares";
            this.btnEjemplares.Size = new System.Drawing.Size(79, 28);
            this.btnEjemplares.TabIndex = 19;
            this.btnEjemplares.Text = "Ejemplares...";
            this.btnEjemplares.UseVisualStyleBackColor = true;
            this.btnEjemplares.Click += new System.EventHandler(this.btnEjemplares_Click);
            // 
            // lblBuscarCodCliente
            // 
            this.lblBuscarCodCliente.AutoSize = true;
            this.lblBuscarCodCliente.Location = new System.Drawing.Point(5, 63);
            this.lblBuscarCodCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarCodCliente.Name = "lblBuscarCodCliente";
            this.lblBuscarCodCliente.Size = new System.Drawing.Size(89, 13);
            this.lblBuscarCodCliente.TabIndex = 86;
            this.lblBuscarCodCliente.Text = "Código de cliente";
            // 
            // lblBuscarCodEjemplar
            // 
            this.lblBuscarCodEjemplar.AutoSize = true;
            this.lblBuscarCodEjemplar.Location = new System.Drawing.Point(5, 32);
            this.lblBuscarCodEjemplar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarCodEjemplar.Name = "lblBuscarCodEjemplar";
            this.lblBuscarCodEjemplar.Size = new System.Drawing.Size(97, 13);
            this.lblBuscarCodEjemplar.TabIndex = 85;
            this.lblBuscarCodEjemplar.Text = "Código de ejemplar";
            // 
            // gbDatosPrestamo
            // 
            this.gbDatosPrestamo.Controls.Add(this.txtDeuda);
            this.gbDatosPrestamo.Controls.Add(this.lblDeuda);
            this.gbDatosPrestamo.Controls.Add(this.lblRojo);
            this.gbDatosPrestamo.Controls.Add(this.chkAbiertos);
            this.gbDatosPrestamo.Controls.Add(this.lblFechaTentativaDevolucion);
            this.gbDatosPrestamo.Controls.Add(this.dtpFechaTentativaDevolucion);
            this.gbDatosPrestamo.Controls.Add(this.lblFechaDevolucion);
            this.gbDatosPrestamo.Controls.Add(this.dtpFechaDevolucion);
            this.gbDatosPrestamo.Location = new System.Drawing.Point(405, 10);
            this.gbDatosPrestamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosPrestamo.Name = "gbDatosPrestamo";
            this.gbDatosPrestamo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosPrestamo.Size = new System.Drawing.Size(582, 97);
            this.gbDatosPrestamo.TabIndex = 22;
            this.gbDatosPrestamo.TabStop = false;
            this.gbDatosPrestamo.Text = "Datos Préstamo";
            // 
            // txtDeuda
            // 
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Location = new System.Drawing.Point(483, 60);
            this.txtDeuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.ReadOnly = true;
            this.txtDeuda.Size = new System.Drawing.Size(90, 20);
            this.txtDeuda.TabIndex = 87;
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(437, 63);
            this.lblDeuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(39, 13);
            this.lblDeuda.TabIndex = 88;
            this.lblDeuda.Text = "Deuda";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AllowUserToResizeRows = false;
            this.dgvPrestamos.AutoGenerateColumns = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.fechaAltaPrestamoDataGridViewTextBoxColumn,
            this.plazoRestanteDataGridViewTextBoxColumn});
            this.dgvPrestamos.DataSource = this.prestamoAdapterBindingSource1;
            this.dgvPrestamos.Location = new System.Drawing.Point(10, 112);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(977, 280);
            this.dgvPrestamos.TabIndex = 31;
            this.dgvPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAltaPrestamoDataGridViewTextBoxColumn
            // 
            this.fechaAltaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "FechaAltaPrestamo";
            this.fechaAltaPrestamoDataGridViewTextBoxColumn.HeaderText = "Fecha Alta Préstamo";
            this.fechaAltaPrestamoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaAltaPrestamoDataGridViewTextBoxColumn.Name = "fechaAltaPrestamoDataGridViewTextBoxColumn";
            this.fechaAltaPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plazoRestanteDataGridViewTextBoxColumn
            // 
            this.plazoRestanteDataGridViewTextBoxColumn.DataPropertyName = "PlazoRestante";
            this.plazoRestanteDataGridViewTextBoxColumn.HeaderText = "Plazo Restante";
            this.plazoRestanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plazoRestanteDataGridViewTextBoxColumn.Name = "plazoRestanteDataGridViewTextBoxColumn";
            this.plazoRestanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prestamoAdapterBindingSource
            // 
            this.prestamoAdapterBindingSource.DataSource = typeof(Entidades.PrestamoAdapter);
            // 
            // prestamoAdapterBindingSource1
            // 
            this.prestamoAdapterBindingSource1.DataSource = typeof(Entidades.PrestamoAdapter);
            // 
            // frm2GestionarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 460);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnEliminarPréstamo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmarDevolución);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnNuevoPrestamo);
            this.Controls.Add(this.gbBuscarPrestamos);
            this.Controls.Add(this.gbDatosPrestamo);
            this.KeyPreview = true;
            this.Name = "frm2GestionarPrestamo";
            this.Text = "Gestionar préstamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm2GestionarPrestamo_FormClosed);
            this.Load += new System.EventHandler(this.frm2GestionarPrestamo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm2GestionarPrestamo_KeyDown);
            this.gbBuscarPrestamos.ResumeLayout(false);
            this.gbBuscarPrestamos.PerformLayout();
            this.gbDatosPrestamo.ResumeLayout(false);
            this.gbDatosPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoAdapterBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label lblFechaTentativaDevolucion;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Button btnConfirmarDevolución;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtpFechaTentativaDevolucion;
        private System.Windows.Forms.CheckBox chkAbiertos;
        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.Button btnEliminarPréstamo;
        private System.Windows.Forms.GroupBox gbBuscarPrestamos;
        private System.Windows.Forms.GroupBox gbDatosPrestamo;
        private System.Windows.Forms.TextBox txtBuscarCodCliente;
        private System.Windows.Forms.TextBox txtBuscarCodEjemplar;
        private System.Windows.Forms.Label lblBuscarCodCliente;
        private System.Windows.Forms.Label lblBuscarCodEjemplar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEjemplares;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.BindingSource prestamoAdapterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazoRestanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.BindingSource prestamoAdapterBindingSource1;
    }
}