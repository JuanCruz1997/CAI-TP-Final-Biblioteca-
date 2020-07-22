namespace Form_Biblioteca
{
    partial class frm1MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1MenuPrincipal));
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pbBienvenida = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBienvenida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("btnPrestamos.Image")));
            this.btnPrestamos.Location = new System.Drawing.Point(420, 58);
            this.btnPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(300, 300);
            this.btnPrestamos.TabIndex = 0;
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.Black;
            this.btnLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnLibro.Image")));
            this.btnLibro.Location = new System.Drawing.Point(735, 58);
            this.btnLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(300, 300);
            this.btnLibro.TabIndex = 1;
            this.btnLibro.Text = "Libros";
            this.btnLibro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(420, 376);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(930, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(9, 19);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(942, 29);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "¡Bienvenido! Usted está en el sistema de gestión de la Biblioteca de Springfield";
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(1050, 58);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(300, 300);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pbBienvenida
            // 
            this.pbBienvenida.Image = ((System.Drawing.Image)(resources.GetObject("pbBienvenida.Image")));
            this.pbBienvenida.Location = new System.Drawing.Point(13, 58);
            this.pbBienvenida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBienvenida.Name = "pbBienvenida";
            this.pbBienvenida.Size = new System.Drawing.Size(387, 364);
            this.pbBienvenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBienvenida.TabIndex = 4;
            this.pbBienvenida.TabStop = false;
            // 
            // frm1MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 450);
            this.Controls.Add(this.pbBienvenida);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.btnPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frm1MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm1MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frm1MenuPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm1MenuPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBienvenida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.PictureBox pbBienvenida;
    }
}

