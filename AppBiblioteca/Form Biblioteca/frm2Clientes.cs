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

        private const string prestamo = "prestamo";
        private const string menu = "menu";
        private const string seleccion = "seleccion";

        public frm2Clientes(ServicioCliente cs)
        {
            this._clienteServicio = cs;
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
            gbBuscarClientes.TabIndex = 0;
            txtBuscarNombre.TabIndex = 0;
            txtBuscarApellido.TabIndex = 1;
            btnBuscarCliente.TabIndex = 2;
            gbDatoscCliente.TabIndex = 3;
            txtNombre.TabIndex = 3;
            txtApellido.TabIndex = 4;
            txtDireccion.TabIndex = 5;
            txtTelefono.TabIndex = 6;
            txtMail.TabIndex = 7;
            btnTraerCliente.TabIndex = 8;
            btnAlta.TabIndex = 9;
            btnModificar.TabIndex = 10;
            btnEliminar.TabIndex = 11;
            btnLimpiarCampos.TabIndex = 12;
            btnSalir.TabIndex = 13;
            dgvClientes.TabIndex = 14;

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



        }

        public void FormatearCampos(string condicion)
        {
            if (condicion == prestamo)
            {
                this.Text = "Seleccionar cliente";

                btnTraerCliente.Visible = true;
                btnTraerCliente.Enabled = false;

                btnAlta.Visible = false;

                btnAlta.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;

                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtDireccion.Enabled = false;
                txtTelefono.Enabled = false;
                txtMail.Enabled = false;

                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtTelefono.ReadOnly = true;
                txtMail.ReadOnly = true;


            } else if (condicion == menu)
            {
                this.Text = "Gestionar clientes";

                btnTraerCliente.Visible = false;
                btnTraerCliente.Enabled = false;

                btnAlta.Visible = true;


                btnAlta.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;

                btnTraerCliente.Visible = false;
                btnTraerCliente.Enabled = false;

                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                txtMail.Enabled = true;

                txtNombre.ReadOnly = false;
                txtApellido.ReadOnly = false;
                txtDireccion.ReadOnly = false;
                txtTelefono.ReadOnly = false;
                txtMail.ReadOnly = false;

            } else if (condicion == seleccion && this.Owner is frm1MenuPrincipal)
            {
                btnAlta.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;

            }
            else if (condicion == seleccion && this.Owner is frm2GestionarPrestamo || this.Owner is frm3AltaPrestamo)
            {
                btnTraerCliente.Enabled = true;

            }
        }
        private void ValidarCampos()
        {
            txtNombre.Text = Validaciones.StringValidation(txtNombre.Text, lblNombre.Text);
            txtApellido.Text = Validaciones.StringValidation(txtApellido.Text, lblApellido.Text);
            txtDireccion.Text = Validaciones.StringValidation(txtDireccion.Text, lblDireccion.Text);
            txtTelefono.Text = Validaciones.LongValidation(txtTelefono.Text, 10000000, 999999999999, lblTelefono.Text).ToString();
            txtMail.Text = Validaciones.StringValidation(txtMail.Text, lblMail.Text);


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

        private void CloseWindow()
        {
            this.Owner.Show();
            this.Dispose();
        }
        #endregion
        #region "Eventos"
        private void frm2Clientes_Load(object sender, EventArgs e)
        {
            Tab();
            CargarDGVClientes(this._clienteServicio.TraerTodos());
            if (this.Owner is frm1MenuPrincipal)
            {
                FormatearCampos(menu);
            } else if (this.Owner is frm2GestionarPrestamo || this.Owner is frm3AltaPrestamo)
            {
                FormatearCampos(prestamo);
            }
            dgvClientes.CurrentCell = null;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClientes.CurrentRow;
            Cliente seleccionado = row.DataBoundItem as Cliente;
            if (seleccionado != null)
            {
                CompletarFormulario(seleccionado);
                FormatearCampos(seleccion);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClientes.CurrentRow;
            Cliente seleccionado = row.DataBoundItem as Cliente;
            if (seleccionado != null)
            {
                CompletarFormulario(seleccionado);
            }
            if (this.Owner is frm2GestionarPrestamo)
            {
                ((frm2GestionarPrestamo)this.Owner).CompletarCodigo(txtCodigoCliente.Text, this);
                this.Owner.Show();
                this.Dispose();
            }
            else if (this.Owner is frm3AltaPrestamo)
            {
                ((frm3AltaPrestamo)this.Owner).CompletarCodigo(txtCodigoCliente.Text, this);
                ((frm3AltaPrestamo)this.Owner).CompletarFormulario("cliente");
                this.Owner.Show();
                this.Dispose();
            }
        }

        

        private void btnBuscarNombreCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarNombre.Text == string.Empty && txtBuscarApellido.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.");
                    CargarDGVClientes(_clienteServicio.TraerTodos());
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


        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {

                ValidarCampos();
                int codigo = this._clienteServicio.AltaCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text);
                MessageBox.Show("Alta de cliente exitosa. Nuevo cliente nro:" + codigo.ToString());
                CargarDGVClientes(this._clienteServicio.TraerTodos());
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTraerCliente_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text == string.Empty)
            {
                MessageBox.Show("Elija un cliente");
            }
            else if (this.Owner is frm2GestionarPrestamo)
            {
                ((frm2GestionarPrestamo)this.Owner).CompletarCodigo(txtCodigoCliente.Text, this);
                this.Owner.Show();
                this.Dispose();
            }
            else if (this.Owner is frm3AltaPrestamo)
            {
                ((frm3AltaPrestamo)this.Owner).CompletarCodigo(txtCodigoCliente.Text, this);
                ((frm3AltaPrestamo)this.Owner).CompletarFormulario("cliente");
                this.Owner.Show();
                this.Dispose();
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

                    ValidarCampos();
                    if (MessageOkCancel("Se modificará el cliente seleccionado.Para continuar presione Ok", this.Text))
                    {
                        int codigo = this._clienteServicio.ModificarCliente(Convert.ToInt32(txtCodigoCliente.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text);
                        MessageBox.Show("El cliente " + codigo + " se ha modificado exitosamente");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text == string.Empty)
            {
                MessageBox.Show("Para eliminar un cliente, antes debe seleccionarlo.");
            }
            else
            {
                try
                {                    
                    if (MessageOkCancel("Se eliminará el cliente seleccionado. Para continuar presione Ok", this.Text))
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
            CargarDGVClientes(this._clienteServicio.TraerTodos()); ;
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            
            CloseWindow();
            
        }

        private void frm2Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            CloseWindow();
            
        }
        

            private void frm2Clientes_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    
                    CloseWindow();
                    
                }
            }







        #endregion

       
    } 
}

