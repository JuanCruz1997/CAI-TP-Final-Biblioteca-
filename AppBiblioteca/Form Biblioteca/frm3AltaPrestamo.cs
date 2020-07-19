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
    public partial class frm3AltaPrestamo : Form
    {
        private ServicioPrestamo _servicioPrestamo;
        public frm3AltaPrestamo(ServicioPrestamo sp)
        {
            _servicioPrestamo = sp;
            InitializeComponent();
        }

        public void ValidarCampos()
        {
            throw new NotImplementedException();
        }

        public void LimpiarCampos()
        {
            throw new NotImplementedException();
        }

        public void CompletarFormulario(string objeto)
        {
            if(objeto == "cliente")
            {
                //logica foreach donde txtcliente sea el codigo de cliente y complete nombre y apellido
                throw new NotImplementedException();
            } else if (objeto == "ejemplar")
            {
                //logica foreach donde txtejemplar sea el codigo de ejemplar y complete titulo y autor
                throw new NotImplementedException();
            }
        }

        public void FormatearCampos(string condicion)
        {
            if(condicion == "vacio")
            {
                btnConfirmarNuevoPrestamo.Enabled = false;
            } else if (condicion == "completo")
            {
                btnConfirmarNuevoPrestamo.Enabled = true;
            }
        }



        public void CompletarCodigo(string id, Form form)
        {
            if (form is frm2Clientes)
            {
                txtCodigoCliente.Text = id;
            }
            else if (form is frm2Libros)
            {
                txtCodigoEjemplar.Text = id;
            }
        }

        private void frm3AltaPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void btnTraerEjemplares_Click(object sender, EventArgs e)
        {
            frm2Libros f = new frm2Libros(new ServicioLibro(), new ServicioEjemplar());
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnTraerClientes_Click(object sender, EventArgs e)
        {
            frm2Clientes f = new frm2Clientes(new ServicioCliente());
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnActualizarDatosEjemplar_Click(object sender, EventArgs e)
        {
            CompletarFormulario("ejemplar");
        }

        private void btnActualizarDatosCliente_Click(object sender, EventArgs e)
        {
            CompletarFormulario("cliente");

        }
    }
}
