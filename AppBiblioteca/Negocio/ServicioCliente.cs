using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class ServicioCliente
    {
        private MapperCliente _mapper;
        private List<Cliente> _clientes;

        public List<Cliente> Clientes { get => _clientes; set => _clientes = value; }

        public ServicioCliente()
        {
            this._mapper = new MapperCliente();
            this.Clientes = new List<Cliente>();
            this.Clientes = _mapper.Traer();
        }
        public List<Cliente> TraerTodos()
        {
            List<Cliente> resultado = new List<Cliente>();
            resultado = Clientes;
            return resultado;
        }


        public List<Cliente> BuscarClientes(string nombre, string apellido)
        {
            List<Cliente> resultado = new List<Cliente>();
            if(nombre == string.Empty && apellido == string.Empty)
            {
                return resultado = this.TraerTodos();
            }
            else
            {

            
            
                foreach(Cliente c in this.TraerTodos())
                {
                    if (c.Nombre != null || c.Apellido != null)
                    {
                        if (c.Nombre.ToLower().Contains(nombre.ToLower()) && apellido == string.Empty)
                        {
                            resultado.Add(c);
                        }
                        else if (nombre == string.Empty && c.Apellido.ToLower().Contains(apellido.ToLower()))
                        {
                            resultado.Add(c);
                        }
                        else if (c.Nombre.ToLower().Contains(nombre.ToLower()) && c.Apellido.ToLower().Contains(apellido.ToLower()))
                        {
                            resultado.Add(c);
                        }
                    }
                }
            }
            return resultado;
        }
        public int AltaCliente(string nombre,string apellido,string direccion,string telefono,string mail)
        {
            Cliente alta = new Cliente(nombre, apellido, direccion, telefono, mail);
            
            TransactionResult resultado = _mapper.Insert(alta);
            if (resultado.IsOk)
            {
                return resultado.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
            }
        }
        public void ModificarCliente(int codigo,string nombre, string apellido, string direccion, string telefono, string mail)
        {
            Cliente c = TraerPorCodigo(codigo);
            if (c != null)
            {
                c.Nombre = nombre;
                c.Apellido = apellido;
                c.Direccion = direccion;
                c.Telefono = telefono;
                c.Mail = mail;
                //Falta la lógica de modificar el cliente en el servidor.
            }
            else
            {
                throw new Exception("Cliente inexistente");
            }
        }
        public void EliminarCliente(int codigo)
        {
            Cliente c = this.TraerPorCodigo(codigo);
            if (c != null)
            {
                //Lógica de eliminar el cliente en servidor
            }
            else
            {
                throw new Exception("El cliente no existe");
            }
        }

        public Cliente TraerPorCodigo(int codigo)
        {
            foreach (Cliente c in this.TraerTodos())
            {
                if (codigo == c.Codigo)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
