﻿using System;
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
    public partial class frm2Libros : Form
    {
        private ServicioLibro _servicioLibro;
        private ServicioEjemplar _servicioEjemplar;
        private ServicioPrestamo _servicioPrestamo;

        private const string libro = "libro";
        private const string ejemplar = "ejemplar";
        private const string menu = "menu";
        private const string prestamo = "prestamo";
        private const string seleccion = "seleccion";
        
        public frm2Libros(ServicioLibro sl, ServicioEjemplar se, ServicioPrestamo sp)
        {
            this._servicioLibro = sl;
            this._servicioEjemplar = se;
            this._servicioPrestamo = sp;
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
            gbBuscarLibros.TabIndex = 0;
            txtBuscarTitulo.TabIndex = 0;
            txtBuscarAutor.TabIndex = 1;
            btnBuscarLibro.TabIndex = 2;
            txtTitulo.TabIndex = 3;
            gbDatosLibro.TabIndex = 3;
            txtAutor.TabIndex = 4;
            txtEdicion.TabIndex = 5;
            txtPaginas.TabIndex = 6;
            txtEditorial.TabIndex = 7;
            cmbTema.TabIndex = 8;
            btnTraerEjemplar.TabIndex = 9;
            btnAltaLibro.TabIndex = 10;
            btnVerEjemplares.TabIndex = 12;            
            btnLimpiarCampos.TabIndex = 13;
            btnSalir.TabIndex = 14;
            dgvLibros.TabIndex = 15;
            txtCantidadAAgregar.TabIndex = 16;
            btnAgregarCantidad.TabIndex = 17;
            gbEjemplares.TabIndex = 18;
            txtPrecio.TabIndex = 19;
            txtObservaciones.TabIndex = 20;
            btnModificar.TabIndex = 21;
            lstEjemplares.TabIndex = 22;

        }
        private void ValidarCampos(string objeto)
        {
            if(objeto == libro)
            {
                txtTitulo.Text = Validaciones.StringValidation(txtTitulo.Text, lblTitulo.Text);
                txtAutor.Text = Validaciones.StringValidation(txtAutor.Text, lblAutor.Text);
                txtEditorial.Text = Validaciones.StringValidation(txtEditorial.Text, lblEditorial.Text);
                txtEdicion.Text = Validaciones.IntValidation(txtEdicion.Text, 0, 999999999, lblEdicion.Text).ToString();
                txtPaginas.Text = Validaciones.IntValidation(txtPaginas.Text, 0, 999999999, lblCantidadPaginas.Text).ToString();
            } else if (objeto ==ejemplar)
            {

                if (!string.IsNullOrEmpty(txtObservaciones.Text))
                {
                    txtCantidadAAgregar.Text = Validaciones.IntValidation(txtCantidadAAgregar.Text, 0, int.MaxValue, lblCantidadAAgregar.Text).ToString();
                    txtPrecio.Text = Validaciones.DoubleValidation(txtPrecio.Text, 0, double.MaxValue, lblPrecio.Text).ToString();
                    txtISBN.Text = Validaciones.IntValidation(txtISBN.Text, 0, int.MaxValue, lblISBN.Text).ToString();
                    txtObservaciones.Text = Validaciones.StringValidation(txtObservaciones.Text, lblObservaciones.Text);
                }
                else
                {
                    throw new Exception("El campo "+ lblObservaciones.Text + "no puede estar vacío");
                }
                
            }
            
        }

        private void LimpiarCampos(string objeto)
        {
            if(objeto == libro)
            {
                dgvLibros.CurrentCell = null;

                txtISBN.Text = string.Empty;
                txtTitulo.Text = string.Empty;
                txtAutor.Text = string.Empty;
                txtEdicion.Text = string.Empty;
                txtPaginas.Text = string.Empty;
                txtEditorial.Text = string.Empty;
                txtInventario.Text = string.Empty;
                txtDisponibles.Text = string.Empty;
                txtBuscarTitulo.Text = string.Empty;
                txtBuscarAutor.Text = string.Empty;

            } else if (objeto == ejemplar)
            {
                lstEjemplares.SelectedIndex = -1;

                txtCantidadAAgregar.Text = string.Empty;
                txtPrecio.Text = string.Empty;
                txtObservaciones.Text = string.Empty;
            }     
                        
        }
        private void CargarComboTemas()
        {
            cmbTema.DataSource = ListaTemas();
        }
        private void FormatearCampos(string condicion)
        {
            if (condicion == prestamo)
            {
                this.Text = "Seleccionar libro";

                txtTitulo.Enabled = false;
                txtAutor.Enabled = false;
                txtEdicion.Enabled = false;
                txtEditorial.Enabled = false;
                txtPaginas.Enabled = false;
                cmbTema.Enabled = false;
                txtPrecio.Enabled = false;
                txtObservaciones.Enabled = false;

                txtTitulo.ReadOnly = true;
                txtAutor.ReadOnly = true;
                txtEdicion.ReadOnly = true;
                txtEditorial.ReadOnly = true;
                txtPaginas.ReadOnly = true;
                txtPrecio.ReadOnly = true;
                txtObservaciones.ReadOnly = true;

                btnAltaLibro.Enabled = false;
                btnAltaLibro.Visible = false;

                btnModificar.Enabled = false;
                btnVerEjemplares.Enabled = false;

                btnTraerEjemplar.Enabled = false;

                lblCantidadAAgregar.Visible = false;
                txtCantidadAAgregar.Visible = false;
                btnAgregarCantidad.Visible = false;
                
                lblCantidadAAgregar.Enabled = false;
                txtCantidadAAgregar.Enabled = false;
                btnAgregarCantidad.Enabled = false;
                txtPrecio.Enabled = false;
                txtObservaciones.Enabled = false;
                btnModificar.Enabled = false;
                btnComprimir.Enabled = false;
                
            }
            else if (condicion == menu)
            {
                this.Text = "Gestionar libros";

                txtTitulo.Enabled = true;
                txtAutor.Enabled = true;
                txtEdicion.Enabled = true;
                txtEditorial.Enabled = true;
                txtPaginas.Enabled = true;
                cmbTema.Enabled = true;

                txtTitulo.ReadOnly = false;
                txtAutor.ReadOnly = false;
                txtEdicion.ReadOnly = false;
                txtEditorial.ReadOnly = false;
                txtPaginas.ReadOnly = false;

                btnAltaLibro.Enabled = true;
                btnModificar.Enabled = false;
                btnVerEjemplares.Enabled = false;

                btnTraerEjemplar.Enabled = false;
                btnTraerEjemplar.Visible = false;
            }
            else if (condicion == seleccion && this.Owner is frm1MenuPrincipal)
            {
                btnAltaLibro.Enabled = false;
                btnModificar.Enabled = true;
                btnVerEjemplares.Enabled = true;

                lblCantidadAAgregar.Enabled = true;
                txtCantidadAAgregar.Enabled = true;
                btnAgregarCantidad.Enabled = true;
                txtPrecio.Enabled = true;
                txtObservaciones.Enabled = true;
                btnModificar.Enabled = true;
                lstEjemplares.Enabled = true;
                btnComprimir.Enabled = true;

                txtTitulo.Enabled = false;
                txtAutor.Enabled = false;
                txtEdicion.Enabled = false;
                txtEditorial.Enabled = false;
                txtPaginas.Enabled = false;
                cmbTema.Enabled = false;

            }
            else if (condicion == seleccion && this.Owner is frm2GestionarPrestamo)
            {
               
                btnVerEjemplares.Enabled = true;

                lblCantidadAAgregar.Enabled = true;
                txtCantidadAAgregar.Enabled = true;
                btnAgregarCantidad.Enabled = true;
                txtPrecio.Enabled = true;
                txtObservaciones.Enabled = true;
                btnModificar.Enabled = true;
                lstEjemplares.Enabled = true;
                btnComprimir.Enabled = true;

                txtTitulo.Enabled = false;
                txtAutor.Enabled = false;
                txtEdicion.Enabled = false;
                txtEditorial.Enabled = false;
                txtPaginas.Enabled = false;
                cmbTema.Enabled = false;

            }
            else if (condicion == ejemplar && this.Owner is frm2GestionarPrestamo)
            {
                btnTraerEjemplar.Enabled = true;
            }
            
            
        }

        private void CompletarFormularioLibro(Libro seleccionado)
        {
            txtISBN.Text = seleccionado.ISBN.ToString();
            txtTitulo.Text = seleccionado.Titulo;
            txtAutor.Text = seleccionado.Autor;
            txtEdicion.Text = seleccionado.Edicion.ToString();
            txtPaginas.Text = seleccionado.CantPaginas.ToString();
            txtEditorial.Text = seleccionado.Editorial;
            txtInventario.Text = seleccionado.StockPermanente.ToString();
            txtDisponibles.Text = seleccionado.StockDisponible.ToString();
            foreach(String s in ListaTemas())
            {
                if (s == seleccionado.Tema)
                {
                    cmbTema.Text = seleccionado.Tema;
                    break;
                }
                else
                {
                    cmbTema.Text = "Varios";
                }
            }
            LimpiarCampos(ejemplar);
        }
        private void CargarDGVLibros(List<Libro> libros)
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libros;
            
        }

        private void CargarListaEjemplares(Libro seleccionado)
        {
            List<Ejemplar> lista = this._servicioEjemplar.TraerPorLibro(seleccionado.ISBN);
            this._servicioEjemplar.AsignarDisponibilidad(lista, _servicioPrestamo);
            this._servicioEjemplar.CalcularStock(lista, seleccionado);
            lstEjemplares.DataSource = null;
            lstEjemplares.DataSource = lista;
            lstEjemplares.SelectedIndex = -1;
        }
        private List<String> ListaTemas()
        {
            List<String> temas = new List<String>();
            
            temas.Add("Romántico");
            temas.Add("Misterio");
            temas.Add("Terror");
            temas.Add("Interés general");
            temas.Add("Divulgación");
            temas.Add("Cocina");
            temas.Add("Historia");
            temas.Add("Psicología");
            temas.Add("Informática");
            temas.Add("Derecho");
            temas.Add("Matemática");
            temas.Add("Fantasía");
            temas.Add("Ficción");
            temas.Add("Policial");
            temas.Add("Suspenso");
            temas.Add("Varios");
            temas.Sort();
            temas.Insert(0, "--Seleccione una opción--");
            return temas;
        }
        private void CompletarFormularioEjemplar(Ejemplar seleccionado)
        {
            txtPrecio.Text = seleccionado.Precio.ToString();
            txtObservaciones.Text = seleccionado.Descripcion;
        }

        private void CloseWindow()
        {
            this.Owner.Show();
            this.Dispose();
        }
        #endregion
        #region "Eventos"

        private void frm2Libros_Load(object sender, EventArgs e)
        {
            Tab();
            CargarDGVLibros(this._servicioLibro.TraerTodos());
            CargarComboTemas();
            LimpiarCampos(libro);
            if (this.Owner is frm1MenuPrincipal)
            {
                FormatearCampos(menu);
            }
            else if (this.Owner is frm2GestionarPrestamo || this.Owner is frm3AltaPrestamo)
            {
                FormatearCampos(prestamo);
            }

        }

        private void frm2Libros_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageOkCancel("Se borrarán los datos que no hayan sido guardados. Para continuar presione Ok", this.Text))
            {
                CloseWindow();
            }
        }

        private void frm2Libros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageOkCancel("Se borrarán los datos que no hayan sido guardados. Para continuar presione Ok", this.Text))
                {
                    CloseWindow();
                }
            }
        }

    


        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarTitulo.Text == string.Empty && txtBuscarAutor.Text == string.Empty)
                {
                    CargarDGVLibros(this._servicioLibro.TraerTodos());
                    MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.");
                    
                }
                else
                {
                    CargarDGVLibros(this._servicioLibro.BuscarLibro(Validaciones.StringValidation(txtBuscarTitulo.Text, lblBuscarTitulo.Text), Validaciones.StringValidation(txtBuscarAutor.Text, lblBuscarAutor.Text)));
                }
                LimpiarCampos(libro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvLibros.CurrentRow;
            Libro seleccionado = row.DataBoundItem as Libro;
            if (seleccionado != null)
            {
                CompletarFormularioLibro(seleccionado);
                CargarListaEjemplares(seleccionado);
                FormatearCampos(seleccion);
                LimpiarCampos(ejemplar);
            }
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvLibros.CurrentRow;
            Libro seleccionado = row.DataBoundItem as Libro;
            if (seleccionado != null)
            {
                this.Size = new Size(1125, this.Size.Height);
                List<Ejemplar> lista = this._servicioEjemplar.TraerPorLibro(seleccionado.ISBN);
                this._servicioEjemplar.AsignarDisponibilidad(lista, _servicioPrestamo);
                this._servicioEjemplar.CalcularStock(lista, seleccionado);
                CompletarFormularioLibro(seleccionado);
                CargarListaEjemplares(seleccionado);
                FormatearCampos(seleccion);
                LimpiarCampos(ejemplar);
            }
        }

        

        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos(libro);
                int codigo = this._servicioLibro.AltaLibro(txtTitulo.Text,txtAutor.Text,Convert.ToInt32(txtEdicion.Text),txtEditorial.Text,Convert.ToInt32(txtPaginas.Text),cmbTema.Text);
                MessageBox.Show("Alta de libro exitosa. ID libro nuevo: " + codigo + "\nPor favor, agregue la cantidad de ejemplares");
                CargarDGVLibros(_servicioLibro.TraerPorCodigo(codigo));                
                DataGridViewRow row = dgvLibros.Rows[0];
                row.Selected = true;
                Libro seleccionado = row.DataBoundItem as Libro;
                CompletarFormularioLibro(seleccionado);
                this.Size = new Size(1125, this.Size.Height);
                gbEjemplares.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTraerEjemplar_Click(object sender, EventArgs e)
        {
            Ejemplar ejemplar = (Ejemplar)lstEjemplares.SelectedItem;
            if (lstEjemplares.SelectedIndex == -1)
            {
                MessageBox.Show("Elija un ejemplar");
            }
            else if (this.Owner is frm2GestionarPrestamo)
            {
                ((frm2GestionarPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);
                this.Owner.Show();
                this.Dispose();
            }
            else if (this.Owner is frm3AltaPrestamo)
            {
                ((frm3AltaPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);
                ((frm3AltaPrestamo)this.Owner).CompletarFormulario("ejemplar");
                this.Owner.Show();
                this.Dispose();
            }
        }

        private void btnVerEjemplares_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvLibros.CurrentRow;
            Libro seleccionado = row.DataBoundItem as Libro;
            if (seleccionado != null)
            {
                this.Size = new Size(1125, this.Size.Height);
                CompletarFormularioLibro(seleccionado);
                CargarListaEjemplares(seleccionado);
                FormatearCampos(seleccion);
                LimpiarCampos(ejemplar);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos(libro);
            LimpiarCampos(ejemplar);
            CargarDGVLibros(_servicioLibro.TraerTodos());
            this.Size = new Size(800, this.Size.Height);
            LimpiarCampos(libro);
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageOkCancel("Se borrarán los datos que no hayan sido guardados. Para continuar presione Ok", this.Text))
            {
                CloseWindow();
            }
        }
        
        private void lstEjemplares_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Ejemplar seleccionado = (Ejemplar)lstEjemplares.SelectedItem;
            
            if (seleccionado != null)
            {
                CompletarFormularioEjemplar(seleccionado);
            }
        }

        private void lstEjemplares_DoubleClick(object sender, EventArgs e)
        {
            Ejemplar ejemplar = (Ejemplar)lstEjemplares.SelectedItem;
            if (lstEjemplares.SelectedIndex == -1)
            {
                MessageBox.Show("Elija un ejemplar");
            }
            else if (this.Owner is frm2GestionarPrestamo)
            {
                ((frm2GestionarPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);

                CloseWindow();
            }
            else if (this.Owner is frm3AltaPrestamo)
            {
                ((frm3AltaPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);
                ((frm3AltaPrestamo)this.Owner).CompletarFormulario("ejemplar");

                CloseWindow();
            }
        }

        private void btnAgregarCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos(ejemplar);
                string codigos = _servicioEjemplar.AltaMultiplesEjemplares(Convert.ToInt32(txtCantidadAAgregar.Text), Convert.ToInt32(txtISBN.Text), Convert.ToDouble(txtPrecio.Text));
                MessageBox.Show("Se han creado los ejemplares con los códigos:\n" + codigos);
                //Modularizar
                DataGridViewRow row = dgvLibros.CurrentRow;
                Libro seleccionado = row.DataBoundItem as Libro;
                CompletarFormularioLibro(seleccionado);
                CargarListaEjemplares(seleccionado);
                FormatearCampos(seleccion);
                LimpiarCampos(ejemplar);
                gbEjemplares.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text == string.Empty)
            {
                MessageBox.Show("Para modificar la descripción de un ejemplar, antes debe seleccionarlo.");
            }
            else
            {
                try
                {
                    
                    ValidarCampos(ejemplar);
                    Ejemplar ej = (Ejemplar)lstEjemplares.SelectedItem;
                    int codigo = this._servicioEjemplar.ModificarEjemplar(ej.Codigo, Convert.ToDouble(txtPrecio.Text), txtObservaciones.Text);
                    MessageBox.Show("El ejemplar " + codigo + " se ha modificado exitosamente");
                    //Modularizar
                    DataGridViewRow row = dgvLibros.CurrentRow;
                    Libro seleccionado = row.DataBoundItem as Libro;
                    CompletarFormularioLibro(seleccionado);
                    CargarListaEjemplares(seleccionado);
                    FormatearCampos(seleccion);
                    LimpiarCampos(ejemplar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnComprimir_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, this.Size.Height);
        }
                                    
        #endregion


    }
}
