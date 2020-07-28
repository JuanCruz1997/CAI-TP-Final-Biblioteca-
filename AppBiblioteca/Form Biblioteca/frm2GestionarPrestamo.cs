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
        private Master m;
        private GrillaService _grilla;
        private const string menu = "menu";
        private const string seleccion = "seleccion";

        
        public frm2GestionarPrestamo(Master m)
        {
            this.m = m;
            _grilla = new GrillaService(m);
            InitializeComponent();
        }
        #region "Métodos"
        /*public  Form GetForm()
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
        public  void Tab()
        {
            gbBuscarPrestamos.TabIndex = 0;
            txtBuscarCodEjemplar.TabIndex = 0;
            btnEjemplares.TabIndex = 1;
            txtBuscarCodCliente.TabIndex = 2;
            btnClientes.TabIndex = 3;
            btnBuscarPrestamo.TabIndex = 4;
            gbDatosPrestamo.TabIndex = 5;
            chkAbiertos.TabIndex = 5;
            dgvPrestamos.TabIndex = 6;
            dtpFechaTentativaDevolucion.TabIndex = 7;
            dtpFechaDevolucion.TabIndex = 8;
            btnNuevoPrestamo.TabIndex = 9;
            btnConfirmarDevolución.TabIndex = 10;
            btnEliminarPréstamo.TabIndex = 11;
            btnLimpiarCampos.TabIndex = 12;
            btnSalir.TabIndex = 13;
            
        }
        public  void ValidarCampos()
        {
            txtBuscarCodCliente.Text = Validaciones.IntValidation(txtBuscarCodCliente.Text, 0, int.MaxValue, lblBuscarCodCliente.Text).ToString();
            txtBuscarCodEjemplar.Text = Validaciones.IntValidation(txtBuscarCodEjemplar.Text, 0, int.MaxValue, lblBuscarCodEjemplar.Text).ToString();
        }

        public  void LimpiarCampos()
        {
            txtBuscarCodCliente.Text = string.Empty;
            txtBuscarCodEjemplar.Text = string.Empty;

            dtpFechaTentativaDevolucion.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today;
            txtDeuda.Text = string.Empty;

            dgvPrestamos.CurrentCell = null;
        }
        private Boolean EstaDevuelto()
        {
            PrestamoAdapter seleccionado = ObtenerAdapter();
            return seleccionado.Devuelto;
        }
        public void CompletarFormulario(PrestamoAdapter seleccionado)
        {
            Prestamo elegido = this.m.SP.TraerPorCodigo(seleccionado.Codigo);
            dtpFechaTentativaDevolucion.Value = elegido.FechaDevolucionTentativa;
            if (elegido.Abierto)
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
                if (EstaDevuelto())
                {
                    btnNuevoPrestamo.Enabled = false;
                    btnConfirmarDevolución.Enabled = false;

                    btnEliminarPréstamo.Enabled = false;

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
            chkAbiertos.Checked = true;
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
            frm2Libros f = new frm2Libros(m);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frm2Clientes f = new frm2Clientes(m);
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
            frm3AltaPrestamo f = new frm3AltaPrestamo(m);
            f.Owner = this;
            f.Show();
        }

        private void btnConfirmarDevolución_Click(object sender, EventArgs e)
        {
            try
            {                
                if (MessageOkCancel("Para confirmar la devolución del ejemplar presione Ok", this.Text))
                {
                    PrestamoAdapter seleccionado = ObtenerAdapter();
                    int codigo = this.m.SP.Devolucion(seleccionado.Codigo, DateTime.Now);
                    MessageBox.Show("El ejemplar " + codigo +" ha sido devuelto exitosamente");
                    CargarDGVPrestamos();
                    LimpiarCampos();
                    FormatearCampos(menu);
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
                if (MessageOkCancel("ATENCIÓN: solo se deberán eliminar los préstamos que posean información incorrecta\nPara eliminar el préstamo presione Ok", this.Text))
                {                                    
                    PrestamoAdapter seleccionado = ObtenerAdapter();
                    int codigo = this.m.SP.EliminarPrestamo(seleccionado.Codigo);
                    MessageBox.Show("El préstamo " + codigo + " se ha eliminado exitosamente");
                    CargarDGVPrestamos();
                    FormatearCampos(menu);
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
            
            CargarDGVPrestamos();
            FormatearCampos(menu);
            LimpiarCampos();

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
