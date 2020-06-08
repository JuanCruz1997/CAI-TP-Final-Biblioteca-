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
            this.lblCantidadPáginas = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btbAlta = new System.Windows.Forms.Button();
            this.btnBuscarPorCliente = new System.Windows.Forms.Button();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigoCl = new System.Windows.Forms.Label();
            this.lblDatosLibro = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.lblStockPermanente = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.txtStockPermantente = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.txtDisponibilidad = new System.Windows.Forms.TextBox();
            this.txtCantidadAAgregar = new System.Windows.Forms.TextBox();
            this.lblCantidadAAgregar = new System.Windows.Forms.Label();
            this.btnBuscarPorTítulo = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnBuscarPorAutor = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnVerEjemplares = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCantidadPáginas
            // 
            this.lblCantidadPáginas.AutoSize = true;
            this.lblCantidadPáginas.Location = new System.Drawing.Point(334, 159);
            this.lblCantidadPáginas.Name = "lblCantidadPáginas";
            this.lblCantidadPáginas.Size = new System.Drawing.Size(45, 13);
            this.lblCantidadPáginas.TabIndex = 125;
            this.lblCantidadPáginas.Text = "Páginas";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(504, 52);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 124;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(385, 156);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(57, 20);
            this.txtPaginas.TabIndex = 122;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(582, 48);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(190, 20);
            this.txtEditorial.TabIndex = 121;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(604, 489);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 46);
            this.btnSalir.TabIndex = 117;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btbAlta
            // 
            this.btbAlta.Location = new System.Drawing.Point(400, 489);
            this.btbAlta.Name = "btbAlta";
            this.btbAlta.Size = new System.Drawing.Size(182, 46);
            this.btbAlta.TabIndex = 116;
            this.btbAlta.Text = "Alta";
            this.btbAlta.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPorCliente
            // 
            this.btnBuscarPorCliente.Location = new System.Drawing.Point(227, 48);
            this.btnBuscarPorCliente.Name = "btnBuscarPorCliente";
            this.btnBuscarPorCliente.Size = new System.Drawing.Size(53, 20);
            this.btnBuscarPorCliente.TabIndex = 115;
            this.btnBuscarPorCliente.Text = "Buscar";
            this.btnBuscarPorCliente.UseVisualStyleBackColor = true;
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.Location = new System.Drawing.Point(18, 207);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(773, 251);
            this.lstLibros.TabIndex = 114;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(16, 155);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 113;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 102);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 112;
            this.lblTitulo.Text = "Título";
            // 
            // lblCodigoCl
            // 
            this.lblCodigoCl.AutoSize = true;
            this.lblCodigoCl.Location = new System.Drawing.Point(16, 51);
            this.lblCodigoCl.Name = "lblCodigoCl";
            this.lblCodigoCl.Size = new System.Drawing.Size(32, 13);
            this.lblCodigoCl.TabIndex = 111;
            this.lblCodigoCl.Text = "ISBN";
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
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(56, 48);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(165, 20);
            this.txtCodigoCliente.TabIndex = 107;
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(25, 489);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(72, 13);
            this.lblDisponibilidad.TabIndex = 133;
            this.lblDisponibilidad.Text = "Disponibilidad";
            // 
            // lblStockPermanente
            // 
            this.lblStockPermanente.AutoSize = true;
            this.lblStockPermanente.Location = new System.Drawing.Point(25, 522);
            this.lblStockPermanente.Name = "lblStockPermanente";
            this.lblStockPermanente.Size = new System.Drawing.Size(94, 13);
            this.lblStockPermanente.TabIndex = 132;
            this.lblStockPermanente.Text = "Stock permanente";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(504, 102);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(34, 13);
            this.lblTema.TabIndex = 131;
            this.lblTema.Text = "Tema";
            // 
            // txtStockPermantente
            // 
            this.txtStockPermantente.Enabled = false;
            this.txtStockPermantente.Location = new System.Drawing.Point(125, 519);
            this.txtStockPermantente.Name = "txtStockPermantente";
            this.txtStockPermantente.Size = new System.Drawing.Size(42, 20);
            this.txtStockPermantente.TabIndex = 129;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(334, 51);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 127;
            this.lblAño.Text = "Año";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(385, 44);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(57, 20);
            this.txtAno.TabIndex = 126;
            // 
            // cmbTema
            // 
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(582, 102);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(190, 21);
            this.cmbTema.TabIndex = 134;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(334, 102);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(42, 13);
            this.lblEdicion.TabIndex = 123;
            this.lblEdicion.Text = "Edición";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(385, 102);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(57, 20);
            this.txtEdicion.TabIndex = 135;
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Enabled = false;
            this.txtDisponibilidad.Location = new System.Drawing.Point(125, 486);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(42, 20);
            this.txtDisponibilidad.TabIndex = 136;
            // 
            // txtCantidadAAgregar
            // 
            this.txtCantidadAAgregar.Location = new System.Drawing.Point(582, 156);
            this.txtCantidadAAgregar.Name = "txtCantidadAAgregar";
            this.txtCantidadAAgregar.Size = new System.Drawing.Size(67, 20);
            this.txtCantidadAAgregar.TabIndex = 138;
            // 
            // lblCantidadAAgregar
            // 
            this.lblCantidadAAgregar.AutoSize = true;
            this.lblCantidadAAgregar.Location = new System.Drawing.Point(504, 159);
            this.lblCantidadAAgregar.Name = "lblCantidadAAgregar";
            this.lblCantidadAAgregar.Size = new System.Drawing.Size(77, 13);
            this.lblCantidadAAgregar.TabIndex = 137;
            this.lblCantidadAAgregar.Text = "Cant a agregar";
            // 
            // btnBuscarPorTítulo
            // 
            this.btnBuscarPorTítulo.Location = new System.Drawing.Point(227, 103);
            this.btnBuscarPorTítulo.Name = "btnBuscarPorTítulo";
            this.btnBuscarPorTítulo.Size = new System.Drawing.Size(53, 20);
            this.btnBuscarPorTítulo.TabIndex = 140;
            this.btnBuscarPorTítulo.Text = "Buscar";
            this.btnBuscarPorTítulo.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(56, 103);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(165, 20);
            this.txtTitulo.TabIndex = 139;
            // 
            // btnBuscarPorAutor
            // 
            this.btnBuscarPorAutor.Location = new System.Drawing.Point(227, 152);
            this.btnBuscarPorAutor.Name = "btnBuscarPorAutor";
            this.btnBuscarPorAutor.Size = new System.Drawing.Size(53, 20);
            this.btnBuscarPorAutor.TabIndex = 142;
            this.btnBuscarPorAutor.Text = "Buscar";
            this.btnBuscarPorAutor.UseVisualStyleBackColor = true;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(56, 152);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(165, 20);
            this.txtAutor.TabIndex = 141;
            // 
            // btnVerEjemplares
            // 
            this.btnVerEjemplares.Location = new System.Drawing.Point(197, 489);
            this.btnVerEjemplares.Name = "btnVerEjemplares";
            this.btnVerEjemplares.Size = new System.Drawing.Size(182, 46);
            this.btnVerEjemplares.TabIndex = 143;
            this.btnVerEjemplares.Text = "Ver ejemplares";
            this.btnVerEjemplares.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(685, 152);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(88, 28);
            this.btnLimpiarCampos.TabIndex = 144;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // frm2Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 557);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnVerEjemplares);
            this.Controls.Add(this.btnBuscarPorAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnBuscarPorTítulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCantidadAAgregar);
            this.Controls.Add(this.lblCantidadAAgregar);
            this.Controls.Add(this.txtDisponibilidad);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.lblStockPermanente);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.txtStockPermantente);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblCantidadPáginas);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btbAlta);
            this.Controls.Add(this.btnBuscarPorCliente);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigoCl);
            this.Controls.Add(this.lblDatosLibro);
            this.Controls.Add(this.txtCodigoCliente);
            this.Name = "frm2Libros";
            this.Text = "Gestionar libros";
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
        private System.Windows.Forms.Button btnBuscarPorCliente;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoCl;
        private System.Windows.Forms.Label lblDatosLibro;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.Label lblStockPermanente;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.TextBox txtStockPermantente;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.TextBox txtDisponibilidad;
        private System.Windows.Forms.TextBox txtCantidadAAgregar;
        private System.Windows.Forms.Label lblCantidadAAgregar;
        private System.Windows.Forms.Button btnBuscarPorTítulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnBuscarPorAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnVerEjemplares;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}