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
            LimpiarCampos();
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
            btnAlta.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            string msg = string.Empty;
            if (Validaciones.ValidarString(txtNombre.Text) == "")
            {
                msg = "El nombre ingresado no es válido.";
            }
            else if (Validaciones.ValidarString(txtApellido.Text) == "")
            {
                msg = "El apellido ingresado no es válido.";
            }
            else if (Validaciones.ValidarString(txtDireccion.Text) == "")
            {
                msg = "La dirección ingresada es inválida.";
            }
            else if (Validaciones.ValidarInt(txtTelefono.Text) == -1)
            {
                msg = "El teléfono ingresado es inválido.";
            }
            else if (Validaciones.ValidarString(txtMail.Text) == "")
            {
                msg = "El mail ingresado es inválido.";
            }
            if (msg != string.Empty)
            {
                valido = false;
                MessageBox.Show(msg);
            }
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
        private void btnBuscarNombreCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarNombre.Text == string.Empty && txtBuscarApellido.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.");
                    CargarDGVClientes(this._clienteServicio.TraerTodos());
                }
                else
                {
                    CargarDGVClientes(this._clienteServicio.BuscarClientes(txtBuscarNombre.Text, txtBuscarApellido.Text));
                }
                txtBuscarNombre.Text = string.Empty;
                txtBuscarApellido.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm2Clientes_Load(object sender, EventArgs e)
        {
            CargarDGVClientes(this._clienteServicio.TraerTodos());
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClientes.CurrentRow;
            Cliente seleccionado = row.DataBoundItem as Cliente;
            if (seleccionado != null)
            {
                CompletarFormulario(seleccionado);
                btnAlta.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarDGVClientes(this._clienteServicio.TraerTodos());
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    int codigo = this._clienteServicio.AltaCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text);
                    MessageBox.Show("Alta de cliente exitosa." + codigo.ToString());
                    CargarDGVClientes(this._clienteServicio.TraerTodos());
                    LimpiarCampos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Agregar advertencia para que no se pierdan datos.
            this.Owner.Show();
            this.Hide();
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
    }
}
