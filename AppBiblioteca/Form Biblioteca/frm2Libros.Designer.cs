namespace Form_Biblioteca
{
    partial class sa
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
            this.lblCantidadPáginas = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btbAlta = new System.Windows.Forms.Button();
            this.lblDatosLibro = new System.Windows.Forms.Label();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.txtDisponibles = new System.Windows.Forms.TextBox();
            this.txtCantidadAAgregar = new System.Windows.Forms.TextBox();
            this.lblCantidadAAgregar = new System.Windows.Forms.Label();
            this.btnVerEjemplares = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lstEjemplares = new System.Windows.Forms.ListBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnComprimir = new System.Windows.Forms.Button();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblCodigoCl = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.gbBuscarLibros = new System.Windows.Forms.GroupBox();
            this.txtBuscarAutor = new System.Windows.Forms.TextBox();
            this.txtBuscarTítulo = new System.Windows.Forms.TextBox();
            this.lblBuscarAutor = new System.Windows.Forms.Label();
            this.lblBuscarTítulo = new System.Windows.Forms.Label();
            this.txtBuscarISBN = new System.Windows.Forms.TextBox();
            this.lblBuscarISBN = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPaginasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPermanenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDisponibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbBuscarLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadPáginas
            // 
            this.lblCantidadPáginas.AutoSize = true;
            this.lblCantidadPáginas.Location = new System.Drawing.Point(267, 247);
            this.lblCantidadPáginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPáginas.Name = "lblCantidadPáginas";
            this.lblCantidadPáginas.Size = new System.Drawing.Size(59, 17);
            this.lblCantidadPáginas.TabIndex = 125;
            this.lblCantidadPáginas.Text = "Páginas";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(29, 298);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(59, 17);
            this.lblEditorial.TabIndex = 124;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(334, 245);
            this.txtPaginas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(49, 22);
            this.txtPaginas.TabIndex = 122;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(131, 298);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(252, 22);
            this.txtEditorial.TabIndex = 121;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(804, 559);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(225, 57);
            this.btnSalir.TabIndex = 117;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btbAlta
            // 
            this.btbAlta.Location = new System.Drawing.Point(31, 559);
            this.btbAlta.Margin = new System.Windows.Forms.Padding(4);
            this.btbAlta.Name = "btbAlta";
            this.btbAlta.Size = new System.Drawing.Size(243, 57);
            this.btbAlta.TabIndex = 116;
            this.btbAlta.Text = "Alta";
            this.btbAlta.UseVisualStyleBackColor = true;
            // 
            // lblDatosLibro
            // 
            this.lblDatosLibro.AutoSize = true;
            this.lblDatosLibro.Location = new System.Drawing.Point(21, 22);
            this.lblDatosLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosLibro.Name = "lblDatosLibro";
            this.lblDatosLibro.Size = new System.Drawing.Size(81, 17);
            this.lblDatosLibro.TabIndex = 110;
            this.lblDatosLibro.Text = "Datos Libro";
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.Location = new System.Drawing.Point(29, 454);
            this.lblDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(177, 17);
            this.lblDisponibles.TabIndex = 133;
            this.lblDisponibles.Text = "Disponibles para préstamo";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Location = new System.Drawing.Point(29, 407);
            this.lblInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(70, 17);
            this.lblInventario.TabIndex = 132;
            this.lblInventario.Text = "Inventario";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(29, 352);
            this.lblTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(44, 17);
            this.lblTema.TabIndex = 131;
            this.lblTema.Text = "Tema";
            // 
            // txtInventario
            // 
            this.txtInventario.Enabled = false;
            this.txtInventario.Location = new System.Drawing.Point(240, 407);
            this.txtInventario.Margin = new System.Windows.Forms.Padding(4);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.ReadOnly = true;
            this.txtInventario.Size = new System.Drawing.Size(55, 22);
            this.txtInventario.TabIndex = 129;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(29, 247);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(33, 17);
            this.lblAño.TabIndex = 127;
            this.lblAño.Text = "Año";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(77, 245);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(49, 22);
            this.txtAno.TabIndex = 126;
            // 
            // cmbTema
            // 
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(131, 349);
            this.cmbTema.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(252, 24);
            this.cmbTema.TabIndex = 134;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(143, 247);
            this.lblEdicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(54, 17);
            this.lblEdicion.TabIndex = 123;
            this.lblEdicion.Text = "Edición";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(205, 245);
            this.txtEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(49, 22);
            this.txtEdicion.TabIndex = 135;
            // 
            // txtDisponibles
            // 
            this.txtDisponibles.Enabled = false;
            this.txtDisponibles.Location = new System.Drawing.Point(240, 454);
            this.txtDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisponibles.Name = "txtDisponibles";
            this.txtDisponibles.ReadOnly = true;
            this.txtDisponibles.Size = new System.Drawing.Size(55, 22);
            this.txtDisponibles.TabIndex = 136;
            // 
            // txtCantidadAAgregar
            // 
            this.txtCantidadAAgregar.Location = new System.Drawing.Point(240, 499);
            this.txtCantidadAAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadAAgregar.Name = "txtCantidadAAgregar";
            this.txtCantidadAAgregar.Size = new System.Drawing.Size(55, 22);
            this.txtCantidadAAgregar.TabIndex = 138;
            // 
            // lblCantidadAAgregar
            // 
            this.lblCantidadAAgregar.AutoSize = true;
            this.lblCantidadAAgregar.Location = new System.Drawing.Point(29, 499);
            this.lblCantidadAAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadAAgregar.Name = "lblCantidadAAgregar";
            this.lblCantidadAAgregar.Size = new System.Drawing.Size(203, 17);
            this.lblCantidadAAgregar.TabIndex = 137;
            this.lblCantidadAAgregar.Text = "Cantidad ejemplares a agregar";
            // 
            // btnVerEjemplares
            // 
            this.btnVerEjemplares.Location = new System.Drawing.Point(296, 559);
            this.btnVerEjemplares.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerEjemplares.Name = "btnVerEjemplares";
            this.btnVerEjemplares.Size = new System.Drawing.Size(243, 57);
            this.btnVerEjemplares.TabIndex = 143;
            this.btnVerEjemplares.Text = "Ver ejemplares";
            this.btnVerEjemplares.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(560, 559);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(225, 57);
            this.btnLimpiarCampos.TabIndex = 144;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // lstEjemplares
            // 
            this.lstEjemplares.FormattingEnabled = true;
            this.lstEjemplares.ItemHeight = 16;
            this.lstEjemplares.Location = new System.Drawing.Point(1046, 78);
            this.lstEjemplares.Margin = new System.Windows.Forms.Padding(4);
            this.lstEjemplares.Name = "lstEjemplares";
            this.lstEjemplares.Size = new System.Drawing.Size(496, 468);
            this.lstEjemplares.TabIndex = 146;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(1043, 43);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 147;
            this.lblCodigo.Text = "Código:";
            // 
            // btnComprimir
            // 
            this.btnComprimir.Location = new System.Drawing.Point(1046, 559);
            this.btnComprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprimir.Name = "btnComprimir";
            this.btnComprimir.Size = new System.Drawing.Size(60, 57);
            this.btnComprimir.TabIndex = 148;
            this.btnComprimir.Text = "<<";
            this.btnComprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(477, 71);
            this.btnBuscarLibro.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(71, 25);
            this.btnBuscarLibro.TabIndex = 142;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(99, 68);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(252, 22);
            this.txtCodigoCliente.TabIndex = 107;
            // 
            // lblCodigoCl
            // 
            this.lblCodigoCl.AutoSize = true;
            this.lblCodigoCl.Location = new System.Drawing.Point(29, 68);
            this.lblCodigoCl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoCl.Name = "lblCodigoCl";
            this.lblCodigoCl.Size = new System.Drawing.Size(39, 17);
            this.lblCodigoCl.TabIndex = 111;
            this.lblCodigoCl.Text = "ISBN";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(99, 152);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(252, 22);
            this.txtAutor.TabIndex = 141;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(28, 107);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 17);
            this.lblTitulo.TabIndex = 112;
            this.lblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(99, 107);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(252, 22);
            this.txtTitulo.TabIndex = 139;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(28, 152);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(42, 17);
            this.lblAutor.TabIndex = 113;
            this.lblAutor.Text = "Autor";
            // 
            // gbBuscarLibros
            // 
            this.gbBuscarLibros.Controls.Add(this.txtBuscarAutor);
            this.gbBuscarLibros.Controls.Add(this.txtBuscarTítulo);
            this.gbBuscarLibros.Controls.Add(this.lblBuscarAutor);
            this.gbBuscarLibros.Controls.Add(this.lblBuscarTítulo);
            this.gbBuscarLibros.Controls.Add(this.txtBuscarISBN);
            this.gbBuscarLibros.Controls.Add(this.lblBuscarISBN);
            this.gbBuscarLibros.Controls.Add(this.btnBuscarLibro);
            this.gbBuscarLibros.Location = new System.Drawing.Point(433, 12);
            this.gbBuscarLibros.Name = "gbBuscarLibros";
            this.gbBuscarLibros.Size = new System.Drawing.Size(596, 107);
            this.gbBuscarLibros.TabIndex = 145;
            this.gbBuscarLibros.TabStop = false;
            this.gbBuscarLibros.Text = "Buscar";
            // 
            // txtBuscarAutor
            // 
            this.txtBuscarAutor.Location = new System.Drawing.Point(334, 28);
            this.txtBuscarAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarAutor.Name = "txtBuscarAutor";
            this.txtBuscarAutor.Size = new System.Drawing.Size(214, 22);
            this.txtBuscarAutor.TabIndex = 148;
            // 
            // txtBuscarTítulo
            // 
            this.txtBuscarTítulo.Location = new System.Drawing.Point(62, 28);
            this.txtBuscarTítulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarTítulo.Name = "txtBuscarTítulo";
            this.txtBuscarTítulo.Size = new System.Drawing.Size(214, 22);
            this.txtBuscarTítulo.TabIndex = 147;
            // 
            // lblBuscarAutor
            // 
            this.lblBuscarAutor.AutoSize = true;
            this.lblBuscarAutor.Location = new System.Drawing.Point(284, 31);
            this.lblBuscarAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarAutor.Name = "lblBuscarAutor";
            this.lblBuscarAutor.Size = new System.Drawing.Size(42, 17);
            this.lblBuscarAutor.TabIndex = 146;
            this.lblBuscarAutor.Text = "Autor";
            // 
            // lblBuscarTítulo
            // 
            this.lblBuscarTítulo.AutoSize = true;
            this.lblBuscarTítulo.Location = new System.Drawing.Point(11, 28);
            this.lblBuscarTítulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarTítulo.Name = "lblBuscarTítulo";
            this.lblBuscarTítulo.Size = new System.Drawing.Size(43, 17);
            this.lblBuscarTítulo.TabIndex = 145;
            this.lblBuscarTítulo.Text = "Título";
            // 
            // txtBuscarISBN
            // 
            this.txtBuscarISBN.Location = new System.Drawing.Point(62, 75);
            this.txtBuscarISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarISBN.Name = "txtBuscarISBN";
            this.txtBuscarISBN.Size = new System.Drawing.Size(214, 22);
            this.txtBuscarISBN.TabIndex = 144;
            // 
            // lblBuscarISBN
            // 
            this.lblBuscarISBN.AutoSize = true;
            this.lblBuscarISBN.Location = new System.Drawing.Point(11, 75);
            this.lblBuscarISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarISBN.Name = "lblBuscarISBN";
            this.lblBuscarISBN.Size = new System.Drawing.Size(39, 17);
            this.lblBuscarISBN.TabIndex = 143;
            this.lblBuscarISBN.Text = "ISBN";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AllowUserToResizeRows = false;
            this.dgvLibros.AutoGenerateColumns = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.edicionDataGridViewTextBoxColumn,
            this.editorialDataGridViewTextBoxColumn,
            this.cantPaginasDataGridViewTextBoxColumn,
            this.temaDataGridViewTextBoxColumn,
            this.stockPermanenteDataGridViewTextBoxColumn,
            this.stockDisponibleDataGridViewTextBoxColumn});
            this.dgvLibros.DataSource = this.libroBindingSource;
            this.dgvLibros.Location = new System.Drawing.Point(433, 126);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(596, 420);
            this.dgvLibros.TabIndex = 149;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
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
            // edicionDataGridViewTextBoxColumn
            // 
            this.edicionDataGridViewTextBoxColumn.DataPropertyName = "Edicion";
            this.edicionDataGridViewTextBoxColumn.HeaderText = "Edicion";
            this.edicionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edicionDataGridViewTextBoxColumn.Name = "edicionDataGridViewTextBoxColumn";
            this.edicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editorialDataGridViewTextBoxColumn
            // 
            this.editorialDataGridViewTextBoxColumn.DataPropertyName = "Editorial";
            this.editorialDataGridViewTextBoxColumn.HeaderText = "Editorial";
            this.editorialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editorialDataGridViewTextBoxColumn.Name = "editorialDataGridViewTextBoxColumn";
            this.editorialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantPaginasDataGridViewTextBoxColumn
            // 
            this.cantPaginasDataGridViewTextBoxColumn.DataPropertyName = "CantPaginas";
            this.cantPaginasDataGridViewTextBoxColumn.HeaderText = "CantPaginas";
            this.cantPaginasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantPaginasDataGridViewTextBoxColumn.Name = "cantPaginasDataGridViewTextBoxColumn";
            this.cantPaginasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temaDataGridViewTextBoxColumn
            // 
            this.temaDataGridViewTextBoxColumn.DataPropertyName = "Tema";
            this.temaDataGridViewTextBoxColumn.HeaderText = "Tema";
            this.temaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temaDataGridViewTextBoxColumn.Name = "temaDataGridViewTextBoxColumn";
            this.temaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockPermanenteDataGridViewTextBoxColumn
            // 
            this.stockPermanenteDataGridViewTextBoxColumn.DataPropertyName = "StockPermanente";
            this.stockPermanenteDataGridViewTextBoxColumn.HeaderText = "StockPermanente";
            this.stockPermanenteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockPermanenteDataGridViewTextBoxColumn.Name = "stockPermanenteDataGridViewTextBoxColumn";
            this.stockPermanenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDisponibleDataGridViewTextBoxColumn
            // 
            this.stockDisponibleDataGridViewTextBoxColumn.DataPropertyName = "StockDisponible";
            this.stockDisponibleDataGridViewTextBoxColumn.HeaderText = "StockDisponible";
            this.stockDisponibleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDisponibleDataGridViewTextBoxColumn.Name = "stockDisponibleDataGridViewTextBoxColumn";
            this.stockDisponibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(Entidades.Libro);
            // 
            // sa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 633);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.btnComprimir);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstEjemplares);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.lblCodigoCl);
            this.Controls.Add(this.btnVerEjemplares);
            this.Controls.Add(this.txtCantidadAAgregar);
            this.Controls.Add(this.lblCantidadAAgregar);
            this.Controls.Add(this.txtDisponibles);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.lblDisponibles);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblCantidadPáginas);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btbAlta);
            this.Controls.Add(this.lblDatosLibro);
            this.Controls.Add(this.gbBuscarLibros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sa";
            this.Text = "Gestionar libros";
            this.gbBuscarLibros.ResumeLayout(false);
            this.gbBuscarLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadPáginas;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btbAlta;
        private System.Windows.Forms.Label lblDatosLibro;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.TextBox txtDisponibles;
        private System.Windows.Forms.TextBox txtCantidadAAgregar;
        private System.Windows.Forms.Label lblCantidadAAgregar;
        private System.Windows.Forms.Button btnVerEjemplares;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ListBox lstEjemplares;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnComprimir;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblCodigoCl;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.GroupBox gbBuscarLibros;
        private System.Windows.Forms.TextBox txtBuscarAutor;
        private System.Windows.Forms.TextBox txtBuscarTítulo;
        private System.Windows.Forms.Label lblBuscarAutor;
        private System.Windows.Forms.Label lblBuscarTítulo;
        private System.Windows.Forms.TextBox txtBuscarISBN;
        private System.Windows.Forms.Label lblBuscarISBN;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPaginasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPermanenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDisponibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource libroBindingSource;
    }
}