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
    public partial class frm2Clientes : AbstractForm<Cliente>
    {

        private Master m;

        private const string prestamo = "prestamo";
        private const string menu = "menu";
        private const string seleccion = "seleccion";

        public frm2Clientes(Master m)
        {
            this.m = m;
            InitializeComponent();
        }
        #region "Métodos" 


        public override Form GetForm()
        {
            return this;
        }
        public override void Tab()
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
            dgvClientes.TabIndex = 8;
            btnTraerCliente.TabIndex = 9;
            btnAlta.TabIndex = 10;
            btnGuardar.TabIndex = 11;
            btnEliminar.TabIndex = 12;
            btnLimpiarCampos.TabIndex = 13;
            btnSalir.TabIndex = 14;
            

        }
        private void CargarDGVClientes(List<Cliente> clientes)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;


        }
        public override void LimpiarCampos()
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

        public override void FormatearCampos(string condicion)
        {
            if (condicion == prestamo)
            {
                this.Text = "Seleccionar cliente";

                btnTraerCliente.Visible = true;
                btnTraerCliente.Enabled = false;

                btnGuardar.Visible = false;

                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;

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

                btnGuardar.Visible = true;


                
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;

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
                btnGuardar.Enabled = true;

            }
            else if (condicion == seleccion && this.Owner is frm2GestionarPrestamo || this.Owner is frm3AltaPrestamo)
            {
                btnTraerCliente.Enabled = true;

            }
        }
        public override void ValidarCampos()
        {
            txtNombre.Text = Validaciones.StringValidation(txtNombre.Text, lblNombre.Text);
            txtApellido.Text = Validaciones.StringValidation(txtApellido.Text, lblApellido.Text);
            txtDireccion.Text = Validaciones.StringValidation(txtDireccion.Text, lblDireccion.Text);
            txtTelefono.Text = Validaciones.LongValidation(txtTelefono.Text, 10000000, 999999999999, lblTelefono.Text).ToString();
            txtMail.Text = Validaciones.StringValidation(txtMail.Text, lblMail.Text);


        }
        public override void CompletarFormulario(Cliente seleccionado)
        {
            txtCodigoCliente.Text = seleccionado.Codigo.ToString();
            txtNombre.Text = seleccionado.Nombre;
            txtApellido.Text = seleccionado.Apellido;
            txtDireccion.Text = seleccionado.Direccion;
            txtTelefono.Text = seleccionado.Telefono;
            txtMail.Text = seleccionado.Mail;
        }

        
        #endregion
        #region "Eventos"
        private void frm2Clientes_Load(object sender, EventArgs e)
        {
            Tab();
            CargarDGVClientes(this.m.Clientes);
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
                CloseWindow();
            }
            else if (this.Owner is frm3AltaPrestamo)
            {
                ((frm3AltaPrestamo)this.Owner).CompletarCodigo(txtCodigoCliente.Text, this);
                ((frm3AltaPrestamo)this.Owner).CompletarFormulario("cliente");
                ((frm3AltaPrestamo)this.Owner).FormatearCampos("completo");
                CloseWindow();
            }
        }

        

        private void btnBuscarNombreCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarNombre.Text == string.Empty && txtBuscarApellido.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.");
                    CargarDGVClientes(this.m.Clientes);
                }
                else
                {
                    CargarDGVClientes(this.m.SC.BuscarClientes(Validaciones.StringValidation(txtBuscarNombre.Text, lblBuscarNombre.Text), Validaciones.StringValidation(txtBuscarApellido.Text, lblBuscarApellido.Text)));
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
                DataGridViewRow row = dgvClientes.CurrentRow;
                Cliente seleccionado = row.DataBoundItem as Cliente;
                if (seleccionado == null)
                {
                    Cliente clienteAlta = new Cliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text);
                    int codigo = this.m.SC.AltaCliente(clienteAlta);
                    MessageBox.Show("Alta de cliente exitosa. Nuevo cliente nro:" + codigo.ToString());
                    CargarDGVClientes(this.m.Clientes);
                    LimpiarCampos();
                }else
                {
                    if (MessageOkCancel("Se modificará el cliente seleccionado.Para continuar presione Ok", this.Text))
                    {
                        seleccionado.Nombre = txtNombre.Text;
                        seleccionado.Apellido = txtApellido.Text;
                        seleccionado.Direccion =txtDireccion.Text;
                        seleccionado.Telefono =txtTelefono.Text;
                        seleccionado.Mail = txtMail.Text;
                       
                        int codigo = this.m.SC.ModificarCliente(seleccionado);
                        MessageBox.Show("El cliente " + codigo + " se ha modificado exitosamente");
                        CargarDGVClientes(this.m.Clientes);
                        LimpiarCampos();
                    }
                }
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

        //private void btnModificar_Click(object sender, EventArgs e)
        //{
        //    if (txtCodigoCliente.Text == string.Empty)
        //    {
        //        MessageBox.Show("Para modificar un cliente, antes debe seleccionarlo.");
        //    }
        //    else
        //    {
        //        try
        //        {

        //            ValidarCampos();
        //            if (MessageOkCancel("Se modificará el cliente seleccionado.Para continuar presione Ok", this.Text))
        //            {
        //                int codigo = this._clienteServicio.ModificarCliente(Convert.ToInt32(txtCodigoCliente.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text);
        //                MessageBox.Show("El cliente " + codigo + " se ha modificado exitosamente");
        //                CargarDGVClientes(this._clienteServicio.TraerTodos());
        //                LimpiarCampos();
        //            }
                    

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}

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
                        this.m.SC.EliminarCliente(Convert.ToInt32(txtCodigoCliente.Text));
                        MessageBox.Show("El cliente ha sido eliminado.");
                        CargarDGVClientes(this.m.Clientes);
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
            CargarDGVClientes(this.m.Clientes); ;
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
                     
        //private void dgvClientes_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        DataGridViewRow row = dgvClientes.CurrentRow;
        //        Cliente seleccionado = row.DataBoundItem as Cliente;
        //        if (seleccionado != null)
        //        {
        //            CompletarFormulario(seleccionado);
        //        }
        //        if (this.Owner is frm2GestionarPrestamo)
        //        {
        //            ((frm2GestionarPrestamo)this.Owner).CompletarCodigo(txtCodigoCliente.Text, this);
        //            CloseWindow();
        //        }
        //        else if (this.Owner is frm3AltaPrestamo)
        //        {
        //            ((frm3AltaPrestamo)this.Owner).CompletarCodigo(txtCodigoCliente.Text, this);
        //            ((frm3AltaPrestamo)this.Owner).CompletarFormulario("cliente");
        //            CloseWindow();
        //        }

        //    }
        //}

        //private void dgvClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow row = dgvClientes.CurrentRow;
        //    if(row != null)
        //    {
        //        Cliente seleccionado = row.DataBoundItem as Cliente;
        //        if (seleccionado != null)
        //        {
        //            CompletarFormulario(seleccionado);
        //            FormatearCampos(seleccion);
        //        }
        //    }
            
        //}
        #endregion
    }
}

