namespace Form_Biblioteca
{
    partial class frm3Ejemplares
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btbAceptar = new System.Windows.Forms.Button();
            this.lstEjemplares = new System.Windows.Forms.ListBox();
            this.lblTDatositulo = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtCodigoEjemplar = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(216, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 46);
            this.btnSalir.TabIndex = 120;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btbAceptar
            // 
            this.btbAceptar.Location = new System.Drawing.Point(12, 383);
            this.btbAceptar.Name = "btbAceptar";
            this.btbAceptar.Size = new System.Drawing.Size(182, 46);
            this.btbAceptar.TabIndex = 119;
            this.btbAceptar.Text = "Aceptar";
            this.btbAceptar.UseVisualStyleBackColor = true;
            // 
            // lstEjemplares
            // 
            this.lstEjemplares.FormattingEnabled = true;
            this.lstEjemplares.Location = new System.Drawing.Point(12, 86);
            this.lstEjemplares.Name = "lstEjemplares";
            this.lstEjemplares.Size = new System.Drawing.Size(373, 238);
            this.lstEjemplares.TabIndex = 118;
            // 
            // lblTDatositulo
            // 
            this.lblTDatositulo.AutoSize = true;
            this.lblTDatositulo.Location = new System.Drawing.Point(17, 21);
            this.lblTDatositulo.Name = "lblTDatositulo";
            this.lblTDatositulo.Size = new System.Drawing.Size(79, 13);
            this.lblTDatositulo.TabIndex = 121;
            this.lblTDatositulo.Text = "Titulo a asignar";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(17, 54);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(78, 13);
            this.lblISBN.TabIndex = 122;
            this.lblISBN.Text = "ISBN a asignar";
            // 
            // txtCodigoEjemplar
            // 
            this.txtCodigoEjemplar.Enabled = false;
            this.txtCodigoEjemplar.Location = new System.Drawing.Point(70, 349);
            this.txtCodigoEjemplar.Name = "txtCodigoEjemplar";
            this.txtCodigoEjemplar.Size = new System.Drawing.Size(42, 20);
            this.txtCodigoEjemplar.TabIndex = 140;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 352);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 139;
            this.lblCodigo.Text = "Código";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(166, 352);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(56, 13);
            this.lblDisponible.TabIndex = 138;
            this.lblDisponible.Text = "Disponible";
            // 
            // frm3Ejemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 456);
            this.Controls.Add(this.txtCodigoEjemplar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblTDatositulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btbAceptar);
            this.Controls.Add(this.lstEjemplares);
            this.Name = "frm3Ejemplares";
            this.Text = "Ejemplares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btbAceptar;
        private System.Windows.Forms.ListBox lstEjemplares;
        private System.Windows.Forms.Label lblTDatositulo;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtCodigoEjemplar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDisponible;
    }
}