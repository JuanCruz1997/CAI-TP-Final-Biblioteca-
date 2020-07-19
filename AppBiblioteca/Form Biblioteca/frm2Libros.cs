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
    public partial class frm2Libros : Form
    {
        private ServicioLibro _servicioLibro;
        private ServicioEjemplar _servicioEjemplar;
        public frm2Libros(ServicioLibro sl, ServicioEjemplar se)
        {
            this._servicioLibro = sl;
            this._servicioEjemplar = se;
            InitializeComponent();
        }


        private void ValidarCampos(string objeto)
        {
            if(objeto == "libro")
            {
                txtTitulo.Text = Validaciones.StringValidation(txtTitulo.Text, lblTitulo.Text);
                txtAutor.Text = Validaciones.StringValidation(txtAutor.Text, lblAutor.Text);
                txtEditorial.Text = Validaciones.StringValidation(txtEditorial.Text, lblEditorial.Text);
                txtEdicion.Text = Validaciones.IntValidation(txtEdicion.Text, 0, 999999999, lblEdicion.Text).ToString();
                txtPaginas.Text = Validaciones.IntValidation(txtPaginas.Text, 0, 999999999, lblCantidadPaginas.Text).ToString();
            } else if (objeto =="ejemplar")
            {
                txtCantidadAAgregar.Text = Validaciones.IntValidation(txtCantidadAAgregar.Text, 0, int.MaxValue, lblCantidadAAgregar.Text).ToString();
                txtPrecio.Text = Validaciones.DoubleValidation(txtPrecio.Text, 0, double.MaxValue, lblPrecio.Text).ToString();
                txtISBN.Text = Validaciones.IntValidation(txtISBN.Text, 0, int.MaxValue, lblISBN.Text).ToString();
            }
            
        }

        private void LimpiarCampos()
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
        }
        private void CargarComboTemas()
        {
            cmbTema.DataSource = ListaTemas();
        }
        private void FormatearCampos(string condicion)
        {
            if (condicion == "prestamo")
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
                
            }
            else if (condicion == "menu")
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
            else if (condicion == "seleccionado" && this.Owner is frm1MenuPrincipal)
            {
                btnAltaLibro.Enabled = false;
                btnModificar.Enabled = true;
                btnVerEjemplares.Enabled = true;
                
            }
            else if (condicion == "seleccionado" && this.Owner is frm2GestionarPrestamo)
            {
               
                btnVerEjemplares.Enabled = true;
                
            }
            else if (condicion == "ejemplares" && this.Owner is frm2GestionarPrestamo)
            {
                btnTraerEjemplar.Enabled = true;
            }
            
            
        }

        private void CompletarFormulario(Libro seleccionado)
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
                }
                else
                {
                    cmbTema.Text = "Varios";
                }
            }
            CargarListaEjemplares(seleccionado);
        }
        private void CargarDGVLibros(List<Libro> libros)
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libros;
            
        }

        private void CargarListaEjemplares(Libro seleccionado)
        {
            lstEjemplares.DataSource = null;
            List<Ejemplar> listaEjemplaresPorLibro = this._servicioEjemplar.TraerPorLibro(seleccionado.ISBN);
            
            lstEjemplares.DataSource = listaEjemplaresPorLibro;
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
            temas.Add("Varios");
            temas.Sort();
            temas.Insert(0, "--Seleccione una opción--");
            return temas;
        }

        private void frm2Libros_Load(object sender, EventArgs e)
        {
            CargarDGVLibros(this._servicioLibro.TraerTodos());
            CargarComboTemas();
            LimpiarCampos();
            if(this.Owner is frm1MenuPrincipal)
            {
                FormatearCampos("menu");
            } else if (this.Owner is frm2GestionarPrestamo)
            {
                FormatearCampos("prestamo");
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
                LimpiarCampos();
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
                CompletarFormulario(seleccionado);
                FormatearCampos("seleccionado");
            }
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvLibros.CurrentRow;
            Libro seleccionado = row.DataBoundItem as Libro;
            if (seleccionado != null)
            {
                this.Size = new Size(1125, this.Size.Height);
                CargarListaEjemplares(seleccionado);
            }
        }


        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarDGVLibros(_servicioLibro.TraerTodos());
            this.Size = new Size(800, this.Size.Height);
        }

        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos("libro");
                int codigo = this._servicioLibro.AltaLibro(txtTitulo.Text,txtAutor.Text,Convert.ToInt32(txtEdicion.Text),txtEditorial.Text,Convert.ToInt32(txtPaginas.Text),cmbTema.Text);
                MessageBox.Show("Alta de libro exitosa. ID libro nuevo: " + codigo + "\nPor favor, agregue la cantidad de ejemplares");
                CargarDGVLibros(_servicioLibro.TraerPorCodigo(codigo));                
                DataGridViewRow row = dgvLibros.Rows[0];
                row.Selected = true;
                Libro seleccionado = row.DataBoundItem as Libro;
                CompletarFormulario(seleccionado);
                this.Size = new Size(1125, this.Size.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerEjemplares_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvLibros.CurrentRow;
            Libro seleccionado = row.DataBoundItem as Libro;
            if (seleccionado != null)
            {
                this.Size = new Size(1125, this.Size.Height);
                CargarListaEjemplares(seleccionado);
            }
        }

        private void btnComprimir_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, this.Size.Height);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Agregar advertencia para que no se pierdan datos.
            this.Owner.Show();
            this.Hide();
        }

        private void frm2Libros_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Agregar advertencia para que no se pierdan datos.
            Application.Exit();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAgregarCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos("ejemplar");
                string codigos = _servicioEjemplar.AltaMultiplesEjemplares(Convert.ToInt32(txtCantidadAAgregar.Text), Convert.ToInt32(txtISBN.Text), Convert.ToDouble(txtPrecio.Text));
                MessageBox.Show("Se han creado los ejemplares con los códigos:\n" + codigos);
            }
            catch(Exception ex)
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
                ((frm3AltaPrestamo)this.Owner).CompletarFormulario("cliente");
                this.Owner.Show();
                this.Dispose();
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

    }
}
