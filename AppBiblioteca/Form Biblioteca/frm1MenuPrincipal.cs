using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Form_Biblioteca
{
    public partial class frm1MenuPrincipal : Form
    {
        private Master m;
        public frm1MenuPrincipal(Master m)
        {
            this.m = m;
            InitializeComponent();
        }

        private void Tab()
        {
            btnPrestamos.TabIndex = 0;
            btnLibro.TabIndex = 1;
            btnCliente.TabIndex = 2;
            btnSalir.TabIndex = 3;
        }

        private void frm1MenuPrincipal_Load(object sender, EventArgs e)
        {
            Tab();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frm2GestionarPrestamo f = new frm2GestionarPrestamo(m);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            frm2Libros f = new frm2Libros(m);
            f.Owner = this;
            f.Size = new Size(800, f.Size.Height);
            f.Show();
            this.Hide();
        }

        
        private void btnCliente_Click(object sender, EventArgs e)
        {
            frm2Clientes f = new frm2Clientes(m);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm1MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {                
                this.Dispose();
            }
        }

        private void frm1MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

       
       
    }
}
