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
        private ServicioLibro _servicioLibro;

        private const string ejemplar = "ejemplar";
        private const string cliente = "cliente";
        private const string prestamo = "prestamo";
        private const string vacio = "vacio";
        private const string completo = "completo";
        public frm3AltaPrestamo(ServicioPrestamo sp, ServicioCliente sc, ServicioEjemplar se, ServicioLibro sl)
        {
            this._servicioPrestamo = sp;
            this._servicioCliente = sc;
            this._servicioEjemplar = se;
            this._servicioLibro = sl;
            InitializeComponent();
        }
        #region "Métodos"
        private bool MessageOkCancel(string msg, string tituloForm)
        {

            DialogResult result = MessageBox.Show(msg, tituloForm, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                return true;
            }
            else return false;
        }
        private void Tab()
        {
            gbDatosEjemplar.TabIndex = 0;
            txtCodigoEjemplar.TabIndex = 1;
            btnActualizarDatosEjemplar.TabIndex = 2;
            btnTraerEjemplares.TabIndex = 3;
            gbDatosCliente.TabIndex = 4;
            txtCodigoCliente.TabIndex = 5;
            btnActualizarDatosCliente.TabIndex = 6;
            btnTraerClientes.TabIndex = 7;
            btnConfirmarNuevoPrestamo.TabIndex = 8;
            btnLimpiarCampos.TabIndex = 9;
            btnSalir.TabIndex = 10;
        }
        public void ValidarCampos(string objeto)
        {
            if(objeto == ejemplar)
            {
                txtCodigoEjemplar.Text = Validaciones.IntValidation(txtCodigoEjemplar.Text, 0, int.MaxValue, lblCodigoEj.Text).ToString();

            }
            else if (objeto == cliente)
            {
                txtCodigoCliente.Text = Validaciones.IntValidation(txtCodigoCliente.Text, 0, int.MaxValue, lblCodigoCl.Text).ToString();

            }
            else if(objeto == prestamo)
            {
                txtPlazo.Text = Validaciones.IntValidation(txtPlazo.Text, 0, 365, lblPlazo.Text).ToString();

            }
    
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
            //dtpFechaAlta.Value = DateTime.Now;
        }

        public void CompletarFormulario(string objeto)
        {
            if(objeto == prestamo)
            {
                txtPlazo.Text = "30"; //primera entrega, los préstamos serán de plazo fijo
                dtpFechaAlta.Value = DateTime.Today;
                dtpFechaTentativaDevolucion.Value = DateTime.Today.AddDays(Convert.ToDouble(txtPlazo.Text));
            }
            else if(objeto == cliente)
            {
                Cliente c = this._servicioCliente.TraerPorCodigo(Convert.ToInt32(txtCodigoCliente.Text));
                if (c != null)
                {
                    txtNombreCliente.Text = c.Nombre;
                    txtApellidoCliente.Text = c.Apellido;
                }
                else
                {
                    MessageBox.Show("El código de cliente ingresado es incorrecto");
                }
            } else if (objeto == ejemplar)
            {
                Ejemplar e = this._servicioEjemplar.TraerPorCodigo(Convert.ToInt32(txtCodigoEjemplar.Text));                
               
                
                if (e != null)
                {
                    bool disponible = _servicioEjemplar.AsignarDisponibilidadIndividual(e, _servicioPrestamo);

                    if (disponible)
                    {
                        txtTitulo.Text = e.Libro.Titulo;
                        txtAutor.Text = e.Libro.Autor;
                        txtPrecio.Text = e.Precio.ToString();
                    }
                    else
                    {
                        throw new Exception("El ejemplar se encuentra prestado, por favor elija otro");
                    }
                    
                }
                else
                {
                    MessageBox.Show("El código de ejemplar ingresado es incorrecto");
                }

            }
        }

        public void FormatearCampos(string condicion)
        {
            if (txtCodigoCliente.Text == string.Empty)
            {
                btnActualizarDatosCliente.Enabled = false;
            }
            else
            {
                btnActualizarDatosCliente.Enabled = true;
            }
            if (txtCodigoCliente.Text == string.Empty)
            {
                btnActualizarDatosEjemplar.Enabled = false;
            }
            else
            {
                btnActualizarDatosEjemplar.Enabled = true;
            }
            if (condicion == vacio)
            {
                btnConfirmarNuevoPrestamo.Enabled = false;
            } else if (condicion == completo)
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

        private void CloseWindow()
        {
            this.Owner.Show();
            this.Dispose();
        }
        #endregion
        #region "Eventos"
        private void frm3AltaPrestamo_Load(object sender, EventArgs e)
        {
            Tab();
            FormatearCampos(vacio);
            CompletarFormulario(prestamo);
        }
        private void btnActualizarDatosEjemplar_Click(object sender, EventArgs e)
        {
            try
            {
               ValidarCampos(ejemplar);
               CompletarFormulario(ejemplar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void txtCodigoEjemplar_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != string.Empty && txtCodigoEjemplar.Text != string.Empty)
            {
                FormatearCampos(completo);
            }
            if (txtCodigoEjemplar.Text == string.Empty)
            {
                btnActualizarDatosEjemplar.Enabled = false;
            }
            else
            {
                btnActualizarDatosEjemplar.Enabled = true;
            }
        }

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != string.Empty && txtCodigoEjemplar.Text != string.Empty)
            {
                FormatearCampos(completo);
            }
            if (txtCodigoCliente.Text == string.Empty)
            {
                btnActualizarDatosCliente.Enabled = false;
            }
            else
            {
                btnActualizarDatosCliente.Enabled = true;
            }
        }
        private void btnTraerEjemplares_Click(object sender, EventArgs e)
        {
            frm2Libros f = new frm2Libros(_servicioLibro, _servicioEjemplar, _servicioPrestamo);
            f.Owner = this;
            f.Show();
        }

        private void btnTraerClientes_Click(object sender, EventArgs e)
        {
            frm2Clientes f = new frm2Clientes(new ServicioCliente());
            f.Owner = this;
            f.Show();
        }
              

        private void btnActualizarDatosCliente_Click(object sender, EventArgs e)
        {
            CompletarFormulario(cliente);
        }

        

        private void btnConfirmarNuevoPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos(ejemplar);
                ValidarCampos(cliente);
                ValidarCampos(prestamo);
                int codigo = this._servicioPrestamo.AltaPrestamo(Convert.ToInt32(txtCodigoCliente.Text), Convert.ToInt32(txtCodigoEjemplar.Text), Convert.ToInt32(txtPlazo.Text), Convert.ToDouble(txtPrecio.Text));
                MessageBox.Show("Se ha dado de alta el préstamo " + codigo + " existosamente");
                ((frm2GestionarPrestamo)this.Owner).CargarDGVPrestamos();
                CloseWindow();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageOkCancel("Se borrarán los datos que no hayan sido guardados. Para continuar presione Ok", this.Text))
            {
                CloseWindow();
            }
        }

        private void frm3AltaPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageOkCancel("Se borrarán los datos que no hayan sido guardados. Para continuar presione Ok", this.Text))
            {
                CloseWindow();
            }
        }

        private void frm3AltaPrestamo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageOkCancel("Se borrarán los datos que no hayan sido guardados. Para continuar presione Ok", this.Text))
                {
                    CloseWindow();
                }
            }
        }
        #endregion

    }
}
