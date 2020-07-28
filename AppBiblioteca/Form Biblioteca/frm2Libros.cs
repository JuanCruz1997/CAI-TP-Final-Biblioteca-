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
        private Master m;

        private const string libro = "libro";
        private const string ejemplar = "ejemplar";
        private const string menu = "menu";
        private const string prestamo = "prestamo";
        private const string seleccion = "seleccion";

        public frm2Libros(Master m)
        {
            this.m = m;
            InitializeComponent();
        }

        #region "Métodos"
        /*public override Form GetForm()
        {
            return this;
        }*/
        public bool MessageOkCancel(string msg, string tituloForm)
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
            this.Owner.Show();
            this.Dispose();
        }
        public void Tab()
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
            dgvLibros.TabIndex = 9;
            btnTraerEjemplar.TabIndex = 10;
            btnAltaLibro.TabIndex = 11;
            btnVerEjemplares.TabIndex = 12;

            txtCantidadAAgregar.TabIndex = 13;
            btnAgregarCantidad.TabIndex = 14;

            lstEjemplares.TabIndex = 15;
            gbEjemplares.TabIndex = 16;
            txtPrecio.TabIndex = 17;
            txtObservaciones.TabIndex = 18;
            btnModificar.TabIndex = 19;
            btnComprimir.TabIndex = 20;
            btnLimpiarCampos.TabIndex = 21;
            btnSalir.TabIndex = 22;
        }
        public  void ValidarCampos(string objeto)
        {
            if (objeto == libro)
            {
                txtTitulo.Text = Validaciones.StringValidation(txtTitulo.Text, lblTitulo.Text);
                txtAutor.Text = Validaciones.StringValidation(txtAutor.Text, lblAutor.Text);
                txtEditorial.Text = Validaciones.StringValidation(txtEditorial.Text, lblEditorial.Text);
                txtEdicion.Text = Validaciones.IntValidation(txtEdicion.Text, 0, 999999999, lblEdicion.Text).ToString();
                txtPaginas.Text = Validaciones.IntValidation(txtPaginas.Text, 0, 999999999, lblCantidadPaginas.Text).ToString();
            }
            else if (objeto == ejemplar)
            {
                txtCantidadAAgregar.Text = Validaciones.IntValidation(txtCantidadAAgregar.Text, 0, int.MaxValue, lblCantidadAAgregar.Text).ToString();
                txtPrecio.Text = Validaciones.DoubleValidation(txtPrecio.Text, 0, double.MaxValue, lblPrecio.Text).ToString();
                txtISBN.Text = Validaciones.IntValidation(txtISBN.Text, 0, int.MaxValue, lblISBN.Text).ToString();
                txtObservaciones.Text = Validaciones.StringValidation(txtObservaciones.Text, lblObservaciones.Text);
            }

        }

        public  void LimpiarCampos(string objeto)
        {
            if (objeto == libro)
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
                cmbTema.SelectedIndex = 0;

            }
            else if (objeto == ejemplar)
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
        public  void FormatearCampos(string condicion)
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
            else if (condicion == seleccion)
            {
                btnVerEjemplares.Enabled = true;

                txtTitulo.Enabled = false;
                txtAutor.Enabled = false;
                txtEdicion.Enabled = false;
                txtEditorial.Enabled = false;
                txtPaginas.Enabled = false;
                cmbTema.Enabled = false;

                if (this.Owner is frm1MenuPrincipal)
                {
                    btnAltaLibro.Enabled = false;
                    btnModificar.Enabled = true;


                    lblCantidadAAgregar.Enabled = true;
                    txtCantidadAAgregar.Enabled = true;
                    btnAgregarCantidad.Enabled = true;
                    txtPrecio.Enabled = false;
                    txtObservaciones.Enabled = false;
                    btnModificar.Enabled = false;
                    lstEjemplares.Enabled = true;
                    btnComprimir.Enabled = true;

                }
                else if (this.Owner is frm2GestionarPrestamo || this.Owner is frm3AltaPrestamo)
                {

                    txtPrecio.Enabled = false;
                    txtObservaciones.Enabled = false;
                    btnModificar.Enabled = false;
                    lstEjemplares.Enabled = true;
                    btnComprimir.Enabled = true;

                }
            }

            else if (condicion == ejemplar)
            {
                if ((this.Owner is frm2GestionarPrestamo || this.Owner is frm3AltaPrestamo))
                {
                    btnTraerEjemplar.Enabled = true;
                    btnVerEjemplares.Enabled = false;

                }
                else if (this.Owner is frm1MenuPrincipal)
                {
                    txtPrecio.Enabled = true;
                    txtObservaciones.Enabled = true;
                    btnModificar.Enabled = true;
                }

            }


        }

        public  void CompletarFormulario(Libro seleccionado)
        {
            txtISBN.Text = seleccionado.ISBN.ToString();
            txtTitulo.Text = seleccionado.Titulo;
            txtAutor.Text = seleccionado.Autor;
            txtEdicion.Text = seleccionado.Edicion.ToString();
            txtPaginas.Text = seleccionado.CantPaginas.ToString();
            txtEditorial.Text = seleccionado.Editorial;
            txtInventario.Text = seleccionado.StockPermanente.ToString();
            txtDisponibles.Text = seleccionado.StockDisponible.ToString();
            foreach (String s in ListaTemas())
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
            List<Ejemplar> lista = this.m.SE.TraerPorLibro(seleccionado);
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


        private Libro IndicarLibro()
        {
            DataGridViewRow row = dgvLibros.CurrentRow;
            if (row != null)
            {
                Libro seleccionado = row.DataBoundItem as Libro;
                return seleccionado;
            }
            return null;

        }
        #endregion
        #region "Eventos"

        private void frm2Libros_Load(object sender, EventArgs e)
        {
            Tab();
            CargarDGVLibros(this.m.Libros);
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
            CloseWindow();
        }

        private void frm2Libros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }




        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarTitulo.Text == string.Empty && txtBuscarAutor.Text == string.Empty)
                {
                    CargarDGVLibros(this.m.Libros);
                    MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.");

                }
                else
                {
                    CargarDGVLibros(this.m.SL.BuscarLibro(Validaciones.StringValidation(txtBuscarTitulo.Text, lblBuscarTitulo.Text), Validaciones.StringValidation(txtBuscarAutor.Text, lblBuscarAutor.Text)));
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
            Libro seleccionado = IndicarLibro();
            if (seleccionado != null)
            {
                CargarListaEjemplares(seleccionado);
                CompletarFormulario(seleccionado);

                FormatearCampos(seleccion);
                LimpiarCampos(ejemplar);
            }
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Libro seleccionado = IndicarLibro();
            if (seleccionado != null)
            {
                this.Size = new Size(1125, this.Size.Height);
                List<Ejemplar> lista = this.m.SE.TraerPorLibro(seleccionado);
                CompletarFormulario(seleccionado);
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
                if (MessageOkCancel("Para confirmar el alta del libro presione Ok", this.Text))
                {
                    Libro libroAlta = new Libro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtEdicion.Text), txtEditorial.Text, Convert.ToInt32(txtPaginas.Text), cmbTema.Text);
                    int codigo = this.m.SL.AltaLibro(libroAlta);
                    MessageBox.Show("Alta de libro exitosa. ID libro nuevo: " + codigo + "\nPor favor, agregue la cantidad de ejemplares");
                    CargarDGVLibros(m.SL.TraerPorCodigo(codigo));
                    DataGridViewRow row = dgvLibros.Rows[0];
                    row.Selected = true;
                    Libro seleccionado = row.DataBoundItem as Libro;
                    CompletarFormulario(seleccionado);
                    this.Size = new Size(1125, this.Size.Height);
                    gbEjemplares.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTraerEjemplar_Click(object sender, EventArgs e)
        {
            try
            {
                Ejemplar ejemplar = (Ejemplar)lstEjemplares.SelectedItem;
                if (lstEjemplares.SelectedIndex == -1)
                {
                    throw new Exception("Seleccione un ejemplar");

                }
                else if (this.Owner is frm2GestionarPrestamo)
                {
                    ((frm2GestionarPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);
                    CloseWindow();
                }
                else if (ejemplar.Disponible == false)
                {
                    throw new Exception("El ejemplar se encuentra prestado. Por favor, elija otro");
                }
                else if (this.Owner is frm3AltaPrestamo)
                {
                    ((frm3AltaPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);
                    ((frm3AltaPrestamo)this.Owner).CompletarFormulario("ejemplar");
                    ((frm3AltaPrestamo)this.Owner).FormatearCampos("completo");
                    CloseWindow();
                }
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
                CompletarFormulario(seleccionado);
                CargarListaEjemplares(seleccionado);
                FormatearCampos(seleccion);
                LimpiarCampos(ejemplar);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos(libro);
            LimpiarCampos(ejemplar);
            CargarDGVLibros(this.m.Libros);
            this.Size = new Size(800, this.Size.Height);
            if (this.Owner is frm1MenuPrincipal)
            {
                FormatearCampos(menu);
            }
            else if (this.Owner is frm2GestionarPrestamo || this.Owner is frm3AltaPrestamo)
            {
                FormatearCampos(prestamo);
            }
            //LimpiarCampos(libro);
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void lstEjemplares_SelectedIndexChanged(object sender, EventArgs e)
        {

            Ejemplar seleccionado = (Ejemplar)lstEjemplares.SelectedItem;

            if (seleccionado != null)
            {
                FormatearCampos(ejemplar);
                CompletarFormularioEjemplar(seleccionado);

            }
        }

        private void lstEjemplares_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Ejemplar ejemplar = (Ejemplar)lstEjemplares.SelectedItem;
                if (lstEjemplares.SelectedIndex == -1)
                {
                    throw new Exception("Seleccione un ejemplar");
                }

                else if (this.Owner is frm2GestionarPrestamo)
                {
                    ((frm2GestionarPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);
                    CloseWindow();
                }
                else if (ejemplar.Disponible == false)
                {
                    throw new Exception("El ejemplar se encuentra prestado. Por favor, elija otro");
                }
                else if (this.Owner is frm3AltaPrestamo)
                {
                    ((frm3AltaPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);
                    ((frm3AltaPrestamo)this.Owner).CompletarFormulario("ejemplar");
                    ((frm3AltaPrestamo)this.Owner).FormatearCampos("completo");
                    CloseWindow();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos(ejemplar);
                Ejemplar ejemplarAlta = new Ejemplar(Convert.ToInt32(txtISBN.Text), Convert.ToDouble(txtPrecio.Text));
                string codigos = m.SE.AltaMultiplesEjemplares(Convert.ToInt32(txtCantidadAAgregar.Text), ejemplarAlta);
                MessageBox.Show("Se han creado los ejemplares con los códigos:\n" + codigos);
                Libro seleccionado = IndicarLibro();
                CompletarFormulario(seleccionado);
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
                    Ejemplar ejemplarModificar = new Ejemplar(ej.CodigoLibro, ej.Precio);
                    ejemplarModificar.Codigo = ej.Codigo;
                    ejemplarModificar.Precio = Convert.ToDouble(txtPrecio.Text);
                    ejemplarModificar.Descripcion = txtObservaciones.Text;
                    int codigo = this.m.SE.ModificarEjemplar(ejemplarModificar);
                    MessageBox.Show("El ejemplar " + codigo + " se ha modificado exitosamente");
                    Libro seleccionado = IndicarLibro();
                    CompletarFormulario(seleccionado);
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




        private void lstEjemplares_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Ejemplar ejemplar = (Ejemplar)lstEjemplares.SelectedItem;
                    if (lstEjemplares.SelectedIndex == -1)
                    {
                        throw new Exception("Seleccione un ejemplar");
                    }

                    else if (this.Owner is frm2GestionarPrestamo)
                    {
                        ((frm2GestionarPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);
                        CloseWindow();
                    }
                    else if (ejemplar.Disponible == false)
                    {
                        throw new Exception("El ejemplar se encuentra prestado. Por favor, elija otro");
                    }
                    else if (this.Owner is frm3AltaPrestamo)
                    {
                        ((frm3AltaPrestamo)this.Owner).CompletarCodigo(ejemplar.Codigo.ToString(), this);
                        ((frm3AltaPrestamo)this.Owner).CompletarFormulario("ejemplar");
                        CloseWindow();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

     
        #endregion


    }
}
