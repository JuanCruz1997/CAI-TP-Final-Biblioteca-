﻿namespace Form_Biblioteca
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
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Location = new System.Drawing.Point(84, 81);
            this.btnPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(235, 294);
            this.btnPrestamos.TabIndex = 0;
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Location = new System.Drawing.Point(415, 81);
            this.btnLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(235, 294);
            this.btnLibro.TabIndex = 1;
            this.btnLibro.Text = "Libros";
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(84, 409);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(913, 39);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(84, 26);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(424, 34);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "¡Bienvenido!\r\nUsted está en el sistema de gestión de la Biblioteca de Springfield" +
    "";
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(763, 81);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(235, 294);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // frm1MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 480);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.btnPrestamos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm1MenuPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frm1MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnCliente;
    }
}

