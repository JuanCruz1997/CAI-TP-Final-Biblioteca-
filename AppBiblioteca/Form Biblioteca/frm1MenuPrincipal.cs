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

namespace Form_Biblioteca
{
    public partial class frm1MenuPrincipal : Form
    {
        public frm1MenuPrincipal()
        {
            InitializeComponent();
        }

        private void frm1MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frm2Clientes f = new frm2Clientes(new ServicioCliente());
            f.Owner = this;
            f.Show();
            this.Hide();
        }
    }
}
