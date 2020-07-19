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
        private GrillaService _grilla;
        public frm2GestionarPrestamo(ServicioPrestamo sp)
        {
            _servicioPrestamo = sp;
            _grilla = new GrillaService();
            InitializeComponent();
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

        private void CompletarFormulario(Prestamo seleccionado)
        {
            throw new NotImplementedException();
        }
        private void FormatearCampos(string condicion)
        {
            
            if (condicion == "menu")
            {
                btnNuevoPrestamo.Enabled = true;

                btnConfirmarDevolución.Enabled = false;
                btnEliminarPréstamo.Enabled = false;

                lblRojo.Visible = false;

                chkAbiertos.Checked = true;

            }
            else if (condicion == "seleccionado" && chkAbiertos.Checked)
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


            }
            else if (condicion == "seleccionado" && !chkAbiertos.Checked)
            {
                if (dtpFechaDevolucion.Value != null)
                {
                    btnNuevoPrestamo.Enabled = false;
                    btnConfirmarDevolución.Enabled = false;

                    btnEliminarPréstamo.Enabled = true;

                    lblRojo.Visible = false;


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
                }
       }    }
        
    
        private void CargarDGVPrestamos()
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

        

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            frm3AltaPrestamo f = new frm3AltaPrestamo(new ServicioPrestamo());
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnConfirmarDevolución_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEliminarPréstamo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }      

        

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void chkAbiertos_CheckedChanged(object sender, EventArgs e)
        {
            CargarDGVPrestamos();
            LimpiarCampos();
        }

        private void frm2GestionarPrestamo_Load(object sender, EventArgs e)
        {
            CargarDGVPrestamos();            
            FormatearCampos("menu");
            LimpiarCampos();
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            frm2Libros f = new frm2Libros(new ServicioLibro(), new ServicioEjemplar());
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

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPrestamos.CurrentRow;
            Prestamo seleccionado = row.DataBoundItem as Prestamo;
            if (seleccionado != null)
            {
                CompletarFormulario(seleccionado);
                FormatearCampos("seleccionado");
            }
            
        }
    }
}
