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
    public partial class frm2Clientes : Form
    {
        private ServicioCliente _clienteServicio;
        public frm2Clientes(ServicioCliente cs)
        {
            this._clienteServicio = cs;
            InitializeComponent();
        }
        private void CargarDGVClientes(List<Cliente> clientes)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;
            
            
        }
        private void LimpiarCampos()
        {
            dgvClientes.CurrentCell = null;

            txtCodigoCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtMail.Text = string.Empty;

            txtBuscarNombre.Text = string.Empty;
            txtBuscarApellido.Text = string.Empty;

            FormatearCampos("menu");

            /*btnAlta.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;*/

        }

        public void FormatearCampos(string condicion)
        {
            if(condicion == "prestamo")
            {
                btnTraerCliente.Visible = true;
                btnTraerCliente.Enabled = true;

                btnAlta.Visible = false;
                btnEliminar.Visible = false;
                btnModificar.Visible = false;

                btnAlta.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;

                this.Text = "Seleccionar cliente";

            }else if (condicion == "menu")
            {
                btnAlta.Visible = true;
                btnEliminar.Visible = true;
                btnModificar.Visible = true;

                btnAlta.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;

                btnTraerCliente.Visible = false;
                btnTraerCliente.Enabled = false;

            } else if(condicion == "modificar")
            {
                btnAlta.Visible = true;
                btnEliminar.Visible = true;
                btnModificar.Visible = true;

                btnAlta.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            //string msg = string.Empty;
            //Hay que revisarlo
            txtNombre.Text = Validaciones.StringValidation(txtNombre.Text, lblNombre.Text);
            txtApellido.Text = Validaciones.StringValidation(txtApellido.Text, lblApellido.Text);
            txtDireccion.Text = Validaciones.StringValidation(txtDireccion.Text, lblDireccion.Text);
            txtTelefono.Text = Validaciones.LongValidation(txtTelefono.Text, 10000000, 999999999999 ,lblTelefono.Text).ToString();
            txtMail.Text = Validaciones.StringValidation(txtMail.Text, lblMail.Text);
             
            
            return valido;
        }
        private void CompletarFormulario(Cliente seleccionado)
        {
            txtCodigoCliente.Text = seleccionado.Codigo.ToString();
            txtNombre.Text = seleccionado.Nombre;
            txtApellido.Text = seleccionado.Apellido;
            txtDireccion.Text = seleccionado.Direccion;
            txtTelefono.Text = seleccionado.Telefono;
            txtMail.Text = seleccionado.Mail;
        }

        private void frm2Clientes_Load(object sender, EventArgs e)
        {
            CargarDGVClientes(this._clienteServicio.TraerTodos());
            if(this.Owner is frm1MenuPrincipal)
            {
                FormatearCampos("menu");
            } else if (this.Owner is frm2GestionarPrestamo)
            {
                FormatearCampos("prestamo");
            }
        }
        private void btnBuscarNombreCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarNombre.Text == string.Empty && txtBuscarApellido.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.");
                    CargarDGVClientes(_clienteServicio.Clientes);
                }
                else
                {
                    CargarDGVClientes(this._clienteServicio.BuscarClientes(Validaciones.StringValidation(txtBuscarNombre.Text, lblBuscarNombre.Text), Validaciones.StringValidation(txtBuscarApellido.Text, lblBuscarApellido.Text)));
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClientes.CurrentRow;
            Cliente seleccionado = row.DataBoundItem as Cliente;
            if (seleccionado != null)
            {
                CompletarFormulario(seleccionado);
                FormatearCampos("modificar");
            }
        }

        

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    int codigo = this._clienteServicio.AltaCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text);
                    MessageBox.Show("Alta de cliente exitosa. Nuevo cliente nro:" + codigo.ToString());
                    CargarDGVClientes(this._clienteServicio.Clientes);
                    LimpiarCampos();
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text == string.Empty)
            {
                MessageBox.Show("Para modificar un cliente, antes debe seleccionarlo.");
            }
            else
            {
                try
                {
                    if (ValidarCampos())
                    {
                        this._clienteServicio.ModificarCliente(Convert.ToInt32(txtCodigoCliente.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text);
                        MessageBox.Show("El cliente se ha modificado exitosamente.");
                        CargarDGVClientes(this._clienteServicio.TraerTodos());
                        LimpiarCampos();
                        
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text == string.Empty)
            {
                MessageBox.Show("Para modificar un cliente, antes debe seleccionarlo.");
            }
            else
            {
                try
                {
                    DialogResult pregunta = MessageBox.Show("¿Está seguro de que desea eliminar el cliente seleccionado?", "Eliminar", MessageBoxButtons.YesNo);
                    if (pregunta.ToString() == "Yes")
                    {
                        this._clienteServicio.EliminarCliente(Convert.ToInt32(txtCodigoCliente.Text));
                        MessageBox.Show("El cliente ha sido eliminado.");
                        CargarDGVClientes(this._clienteServicio.TraerTodos());
                        LimpiarCampos();
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            CargarDGVClientes(this._clienteServicio.Clientes);
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Agregar advertencia para que no se pierdan datos.
            this.Owner.Show();
            this.Hide();
        }

        private void frm2Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTraerCliente_Click(object sender, EventArgs e)
        {
            if(txtCodigoCliente.Text == string.Empty)
            {
                MessageBox.Show("Elija un cliente");
            }
            else
            {
                ((frm2GestionarPrestamo)this.Owner).CompletarCodigo(txtCodigoCliente.Text, this);
                this.Owner.Show();
                this.Dispose();
            }
            
        }
    }
}
