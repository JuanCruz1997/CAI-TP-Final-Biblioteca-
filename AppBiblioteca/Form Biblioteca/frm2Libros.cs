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

        private void ValidarCampos()
        {
            txtTitulo.Text = Validaciones.StringValidation(txtTitulo.Text, lblTitulo.Text);
            txtAutor.Text = Validaciones.StringValidation(txtAutor.Text, lblAutor.Text);
            txtEditorial.Text = Validaciones.StringValidation(txtEditorial.Text, lblEditorial.Text);
            txtEdicion.Text = Validaciones.IntValidation(txtEdicion.Text, 0, 999999999, lblEdicion.Text).ToString();
            txtPaginas.Text = Validaciones.IntValidation(txtPaginas.Text, 0, 999999999, lblCantidadPaginas.Text).ToString();
        }

        private void LimpiarCampos()
        {
            dgvLibros.CurrentCell = null;
            btnAltaLibro.Enabled = true;
            btnVerEjemplares.Enabled = false;
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
            LimpiarCampos();
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
            temas.Add("Varios");
            temas.Sort();
            temas.Insert(0, "--Seleccione una opción--");
            return temas;
        }

        private void frm2Libros_Load(object sender, EventArgs e)
        {
            CargarDGVLibros(this._servicioLibro.TraerTodos());
            CargarComboTemas();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarTitulo.Text == string.Empty && txtBuscarAutor.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.");
                    CargarDGVLibros(this._servicioLibro.TraerTodos());
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
                btnAltaLibro.Enabled = false;
                btnVerEjemplares.Enabled = true;
            }
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvLibros.CurrentRow;
            Libro seleccionado = row.DataBoundItem as Libro;
            if (seleccionado != null)
            {
                //Abrir formulario con datos de seleccionado
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
                ValidarCampos();
                int codigo = this._servicioLibro.AltaLibro(txtTitulo.Text,txtAutor.Text,Convert.ToInt32(txtEdicion.Text),txtEditorial.Text,Convert.ToInt32(txtPaginas.Text),cmbTema.Text);
                MessageBox.Show("Alta de libro exitosa. ID libro nuevo: " + codigo + "\nPor favor, agregue la cantidad de ejemplares");
                CargarDGVLibros(_servicioLibro.TraerPorCodigo(codigo));
                dgvLibros.FirstDisplayedScrollingRowIndex = 0;
                DataGridViewRow row = dgvLibros.CurrentRow;
                Libro seleccionado = row.DataBoundItem as Libro;
                CompletarFormulario(seleccionado);
                //txtISBN.Text = codigo.ToString();
                this.Size = new Size(1125, this.Size.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerEjemplares_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1125, this.Size.Height);
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

        }

        private void btnAgregarCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                txtCantidadAAgregar.Text = Validaciones.IntValidation(txtCantidadAAgregar.Text, 0, int.MaxValue, lblCantidadAAgregar.Text).ToString();
                txtPrecio.Text = Validaciones.DoubleValidation(txtPrecio.Text, 0, double.MaxValue, lblPrecio.Text).ToString();
                txtISBN.Text = Validaciones.IntValidation(txtISBN.Text, 0, int.MaxValue, lblISBN.Text).ToString();
                string codigos = _servicioEjemplar.AltaMultiplesEjemplares(Convert.ToInt32(txtCantidadAAgregar.Text), Convert.ToInt32(txtISBN.Text), Convert.ToDouble(txtPrecio.Text));
                MessageBox.Show("Se han creado los ejemplares con los códigos:\n" + codigos);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
