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
        private Master m;

        private const string ejemplar = "ejemplar";
        private const string cliente = "cliente";
        private const string prestamo = "prestamo";
        private const string vacio = "vacio";
        private const string completo = "completo";
        public frm3AltaPrestamo(Master m)
        {
            this.m = m;
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
        public void CloseWindow()
        {
            Owner.Show();
            Dispose();
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
                if (cmbPlazo.SelectedIndex == 0)
                {
                    throw new Exception("Por favor seleccione el plazo del préstamo");
                }

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
            cmbPlazo.SelectedIndex = 0;
            //dtpFechaAlta.Value = DateTime.Now;
        }

        public void CompletarFormulario(string objeto)
        {
            if(objeto == prestamo)
            {
                
                dtpFechaAlta.Value = DateTime.Today;
                if(cmbPlazo.SelectedIndex == 0)
                {
                    dtpFechaTentativaDevolucion.Value = DateTime.Today;
                }
                else
                {
                     dtpFechaTentativaDevolucion.Value = DateTime.Today.AddDays(Convert.ToDouble(cmbPlazo.Text));
                }
               
            }
            else if(objeto == cliente)
            {
                Cliente c = this.m.SC.TraerPorCodigo(Convert.ToInt32(txtCodigoCliente.Text));
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
                Ejemplar e = this.m.SE.TraerPorCodigo(Convert.ToInt32(txtCodigoEjemplar.Text));                
               
                
                if (e != null)
                {
                    if (e.Disponible)
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
                    throw new Exception("El código de ejemplar ingresado es incorrecto");
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

        private void CargarCmbPlazo()
        {
            List<String> plazos = new List<String>();

            plazos.Add("15");
            plazos.Add("30");
            plazos.Add("45");
            plazos.Add("60");            
            plazos.Add("-15 - TEST");            
            plazos.Sort();
            plazos.Insert(0, "--Seleccione plazo--");

            cmbPlazo.DataSource = plazos;

            cmbPlazo.SelectedIndex = 0;
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
            Tab();
            FormatearCampos(vacio);
            CargarCmbPlazo();
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
            else if (txtCodigoEjemplar.Text == string.Empty)
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
            frm2Libros f = new frm2Libros(m);
            f.Owner = this;
            f.Show();
        }

        private void btnTraerClientes_Click(object sender, EventArgs e)
        {
            frm2Clientes f = new frm2Clientes(m);
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
                int codigo = this.m.SP.AltaPrestamo(Convert.ToInt32(txtCodigoCliente.Text), Convert.ToInt32(txtCodigoEjemplar.Text), Convert.ToInt32(cmbPlazo.Text), Convert.ToDouble(txtPrecio.Text));
                MessageBox.Show("Se ha dado de alta el préstamo " + codigo + " exitosamente");
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
            if(txtCodigoCliente.Text != string.Empty || txtCodigoEjemplar.Text != string.Empty)
            {
                if (MessageOkCancel("Se borrarán los datos que no hayan sido guardados. Para continuar presione Ok", this.Text))
                {
                    CloseWindow();
                }
            }
            else
            {
                CloseWindow();
            }
            
        }

        private void frm3AltaPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (txtCodigoCliente.Text != string.Empty || txtCodigoEjemplar.Text != string.Empty)
            {
                if (MessageOkCancel("Se borrarán los datos que no hayan sido guardados. Para continuar presione Ok", this.Text))
                {
                    CloseWindow();
                }
            }
            else
            {
                CloseWindow();
            }
        }

        private void frm3AltaPrestamo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (txtCodigoCliente.Text != string.Empty || txtCodigoEjemplar.Text != string.Empty)
                {
                    if (MessageOkCancel("Se borrarán los datos que no hayan sido guardados. Para continuar presione Ok", this.Text))
                    {
                        CloseWindow();
                    }
                }
                else
                {
                    CloseWindow();
                }
            }
            
        }
        #endregion

        private void cmbPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPlazo.SelectedIndex != 0)
            {
                CompletarFormulario(prestamo);
            }
        }
    }
}
