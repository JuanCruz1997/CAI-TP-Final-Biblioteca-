namespace Form_Biblioteca
{
    partial class frm2Libros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCantidadPaginas = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAltaLibro = new System.Windows.Forms.Button();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.txtDisponibles = new System.Windows.Forms.TextBox();
            this.txtCantidadAAgregar = new System.Windows.Forms.TextBox();
            this.lblCantidadAAgregar = new System.Windows.Forms.Label();
            this.btnVerEjemplares = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lstEjemplares = new System.Windows.Forms.ListBox();
            this.btnComprimir = new System.Windows.Forms.Button();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.gbBuscarLibros = new System.Windows.Forms.GroupBox();
            this.txtBuscarAutor = new System.Windows.Forms.TextBox();
            this.txtBuscarTitulo = new System.Windows.Forms.TextBox();
            this.lblBuscarAutor = new System.Windows.Forms.Label();
            this.lblBuscarTitulo = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPaginasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbDatosLibro = new System.Windows.Forms.GroupBox();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.btnAgregarCantidad = new System.Windows.Forms.Button();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gbEjemplares = new System.Windows.Forms.GroupBox();
            this.btnTraerEjemplar = new System.Windows.Forms.Button();
            this.gbBuscarLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            this.gbDatosLibro.SuspendLayout();
            this.gbStock.SuspendLayout();
            this.gbEjemplares.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCantidadPaginas
            // 
            this.lblCantidadPaginas.AutoSize = true;
            this.lblCantidadPaginas.Location = new System.Drawing.Point(147, 153);
            this.lblCantidadPaginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPaginas.Name = "lblCantidadPaginas";
            this.lblCantidadPaginas.Size = new System.Drawing.Size(59, 17);
            this.lblCantidadPaginas.TabIndex = 125;
            this.lblCantidadPaginas.Text = "Páginas";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(12, 196);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(59, 17);
            this.lblEditorial.TabIndex = 124;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(213, 150);
            this.txtPaginas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(49, 22);
            this.txtPaginas.TabIndex = 122;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(79, 196);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(183, 22);
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAltaLibro
            // 
            this.btnAltaLibro.Location = new System.Drawing.Point(31, 559);
            this.btnAltaLibro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltaLibro.Name = "btnAltaLibro";
            this.btnAltaLibro.Size = new System.Drawing.Size(243, 57);
            this.btnAltaLibro.TabIndex = 116;
            this.btnAltaLibro.Text = "Alta";
            this.btnAltaLibro.UseVisualStyleBackColor = true;
            this.btnAltaLibro.Click += new System.EventHandler(this.btnAltaLibro_Click);
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.Location = new System.Drawing.Point(12, 75);
            this.lblDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(177, 17);
            this.lblDisponibles.TabIndex = 133;
            this.lblDisponibles.Text = "Disponibles para préstamo";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Location = new System.Drawing.Point(12, 34);
            this.lblInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(70, 17);
            this.lblInventario.TabIndex = 132;
            this.lblInventario.Text = "Inventario";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(12, 236);
            this.lblTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(44, 17);
            this.lblTema.TabIndex = 131;
            this.lblTema.Text = "Tema";
            // 
            // txtInventario
            // 
            this.txtInventario.Enabled = false;
            this.txtInventario.Location = new System.Drawing.Point(228, 32);
            this.txtInventario.Margin = new System.Windows.Forms.Padding(4);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.ReadOnly = true;
            this.txtInventario.Size = new System.Drawing.Size(55, 22);
            this.txtInventario.TabIndex = 129;
            // 
            // cmbTema
            // 
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(79, 233);
            this.cmbTema.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(183, 24);
            this.cmbTema.TabIndex = 134;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(12, 153);
            this.lblEdicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(54, 17);
            this.lblEdicion.TabIndex = 123;
            this.lblEdicion.Text = "Edición";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(79, 150);
            this.txtEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(49, 22);
            this.txtEdicion.TabIndex = 135;
            // 
            // txtDisponibles
            // 
            this.txtDisponibles.Enabled = false;
            this.txtDisponibles.Location = new System.Drawing.Point(228, 71);
            this.txtDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisponibles.Name = "txtDisponibles";
            this.txtDisponibles.ReadOnly = true;
            this.txtDisponibles.Size = new System.Drawing.Size(55, 22);
            this.txtDisponibles.TabIndex = 136;
            // 
            // txtCantidadAAgregar
            // 
            this.txtCantidadAAgregar.Location = new System.Drawing.Point(1253, 12);
            this.txtCantidadAAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadAAgregar.Name = "txtCantidadAAgregar";
            this.txtCantidadAAgregar.Size = new System.Drawing.Size(55, 22);
            this.txtCantidadAAgregar.TabIndex = 138;
            // 
            // lblCantidadAAgregar
            // 
            this.lblCantidadAAgregar.AutoSize = true;
            this.lblCantidadAAgregar.Location = new System.Drawing.Point(1043, 12);
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
            this.btnVerEjemplares.Click += new System.EventHandler(this.btnVerEjemplares_Click);
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
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lstEjemplares
            // 
            this.lstEjemplares.FormattingEnabled = true;
            this.lstEjemplares.ItemHeight = 16;
            this.lstEjemplares.Location = new System.Drawing.Point(1045, 142);
            this.lstEjemplares.Margin = new System.Windows.Forms.Padding(4);
            this.lstEjemplares.Name = "lstEjemplares";
            this.lstEjemplares.Size = new System.Drawing.Size(409, 404);
            this.lstEjemplares.TabIndex = 146;
            this.lstEjemplares.SelectedIndexChanged += new System.EventHandler(this.lstEjemplares_SelectedIndexChanged);
            this.lstEjemplares.DoubleClick += new System.EventHandler(this.lstEjemplares_DoubleClick);
            // 
            // btnComprimir
            // 
            this.btnComprimir.Location = new System.Drawing.Point(1045, 559);
            this.btnComprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprimir.Name = "btnComprimir";
            this.btnComprimir.Size = new System.Drawing.Size(60, 57);
            this.btnComprimir.TabIndex = 148;
            this.btnComprimir.Text = "<<";
            this.btnComprimir.UseVisualStyleBackColor = true;
            this.btnComprimir.Click += new System.EventHandler(this.btnComprimir_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(633, 25);
            this.btnBuscarLibro.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(71, 32);
            this.btnBuscarLibro.TabIndex = 142;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(79, 34);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(183, 22);
            this.txtISBN.TabIndex = 107;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(12, 37);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(39, 17);
            this.lblISBN.TabIndex = 111;
            this.lblISBN.Text = "ISBN";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(79, 107);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(183, 22);
            this.txtAutor.TabIndex = 141;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(11, 74);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 17);
            this.lblTitulo.TabIndex = 112;
            this.lblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(79, 71);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(183, 22);
            this.txtTitulo.TabIndex = 139;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 110);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(42, 17);
            this.lblAutor.TabIndex = 113;
            this.lblAutor.Text = "Autor";
            // 
            // gbBuscarLibros
            // 
            this.gbBuscarLibros.Controls.Add(this.txtBuscarAutor);
            this.gbBuscarLibros.Controls.Add(this.txtBuscarTitulo);
            this.gbBuscarLibros.Controls.Add(this.lblBuscarAutor);
            this.gbBuscarLibros.Controls.Add(this.lblBuscarTitulo);
            this.gbBuscarLibros.Controls.Add(this.btnBuscarLibro);
            this.gbBuscarLibros.Location = new System.Drawing.Point(317, 12);
            this.gbBuscarLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBuscarLibros.Name = "gbBuscarLibros";
            this.gbBuscarLibros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBuscarLibros.Size = new System.Drawing.Size(711, 68);
            this.gbBuscarLibros.TabIndex = 145;
            this.gbBuscarLibros.TabStop = false;
            this.gbBuscarLibros.Text = "Buscar";
            this.gbBuscarLibros.Enter += new System.EventHandler(this.gbBuscarLibros_Enter);
            // 
            // txtBuscarAutor
            // 
            this.txtBuscarAutor.Location = new System.Drawing.Point(355, 28);
            this.txtBuscarAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarAutor.Name = "txtBuscarAutor";
            this.txtBuscarAutor.Size = new System.Drawing.Size(201, 22);
            this.txtBuscarAutor.TabIndex = 148;
            // 
            // txtBuscarTitulo
            // 
            this.txtBuscarTitulo.Location = new System.Drawing.Point(61, 28);
            this.txtBuscarTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarTitulo.Name = "txtBuscarTitulo";
            this.txtBuscarTitulo.Size = new System.Drawing.Size(201, 22);
            this.txtBuscarTitulo.TabIndex = 147;
            // 
            // lblBuscarAutor
            // 
            this.lblBuscarAutor.AutoSize = true;
            this.lblBuscarAutor.Location = new System.Drawing.Point(305, 28);
            this.lblBuscarAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarAutor.Name = "lblBuscarAutor";
            this.lblBuscarAutor.Size = new System.Drawing.Size(42, 17);
            this.lblBuscarAutor.TabIndex = 146;
            this.lblBuscarAutor.Text = "Autor";
            // 
            // lblBuscarTitulo
            // 
            this.lblBuscarTitulo.AutoSize = true;
            this.lblBuscarTitulo.Location = new System.Drawing.Point(11, 28);
            this.lblBuscarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarTitulo.Name = "lblBuscarTitulo";
            this.lblBuscarTitulo.Size = new System.Drawing.Size(43, 17);
            this.lblBuscarTitulo.TabIndex = 145;
            this.lblBuscarTitulo.Text = "Título";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AllowUserToResizeRows = false;
            this.dgvLibros.AutoGenerateColumns = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.edicionDataGridViewTextBoxColumn,
            this.editorialDataGridViewTextBoxColumn,
            this.cantPaginasDataGridViewTextBoxColumn,
            this.temaDataGridViewTextBoxColumn});
            this.dgvLibros.DataSource = this.libroBindingSource;
            this.dgvLibros.Location = new System.Drawing.Point(317, 86);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(711, 460);
            this.dgvLibros.TabIndex = 149;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellClick);
            this.dgvLibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellDoubleClick);
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSBNDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.cantPaginasDataGridViewTextBoxColumn.HeaderText = "Páginas";
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
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(Entidades.Libro);
            // 
            // gbDatosLibro
            // 
            this.gbDatosLibro.Controls.Add(this.lblISBN);
            this.gbDatosLibro.Controls.Add(this.txtISBN);
            this.gbDatosLibro.Controls.Add(this.txtAutor);
            this.gbDatosLibro.Controls.Add(this.lblTitulo);
            this.gbDatosLibro.Controls.Add(this.lblAutor);
            this.gbDatosLibro.Controls.Add(this.txtTitulo);
            this.gbDatosLibro.Controls.Add(this.txtEdicion);
            this.gbDatosLibro.Controls.Add(this.lblEdicion);
            this.gbDatosLibro.Controls.Add(this.cmbTema);
            this.gbDatosLibro.Controls.Add(this.lblCantidadPaginas);
            this.gbDatosLibro.Controls.Add(this.txtPaginas);
            this.gbDatosLibro.Controls.Add(this.lblEditorial);
            this.gbDatosLibro.Controls.Add(this.lblTema);
            this.gbDatosLibro.Controls.Add(this.txtEditorial);
            this.gbDatosLibro.Location = new System.Drawing.Point(12, 12);
            this.gbDatosLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosLibro.Name = "gbDatosLibro";
            this.gbDatosLibro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatosLibro.Size = new System.Drawing.Size(300, 274);
            this.gbDatosLibro.TabIndex = 150;
            this.gbDatosLibro.TabStop = false;
            this.gbDatosLibro.Text = "Datos libro";
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.lblInventario);
            this.gbStock.Controls.Add(this.lblDisponibles);
            this.gbStock.Controls.Add(this.txtInventario);
            this.gbStock.Controls.Add(this.txtDisponibles);
            this.gbStock.Location = new System.Drawing.Point(12, 436);
            this.gbStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStock.Name = "gbStock";
            this.gbStock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStock.Size = new System.Drawing.Size(300, 110);
            this.gbStock.TabIndex = 151;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "Datos stock";
            // 
            // btnAgregarCantidad
            // 
            this.btnAgregarCantidad.Location = new System.Drawing.Point(1329, 9);
            this.btnAgregarCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCantidad.Name = "btnAgregarCantidad";
            this.btnAgregarCantidad.Size = new System.Drawing.Size(110, 28);
            this.btnAgregarCantidad.TabIndex = 152;
            this.btnAgregarCantidad.Text = "Agregar";
            this.btnAgregarCantidad.UseVisualStyleBackColor = true;
            this.btnAgregarCantidad.Click += new System.EventHandler(this.btnAgregarCantidad_Click);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(7, 59);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(103, 17);
            this.lblObservaciones.TabIndex = 153;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(117, 59);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(145, 22);
            this.txtObservaciones.TabIndex = 154;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(269, 23);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 58);
            this.btnModificar.TabIndex = 155;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 23);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 156;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(117, 23);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(145, 22);
            this.txtPrecio.TabIndex = 157;
            // 
            // gbEjemplares
            // 
            this.gbEjemplares.Controls.Add(this.btnModificar);
            this.gbEjemplares.Controls.Add(this.txtPrecio);
            this.gbEjemplares.Controls.Add(this.txtObservaciones);
            this.gbEjemplares.Controls.Add(this.lblPrecio);
            this.gbEjemplares.Controls.Add(this.lblObservaciones);
            this.gbEjemplares.Location = new System.Drawing.Point(1045, 39);
            this.gbEjemplares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEjemplares.Name = "gbEjemplares";
            this.gbEjemplares.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEjemplares.Size = new System.Drawing.Size(400, 98);
            this.gbEjemplares.TabIndex = 158;
            this.gbEjemplares.TabStop = false;
            this.gbEjemplares.Text = "Datos ejemplar";
            // 
            // btnTraerEjemplar
            // 
            this.btnTraerEjemplar.Location = new System.Drawing.Point(31, 559);
            this.btnTraerEjemplar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraerEjemplar.Name = "btnTraerEjemplar";
            this.btnTraerEjemplar.Size = new System.Drawing.Size(243, 57);
            this.btnTraerEjemplar.TabIndex = 159;
            this.btnTraerEjemplar.Text = "Aceptar";
            this.btnTraerEjemplar.UseVisualStyleBackColor = true;
            this.btnTraerEjemplar.Click += new System.EventHandler(this.btnTraerEjemplar_Click);
            // 
            // frm2Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 633);
            this.Controls.Add(this.btnTraerEjemplar);
            this.Controls.Add(this.btnAgregarCantidad);
            this.Controls.Add(this.gbDatosLibro);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.lblCantidadAAgregar);
            this.Controls.Add(this.txtCantidadAAgregar);
            this.Controls.Add(this.btnComprimir);
            this.Controls.Add(this.lstEjemplares);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnVerEjemplares);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAltaLibro);
            this.Controls.Add(this.gbBuscarLibros);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.gbEjemplares);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm2Libros";
            this.Text = "Gestionar libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm2Libros_FormClosed);
            this.Load += new System.EventHandler(this.frm2Libros_Load);
            this.gbBuscarLibros.ResumeLayout(false);
            this.gbBuscarLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            this.gbDatosLibro.ResumeLayout(false);
            this.gbDatosLibro.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            this.gbEjemplares.ResumeLayout(false);
            this.gbEjemplares.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadPaginas;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAltaLibro;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.TextBox txtDisponibles;
        private System.Windows.Forms.TextBox txtCantidadAAgregar;
        private System.Windows.Forms.Label lblCantidadAAgregar;
        private System.Windows.Forms.Button btnVerEjemplares;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ListBox lstEjemplares;
        private System.Windows.Forms.Button btnComprimir;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.GroupBox gbBuscarLibros;
        private System.Windows.Forms.TextBox txtBuscarAutor;
        private System.Windows.Forms.TextBox txtBuscarTitulo;
        private System.Windows.Forms.Label lblBuscarAutor;
        private System.Windows.Forms.Label lblBuscarTitulo;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private System.Windows.Forms.GroupBox gbDatosLibro;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.Button btnAgregarCantidad;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox gbEjemplares;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPaginasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTraerEjemplar;
    }
}