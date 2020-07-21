using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Form_Biblioteca
{
    public partial class frm2GestionarPrestamo : Form
    {
        private ServicioPrestamo _servicioPrestamo;
        private ServicioLibro _servicioLibro;
        private ServicioEjemplar _servicioEjemplar;
        private ServicioCliente _servicioCliente;
        private GrillaService _grilla;
        private const string menu = "menu";
        private const string seleccion = "seleccion";

        public frm2GestionarPrestamo(ServicioPrestamo sp, ServicioLibro sl, ServicioEjemplar se, ServicioCliente sc)
        {
            _servicioPrestamo = sp;
            this._servicioLibro = sl;
            this._servicioEjemplar = se;
            this._servicioCliente = sc;
            _grilla = new GrillaService();
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
            gbBuscarPrestamos.TabIndex = 0;
            txtBuscarCodEjemplar.TabIndex = 0;
            btnEjemplares.TabIndex = 1;
            txtBuscarCodCliente.TabIndex = 2;
            btnClientes.TabIndex = 3;
            btnBuscarPrestamo.TabIndex = 4;
            gbDatosPrestamo.TabIndex = 5;
            chkAbiertos.TabIndex = 5;
            dtpFechaTentativaDevolucion.TabIndex = 6;
            dtpFechaDevolucion.TabIndex = 7;
            btnNuevoPrestamo.TabIndex = 8;
            btnConfirmarDevolución.TabIndex = 9;
            btnEliminarPréstamo.TabIndex = 10;
            btnLimpiarCampos.TabIndex = 11;
            btnSalir.TabIndex = 12;
            dgvPrestamos.TabIndex = 13;
        }
        private void ValidarCampos()
        {
            txtBuscarCodCliente.Text = Validaciones.IntValidation(txtBuscarCodCliente.Text, 0, int.MaxValue, lblBuscarCodCliente.Text).ToString();
            txtBuscarCodEjemplar.Text = Validaciones.IntValidation(txtBuscarCodEjemplar.Text, 0, int.MaxValue, lblBuscarCodEjemplar.Text).ToString();
        }

        private void LimpiarCampos()
        {
            txtBuscarCodCliente.Text = string.Empty;
            txtBuscarCodEjemplar.Text = string.Empty;

            dgvPrestamos.CurrentCell = null;
        }

        private void CompletarFormulario(PrestamoAdapter seleccionado)
        {
            Prestamo elegido = this._servicioPrestamo.TraerPorCodigo(seleccionado.Codigo);
            dtpFechaTentativaDevolucion.Value = elegido.FechaDevolucionTentativa;
            if (elegido.FechaDevolucionReal == DateTime.MinValue)
            {
                dtpFechaDevolucion.Value = DateTime.Now;
            }
            else
            {
                dtpFechaDevolucion.Value = elegido.FechaDevolucionReal;
            }
            txtDeuda.Text = elegido.Deuda.ToString();
        }
        private void FormatearCampos(string condicion)
        {            
            if (condicion == menu)
            {
                btnNuevoPrestamo.Enabled = true;

                btnConfirmarDevolución.Enabled = false;
                btnEliminarPréstamo.Enabled = false;

                lblRojo.Visible = false;

                chkAbiertos.Checked = true;

                dtpFechaDevolucion.Enabled = false;

            }
            else if (condicion == seleccion && chkAbiertos.Checked)
            {
                btnNuevoPrestamo.Enabled = false;

                btnConfirmarDevolución.Enabled = true;
                btnEliminarPréstamo.Enabled = true;

                if (dtpFechaTentativaDevolucion.Value < DateTime.Today)
                {
                    lblRojo.Visible = true;
                }
                else
                {
                    lblRojo.Visible = false;
                }
                dtpFechaDevolucion.Enabled = true;

            }
            else if (condicion == seleccion && !chkAbiertos.Checked)
            {
                if (dtpFechaDevolucion.Value != DateTime.MinValue)
                {
                    btnNuevoPrestamo.Enabled = false;
                    btnConfirmarDevolución.Enabled = false;

                    btnEliminarPréstamo.Enabled = true;

                    lblRojo.Visible = false;

                    dtpFechaDevolucion.Enabled = false;
                }
                else
                {
                    btnNuevoPrestamo.Enabled = false;

                    btnConfirmarDevolución.Enabled = true;

                    btnEliminarPréstamo.Enabled = true;

                    if (dtpFechaTentativaDevolucion.Value < DateTime.Today)
                    {
                        lblRojo.Visible = true;
                    }
                    else
                    {
                        lblRojo.Visible = false;
                    }
                    dtpFechaDevolucion.Enabled = true;
                }
       }    }
        
    
        public void CargarDGVPrestamos()
        {
            ValidarCampos();
            if (chkAbiertos.Checked)
            {
                dgvPrestamos.DataSource = null;
                dgvPrestamos.DataSource = _grilla.GetListaPrestamosAbiertos(Convert.ToInt32(txtBuscarCodCliente.Text), Convert.ToInt32(txtBuscarCodEjemplar.Text));

            }
            else
            {
                dgvPrestamos.DataSource = null;
                dgvPrestamos.DataSource = _grilla.GetListaPrestamosCompleta(Convert.ToInt32(txtBuscarCodCliente.Text), Convert.ToInt32(txtBuscarCodEjemplar.Text));

            }
            LimpiarCampos();
        }

        public void CompletarCodigo(string id, Form form)
        {
            if (form is frm2Clientes)
            {
                txtBuscarCodCliente.Text = id;
            }else if (form is frm2Libros)
            {
                txtBuscarCodEjemplar.Text = id;
            }
        }

        private void CloseWindow()
        {
            this.Owner.Show();
            this.Dispose();
        }
        private PrestamoAdapter ObtenerAdapter()
        {
            DataGridViewRow row = dgvPrestamos.CurrentRow;
            PrestamoAdapter seleccionado = row.DataBoundItem as PrestamoAdapter;
            return seleccionado;
        }

        #endregion
        #region "Eventos"
        private void frm2GestionarPrestamo_Load(object sender, EventArgs e)
        {
            Tab();
            CargarDGVPrestamos();
            FormatearCampos(menu);
            LimpiarCampos();
        }
        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PrestamoAdapter seleccionado = ObtenerAdapter();
            if (seleccionado != null)
            {
                CompletarFormulario(seleccionado);
                FormatearCampos(seleccion);
            }
        }
        

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            frm2Libros f = new frm2Libros(_servicioLibro, _servicioEjemplar, _servicioPrestamo);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frm2Clientes f = new frm2Clientes(new ServicioCliente());
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarCodCliente.Text == string.Empty && txtBuscarCodEjemplar.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.");
                    CargarDGVPrestamos();
                }
                else
                {
                    CargarDGVPrestamos();
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkAbiertos_CheckedChanged(object sender, EventArgs e)
        {
            CargarDGVPrestamos();
            LimpiarCampos();
        }
        
        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            frm3AltaPrestamo f = new frm3AltaPrestamo(this._servicioPrestamo, this._servicioCliente, _servicioEjemplar, this._servicioLibro);
            f.Owner = this;
            f.Show();
        }

        private void btnConfirmarDevolución_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult pregunta = MessageBox.Show("¿Confirma que el ejemplar ha sido devuelto?", "Confirmar devolución", MessageBoxButtons.YesNo);
                if (pregunta.ToString() == "Yes")
                {
                    PrestamoAdapter seleccionado = ObtenerAdapter();
                    int codigo = this._servicioPrestamo.Devolucion(seleccionado.Codigo, DateTime.Now);
                    MessageBox.Show("El ejemplar ha sido devuelto. Código operación: " + codigo);
                    CargarDGVPrestamos();
                    LimpiarCampos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarPréstamo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult pregunta = MessageBox.Show("¿Confirma que desea eliminar el préstamo seleccionado? Recuerde que sólo debe hacerlo si el mismo fue cargado incorrectamente con datos incorrectos.", "Eliminar préstamo", MessageBoxButtons.YesNo);
                if (pregunta.ToString() == "Yes")
                {
                    PrestamoAdapter seleccionado = ObtenerAdapter();
                    int codigo = this._servicioPrestamo.EliminarPrestamo(seleccionado.Codigo);
                    MessageBox.Show("Se ha eliminado el préstamo. Código operación: " + codigo);
                    CargarDGVPrestamos();
                    LimpiarCampos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarDGVPrestamos();
            FormatearCampos(menu);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void frm2GestionarPrestamo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }

        private void frm2GestionarPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseWindow();
        }



        #endregion

        
    }
}
