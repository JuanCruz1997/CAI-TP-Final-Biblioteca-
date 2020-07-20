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
        

        public ServicioCliente()
        {
            this._mapper = new MapperCliente();
            
        }
        public List<Cliente> TraerTodos()
        {
            List<Cliente> resultado = new List<Cliente>();
            resultado = _mapper.Traer();
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
        public int ModificarCliente(int codigo,string nombre, string apellido, string direccion, string telefono, string mail)
        {
            Cliente c = TraerPorCodigo(codigo);
            if (c != null)
            {
                c.Nombre = nombre;
                c.Apellido = apellido;
                c.Direccion = direccion;
                c.Telefono = telefono;
                c.Mail = mail;
                TransactionResult resultado = _mapper.Update(c);
                if (resultado.IsOk)
                {
                    return resultado.Id;
                }
                else
                {
                    throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
                }
            }
            else
            {
                throw new Exception("Cliente inexistente");
            }
        }
        public int EliminarCliente(int codigo)
        {
            Cliente c = this.TraerPorCodigo(codigo);
            if (c != null)
            {
                TransactionResult resultado = _mapper.Delete(c);
                if (resultado.IsOk)
                {
                    return resultado.Id;
                }
                else
                {
                    throw new Exception("Hubo un error en la petición al servidor. Detalles: " + resultado.Error);
                }
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
