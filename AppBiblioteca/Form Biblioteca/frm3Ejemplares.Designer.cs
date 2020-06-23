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
            this.btbAceptar = new System.Windows.Forms.Button();
            this.lstEjemplares = new System.Windows.Forms.ListBox();
            this.lblTDatositulo = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btbAceptar
            // 
            this.btbAceptar.Location = new System.Drawing.Point(16, 482);
            this.btbAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbAceptar.Name = "btbAceptar";
            this.btbAceptar.Size = new System.Drawing.Size(496, 57);
            this.btbAceptar.TabIndex = 119;
            this.btbAceptar.Text = "Aceptar";
            this.btbAceptar.UseVisualStyleBackColor = true;
            // 
            // lstEjemplares
            // 
            this.lstEjemplares.FormattingEnabled = true;
            this.lstEjemplares.ItemHeight = 16;
            this.lstEjemplares.Location = new System.Drawing.Point(16, 139);
            this.lstEjemplares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEjemplares.Name = "lstEjemplares";
            this.lstEjemplares.Size = new System.Drawing.Size(496, 324);
            this.lstEjemplares.TabIndex = 118;
            // 
            // lblTDatositulo
            // 
            this.lblTDatositulo.AutoSize = true;
            this.lblTDatositulo.Location = new System.Drawing.Point(23, 31);
            this.lblTDatositulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTDatositulo.Name = "lblTDatositulo";
            this.lblTDatositulo.Size = new System.Drawing.Size(47, 17);
            this.lblTDatositulo.TabIndex = 121;
            this.lblTDatositulo.Text = "Titulo:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(23, 102);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(43, 17);
            this.lblISBN.TabIndex = 122;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(220, 102);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 139;
            this.lblCodigo.Text = "Código:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(23, 66);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(46, 17);
            this.lblAutor.TabIndex = 141;
            this.lblAutor.Text = "Autor:";
            // 
            // frm3Ejemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 561);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblTDatositulo);
            this.Controls.Add(this.btbAceptar);
            this.Controls.Add(this.lstEjemplares);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm3Ejemplares";
            this.Text = "Ejemplares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btbAceptar;
        private System.Windows.Forms.ListBox lstEjemplares;
        private System.Windows.Forms.Label lblTDatositulo;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblAutor;
    }
}