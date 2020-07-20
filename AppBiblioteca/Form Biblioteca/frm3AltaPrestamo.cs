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
        private ServicioCliente _servicioCliente;
        private ServicioEjemplar _servicioEjemplar;
        public frm3AltaPrestamo(ServicioPrestamo sp, ServicioCliente sc, ServicioEjemplar se)
        {
            this._servicioPrestamo = sp;
            this._servicioCliente = sc;
            this._servicioEjemplar = se;
            InitializeComponent();
        }
        #region "Métodos"
        public void ValidarCampos()
        {
            txtCodigoCliente.Text = Validaciones.IntValidation(txtCodigoCliente.Text, 0, int.MaxValue, lblCodigoCl.Text).ToString();
            txtNombreCliente.Text = Validaciones.StringValidation(txtNombreCliente.Text, lblNombre.Text);
            txtApellidoCliente.Text = Validaciones.StringValidation(txtApellidoCliente.Text, lblApellido.Text);
            txtCodigoEjemplar.Text = Validaciones.IntValidation(txtCodigoEjemplar.Text, 0, int.MaxValue, lblCodigoEj.Text).ToString();
            txtTitulo.Text = Validaciones.StringValidation(txtTitulo.Text, lblTitulo.Text);
            txtAutor.Text = Validaciones.StringValidation(txtAutor.Text, lblAutor.Text);
        }

        public void LimpiarCampos()
        {
            txtCodigoEjemplar.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtCodigoCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;
            dtpFechaAlta.Value = DateTime.Now;
            dtpFechaAlta.Value = DateTime.Now;
        }

        public void CompletarFormulario(string objeto)
        {
            if(objeto == "cliente")
            {
                Cliente c = this._servicioCliente.TraerPorCodigo(Convert.ToInt32(txtCodigoCliente.Text));
                if (c != null)
                {
                    txtNombreCliente.Text = c.Nombre;
                    txtApellidoCliente.Text = c.Apellido;
                }
                else
                {
                    MessageBox.Show("El código de cliente ingresado es incorrecto, o bien el cliente no existe.");
                }
            } else if (objeto == "ejemplar")
            {
                Ejemplar e = this._servicioEjemplar.TraerPorCodigo(Convert.ToInt32(txtCodigoEjemplar.Text));
                if (e != null)
                {
                    txtTitulo.Text = e.Libro.Titulo;
                    txtAutor.Text = e.Libro.Autor;
                }
                else
                {
                    MessageBox.Show("El código de ejemplar ingresado es incorrecto, o bien el ejemplar no existe.");
                }
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
        #endregion
        #region "Eventos"
        private void frm3AltaPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void btnTraerEjemplares_Click(object sender, EventArgs e)
        {
            frm2Libros f = new frm2Libros(new ServicioLibro(), new ServicioEjemplar());
            f.Owner = this;
            f.Show();
        }

        private void btnTraerClientes_Click(object sender, EventArgs e)
        {
            frm2Clientes f = new frm2Clientes(new ServicioCliente());
            f.Owner = this;
            f.Show();
        }

        private void btnActualizarDatosEjemplar_Click(object sender, EventArgs e)
        {
            CompletarFormulario("ejemplar");
        }

        private void btnActualizarDatosCliente_Click(object sender, EventArgs e)
        {
            CompletarFormulario("cliente");
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirmarNuevoPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();
                int codigo = this._servicioPrestamo.AltaPrestamo(Convert.ToInt32(txtCodigoCliente.Text), Convert.ToInt32(txtCodigoEjemplar.Text), Convert.ToInt32(dtpFechaTentativaDevolucion.Value - dtpFechaAlta.Value));
                MessageBox.Show("Se ha dado de alta el préstamo existosamente.\nCódigo operación: " + codigo);
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm3AltaPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
        #endregion
    }
}
