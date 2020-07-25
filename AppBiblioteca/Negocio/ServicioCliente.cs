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
        private Master m;
        

        public ServicioCliente(Master m)
        {
            this._mapper = new MapperCliente();
            this.m = m;   
        }
        public List<Cliente> TraerTodos()
        {
            List<Cliente> resultado = new List<Cliente>();
            resultado = _mapper.TraerTodo();
            return resultado;
        }


        public List<Cliente> BuscarClientes(string nombre, string apellido)
        {
            List<Cliente> resultado = new List<Cliente>();
            if(nombre == string.Empty && apellido == string.Empty)
            {
                return resultado = this.m.Clientes;
            }
            else
            {          
            
                foreach(Cliente c in this.m.Clientes)
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
        public int AltaCliente(Cliente alta)
        {
            
            
            TransactionResult resultado = _mapper.Insert(alta);
            if (resultado.IsOk)
            {
                this.m.ActualizarCache(this.ToString());
                return resultado.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
            }
        }
        public int ModificarCliente(Cliente modificar)
        {
            Cliente c = TraerPorCodigo(modificar.Codigo);
            if (c != null)
            {
                c.Nombre = modificar.Nombre;
                c.Apellido = modificar.Apellido;
                c.Direccion = modificar.Direccion;
                c.Telefono = modificar.Telefono;
                c.Mail = modificar.Mail;
                TransactionResult resultado = _mapper.Update(c);
                if (resultado.IsOk)
                {
                    this.m.ActualizarCache(this.ToString());
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
                    this.m.ActualizarCache(this.ToString());
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
            foreach (Cliente c in this.m.Clientes)
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
