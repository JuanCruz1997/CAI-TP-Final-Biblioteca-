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

            txtBuscarNombre.Text = string.Empty;
            txtBuscarApellido.Text = string.Empty;


            btnAlta.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        public void FormatearCampos(string condicion)
        {
            throw new NotImplementedException();
        }
        private Boolean ValidarCampos()
        {
            bool valido = true;
            //string msg = string.Empty;

            txtNombre.Text = Validaciones.StringValidation(txtNombre.Text, lblNombre.Text);
            txtApellido.Text = Validaciones.StringValidation(txtApellido.Text, lblApellido.Text);
            txtDireccion.Text = Validaciones.StringValidation(txtDireccion.Text, lblDireccion.Text);
            txtTelefono.Text = Validaciones.LongValidation(txtTelefono.Text, 10000000, 999999999999 ,lblTelefono.Text).ToString();
            txtMail.Text = Validaciones.StringValidation(txtMail.Text, lblMail.Text);
             
            //fijate que de esta forma, no hace falta tanto código

            /*if (Validaciones.ValidarString(txtNombre.Text) == "")
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
            }*/
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
            CargarDGVClientes(this._clienteServicio.Cliente);
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
                    CargarDGVClientes(this._clienteServicio.BuscarClientes(Validaciones.StringValidation(txtBuscarNombre.Text, lblBuscarNombre.Text), Validaciones.StringValidation(txtBuscarApellido.Text, lblBuscarApellido.Text));
                }

                //no sería mejor limpiar campos directamente?
                txtBuscarNombre.Text = string.Empty;
                txtBuscarApellido.Text = string.Empty;
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
                btnAlta.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
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
            LimpiarCampos();
            CargarDGVClientes(this._clienteServicio.Clientes);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Agregar advertencia para que no se pierdan datos.
            this.Owner.Show();
            this.Hide();
        }
    }
}
