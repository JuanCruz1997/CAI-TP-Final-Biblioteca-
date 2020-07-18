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
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCodigo = new System.Windows.Forms.Label();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPaginasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadPáginas
            // 
            this.lblCantidadPáginas.AutoSize = true;
            this.lblCantidadPáginas.Location = new System.Drawing.Point(200, 201);
            this.lblCantidadPáginas.Name = "lblCantidadPáginas";
            this.lblCantidadPáginas.Size = new System.Drawing.Size(45, 13);
            this.lblCantidadPáginas.TabIndex = 125;
            this.lblCantidadPáginas.Text = "Páginas";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(22, 242);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 124;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(250, 199);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(38, 20);
            this.txtPaginas.TabIndex = 122;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(98, 242);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(190, 20);
            this.txtEditorial.TabIndex = 121;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(603, 454);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 46);
            this.btnSalir.TabIndex = 117;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btbAlta
            // 
            this.btbAlta.Location = new System.Drawing.Point(23, 454);
            this.btbAlta.Name = "btbAlta";
            this.btbAlta.Size = new System.Drawing.Size(182, 46);
            this.btbAlta.TabIndex = 116;
            this.btbAlta.Text = "Alta";
            this.btbAlta.UseVisualStyleBackColor = true;
            // 
            // lblDatosLibro
            // 
            this.lblDatosLibro.AutoSize = true;
            this.lblDatosLibro.Location = new System.Drawing.Point(16, 18);
            this.lblDatosLibro.Name = "lblDatosLibro";
            this.lblDatosLibro.Size = new System.Drawing.Size(61, 13);
            this.lblDatosLibro.TabIndex = 110;
            this.lblDatosLibro.Text = "Datos Libro";
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.Location = new System.Drawing.Point(22, 369);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(131, 13);
            this.lblDisponibles.TabIndex = 133;
            this.lblDisponibles.Text = "Disponibles para préstamo";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Location = new System.Drawing.Point(22, 331);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(54, 13);
            this.lblInventario.TabIndex = 132;
            this.lblInventario.Text = "Inventario";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(22, 286);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(34, 13);
            this.lblTema.TabIndex = 131;
            this.lblTema.Text = "Tema";
            // 
            // txtInventario
            // 
            this.txtInventario.Enabled = false;
            this.txtInventario.Location = new System.Drawing.Point(180, 331);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.ReadOnly = true;
            this.txtInventario.Size = new System.Drawing.Size(42, 20);
            this.txtInventario.TabIndex = 129;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(22, 201);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 127;
            this.lblAño.Text = "Año";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(58, 199);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(38, 20);
            this.txtAno.TabIndex = 126;
            // 
            // cmbTema
            // 
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(98, 284);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(190, 21);
            this.cmbTema.TabIndex = 134;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(107, 201);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(42, 13);
            this.lblEdicion.TabIndex = 123;
            this.lblEdicion.Text = "Edición";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(154, 199);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(38, 20);
            this.txtEdicion.TabIndex = 135;
            // 
            // txtDisponibles
            // 
            this.txtDisponibles.Enabled = false;
            this.txtDisponibles.Location = new System.Drawing.Point(180, 369);
            this.txtDisponibles.Name = "txtDisponibles";
            this.txtDisponibles.ReadOnly = true;
            this.txtDisponibles.Size = new System.Drawing.Size(42, 20);
            this.txtDisponibles.TabIndex = 136;
            // 
            // txtCantidadAAgregar
            // 
            this.txtCantidadAAgregar.Location = new System.Drawing.Point(180, 405);
            this.txtCantidadAAgregar.Name = "txtCantidadAAgregar";
            this.txtCantidadAAgregar.Size = new System.Drawing.Size(42, 20);
            this.txtCantidadAAgregar.TabIndex = 138;
            // 
            // lblCantidadAAgregar
            // 
            this.lblCantidadAAgregar.AutoSize = true;
            this.lblCantidadAAgregar.Location = new System.Drawing.Point(22, 405);
            this.lblCantidadAAgregar.Name = "lblCantidadAAgregar";
            this.lblCantidadAAgregar.Size = new System.Drawing.Size(150, 13);
            this.lblCantidadAAgregar.TabIndex = 137;
            this.lblCantidadAAgregar.Text = "Cantidad ejemplares a agregar";
            // 
            // btnVerEjemplares
            // 
            this.btnVerEjemplares.Location = new System.Drawing.Point(222, 454);
            this.btnVerEjemplares.Name = "btnVerEjemplares";
            this.btnVerEjemplares.Size = new System.Drawing.Size(182, 46);
            this.btnVerEjemplares.TabIndex = 143;
            this.btnVerEjemplares.Text = "Ver ejemplares";
            this.btnVerEjemplares.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(420, 454);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(169, 46);
            this.btnLimpiarCampos.TabIndex = 144;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // lstEjemplares
            // 
            this.lstEjemplares.FormattingEnabled = true;
            this.lstEjemplares.Location = new System.Drawing.Point(784, 63);
            this.lstEjemplares.Name = "lstEjemplares";
            this.lstEjemplares.Size = new System.Drawing.Size(373, 381);
            this.lstEjemplares.TabIndex = 146;
            // 
            // btnComprimir
            // 
            this.btnComprimir.Location = new System.Drawing.Point(784, 454);
            this.btnComprimir.Name = "btnComprimir";
            this.btnComprimir.Size = new System.Drawing.Size(45, 46);
            this.btnComprimir.TabIndex = 148;
            this.btnComprimir.Text = "<<";
            this.btnComprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(358, 58);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(53, 20);
            this.btnBuscarLibro.TabIndex = 142;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(74, 55);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(190, 20);
            this.txtCodigoCliente.TabIndex = 107;
            // 
            // lblCodigoCl
            // 
            this.lblCodigoCl.AutoSize = true;
            this.lblCodigoCl.Location = new System.Drawing.Point(22, 55);
            this.lblCodigoCl.Name = "lblCodigoCl";
            this.lblCodigoCl.Size = new System.Drawing.Size(32, 13);
            this.lblCodigoCl.TabIndex = 111;
            this.lblCodigoCl.Text = "ISBN";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(74, 124);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(190, 20);
            this.txtAutor.TabIndex = 141;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 87);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 112;
            this.lblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(74, 87);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(190, 20);
            this.txtTitulo.TabIndex = 139;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(21, 124);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
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
            this.gbBuscarLibros.Location = new System.Drawing.Point(325, 10);
            this.gbBuscarLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBuscarLibros.Name = "gbBuscarLibros";
            this.gbBuscarLibros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBuscarLibros.Size = new System.Drawing.Size(447, 87);
            this.gbBuscarLibros.TabIndex = 145;
            this.gbBuscarLibros.TabStop = false;
            this.gbBuscarLibros.Text = "Buscar";
            // 
            // txtBuscarAutor
            // 
            this.txtBuscarAutor.Location = new System.Drawing.Point(250, 23);
            this.txtBuscarAutor.Name = "txtBuscarAutor";
            this.txtBuscarAutor.Size = new System.Drawing.Size(162, 20);
            this.txtBuscarAutor.TabIndex = 148;
            // 
            // txtBuscarTítulo
            // 
            this.txtBuscarTítulo.Location = new System.Drawing.Point(46, 23);
            this.txtBuscarTítulo.Name = "txtBuscarTítulo";
            this.txtBuscarTítulo.Size = new System.Drawing.Size(162, 20);
            this.txtBuscarTítulo.TabIndex = 147;
            // 
            // lblBuscarAutor
            // 
            this.lblBuscarAutor.AutoSize = true;
            this.lblBuscarAutor.Location = new System.Drawing.Point(213, 25);
            this.lblBuscarAutor.Name = "lblBuscarAutor";
            this.lblBuscarAutor.Size = new System.Drawing.Size(32, 13);
            this.lblBuscarAutor.TabIndex = 146;
            this.lblBuscarAutor.Text = "Autor";
            // 
            // lblBuscarTítulo
            // 
            this.lblBuscarTítulo.AutoSize = true;
            this.lblBuscarTítulo.Location = new System.Drawing.Point(8, 23);
            this.lblBuscarTítulo.Name = "lblBuscarTítulo";
            this.lblBuscarTítulo.Size = new System.Drawing.Size(35, 13);
            this.lblBuscarTítulo.TabIndex = 145;
            this.lblBuscarTítulo.Text = "Título";
            // 
            // txtBuscarISBN
            // 
            this.txtBuscarISBN.Location = new System.Drawing.Point(46, 61);
            this.txtBuscarISBN.Name = "txtBuscarISBN";
            this.txtBuscarISBN.Size = new System.Drawing.Size(162, 20);
            this.txtBuscarISBN.TabIndex = 144;
            // 
            // lblBuscarISBN
            // 
            this.lblBuscarISBN.AutoSize = true;
            this.lblBuscarISBN.Location = new System.Drawing.Point(8, 61);
            this.lblBuscarISBN.Name = "lblBuscarISBN";
            this.lblBuscarISBN.Size = new System.Drawing.Size(32, 13);
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
            this.temaDataGridViewTextBoxColumn});
            this.dgvLibros.DataSource = this.libroBindingSource;
            this.dgvLibros.Location = new System.Drawing.Point(325, 102);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(447, 341);
            this.dgvLibros.TabIndex = 149;
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(Entidades.Libro);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(782, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(136, 13);
            this.lblCodigo.TabIndex = 147;
            this.lblCodigo.Text = "Completarme con codigo??";
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
            // frm2Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 514);
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
            this.Name = "frm2Libros";
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
        private System.Windows.Forms.BindingSource libroBindingSource;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPaginasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaDataGridViewTextBoxColumn;
    }
}