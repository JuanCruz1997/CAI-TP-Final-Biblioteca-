namespace Form_Biblioteca
{
    partial class txtTelefono
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btbAlta = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoCl = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnBuscarNombreCliente = new System.Windows.Forms.Button();
            this.btnBuscarApellidoCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(323, 607);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(243, 57);
            this.btnModificar.TabIndex = 100;
            this.btnModificar.Text = "Guardar cambios";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(607, 607);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(243, 57);
            this.btnEliminar.TabIndex = 99;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(896, 607);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(225, 57);
            this.btnSalir.TabIndex = 96;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btbAlta
            // 
            this.btbAlta.Location = new System.Drawing.Point(44, 607);
            this.btbAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbAlta.Name = "btbAlta";
            this.btbAlta.Size = new System.Drawing.Size(243, 57);
            this.btbAlta.TabIndex = 95;
            this.btbAlta.Text = "Alta";
            this.btbAlta.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(284, 121);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(71, 25);
            this.btnBuscarCliente.TabIndex = 93;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(468, 48);
            this.lstClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(635, 516);
            this.lstClientes.TabIndex = 88;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(40, 257);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 80;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 169);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 79;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigoCl
            // 
            this.lblCodigoCl.AutoSize = true;
            this.lblCodigoCl.Location = new System.Drawing.Point(40, 89);
            this.lblCodigoCl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoCl.Name = "lblCodigoCl";
            this.lblCodigoCl.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoCl.TabIndex = 78;
            this.lblCodigoCl.Text = "Código";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Location = new System.Drawing.Point(40, 48);
            this.lblDatosCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(92, 17);
            this.lblDatosCliente.TabIndex = 77;
            this.lblDatosCliente.Text = "Datos Cliente";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(53, 290);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(221, 22);
            this.txtApellidoCliente.TabIndex = 76;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(53, 203);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(221, 22);
            this.txtNombreCliente.TabIndex = 75;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(53, 121);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(221, 22);
            this.txtCodigoCliente.TabIndex = 74;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(40, 521);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 17);
            this.lblMail.TabIndex = 106;
            this.lblMail.Text = "Mail";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(40, 432);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 105;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(40, 338);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 104;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(53, 554);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(221, 22);
            this.txtMail.TabIndex = 103;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 466);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 22);
            this.textBox2.TabIndex = 102;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(53, 370);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(221, 22);
            this.txtDireccion.TabIndex = 101;
            // 
            // btnBuscarNombreCliente
            // 
            this.btnBuscarNombreCliente.Location = new System.Drawing.Point(284, 203);
            this.btnBuscarNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarNombreCliente.Name = "btnBuscarNombreCliente";
            this.btnBuscarNombreCliente.Size = new System.Drawing.Size(71, 25);
            this.btnBuscarNombreCliente.TabIndex = 107;
            this.btnBuscarNombreCliente.Text = "Buscar";
            this.btnBuscarNombreCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarApellidoCliente
            // 
            this.btnBuscarApellidoCliente.Location = new System.Drawing.Point(284, 290);
            this.btnBuscarApellidoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarApellidoCliente.Name = "btnBuscarApellidoCliente";
            this.btnBuscarApellidoCliente.Size = new System.Drawing.Size(71, 25);
            this.btnBuscarApellidoCliente.TabIndex = 108;
            this.btnBuscarApellidoCliente.Text = "Buscar";
            this.btnBuscarApellidoCliente.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 703);
            this.Controls.Add(this.btnBuscarApellidoCliente);
            this.Controls.Add(this.btnBuscarNombreCliente);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btbAlta);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoCl);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "txtTelefono";
            this.Text = "Gestionar clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btbAlta;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoCl;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnBuscarNombreCliente;
        private System.Windows.Forms.Button btnBuscarApellidoCliente;
    }
}