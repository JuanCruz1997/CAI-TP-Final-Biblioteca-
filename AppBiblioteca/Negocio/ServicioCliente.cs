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
        private MapperCliente mapper;
        public ServicioCliente()
        {
            this.mapper = new MapperCliente();
        }
        public List<Cliente> TraerTodos()
        {
            List<Cliente> resultado = mapper.Traer();
            return resultado;
        }
        public List<Cliente> BuscarClientes(string nombre, string apellido)
        {
            List<Cliente> resultado = new List<Cliente>();
            if (Validaciones.ValidarString(nombre) == "" || Validaciones.ValidarString(apellido) == "")
            {
                throw new Exception("La búsqueda requiere que se ingrese una cadena de texto válida.");
            }
            else
            {
                foreach(Cliente c in this.TraerTodos())
                {
                    if(c.Nombre==nombre || c.Apellido == apellido)
                    {
                        resultado.Add(c);
                    }
                }
            }
            return resultado;
        }
        public int AltaCliente(string nombre,string apellido,string direccion,int telefono,string mail)
        {
            Cliente alta = new Cliente();
            alta.Nombre = nombre;
            alta.Apellido = apellido;
            alta.Direccion = direccion;
            alta.Telefono = telefono;
            alta.Mail = mail;
            TransactionResult resultado = mapper.Insert(alta);
            if (resultado.IsOk)
            {
                return resultado.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
            }
        }
        public void ModificarCliente(int codigo,string nombre, string apellido, string direccion, int telefono, string mail)
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
                throw new Exception("Cliente inexistente.");
            }
        }
        public Cliente TraerPorCodigo(int codigo)
        {
            foreach(Cliente c in this.TraerTodos())
            {
                if (codigo == c.Codigo)
                {
                    return c;
                }
            }
            return null;
        }
        public void EliminarCliente(int codigo)
        {
            Cliente c = this.TraerPorCodigo(codigo);
            if (c != null)
            {
                //Lógica de eliminar el empleado en servidor
            }
            else
            {
                throw new Exception("El cliente no existe.");
            }
        }
    }
}
