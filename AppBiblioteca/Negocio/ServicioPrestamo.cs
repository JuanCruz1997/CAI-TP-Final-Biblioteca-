using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ServicioPrestamo
    {
        private MapperPrestamos _prestamoMapper;
        private ServicioEjemplar _ejemplarServicio;
        private ServicioCliente _clienteServicio;   
               

        public ServicioPrestamo()
        {
            this._prestamoMapper = new MapperPrestamos();
            this._ejemplarServicio = new ServicioEjemplar();
            this._clienteServicio = new ServicioCliente();
        }
       
        public List<Prestamo> TraerTodos()
        {
            List<Prestamo> lista = new List<Prestamo>();
            lista = _prestamoMapper.TraerTodos();
            
            CargarClientes(lista, _clienteServicio.TraerTodos());
            CargarEjemplares(lista, _ejemplarServicio.ListaCompletaEjemplares());
            
            return lista;
        }
        public List<Prestamo> TraerTodosMapper()
        {
            List<Prestamo> prestamo = this._prestamoMapper.TraerTodos();
            return prestamo;
        }
        public List<Prestamo> BuscarPrestamo(int idCodigoCliente, int idCodigoEjemplar)
        {
            List<Prestamo> resultado = new List<Prestamo>();
            resultado = TraerTodos();

            if (idCodigoCliente == 0 && idCodigoEjemplar == 0)
            {
                return resultado;
            }
            else
            {
                foreach (Prestamo p in resultado)
                {
                    if (p.IdCliente != 0 || p.IdEjemplar != 0)
                    {
                        if (p.IdCliente == idCodigoCliente && idCodigoEjemplar == 0)
                        {
                            resultado.Add(p);
                        }
                        else if (idCodigoCliente == 0 && p.IdEjemplar == idCodigoEjemplar)
                        {
                            resultado.Add(p);
                        }
                        else if (p.IdCliente == idCodigoCliente && p.IdEjemplar == idCodigoEjemplar)
                        {
                            resultado.Add(p);
                        }
                    }
                }
            }                         
            
            return resultado;
        }
        public void CargarEjemplares(List<Prestamo> prestamos, List<Ejemplar> ejemplares)
        {
            foreach (Prestamo pres in prestamos)
            {
                foreach (Ejemplar ejem in ejemplares)
                {
                    if (pres.IdEjemplar == ejem.Codigo)
                    {
                        pres.Ejemplar = ejem;
                    }
                }
            }
        }
        public void CargarClientes(List<Prestamo> prestamos, List<Cliente> clientes)
        {
            foreach (Prestamo pres in prestamos)
            {
                foreach (Cliente c in clientes)
                {
                    if (pres.IdCliente == c.Codigo)
                    {
                        pres.Cliente = c;
                    }
                }
            }
        }


        public int AltaPrestamo(int idCliente, int idEjemplar, int idPlazo, double precio)
        {
            Prestamo alta = new Prestamo(idCliente, idEjemplar, idPlazo, precio);
            
            TransactionResult resultado = _prestamoMapper.Insert(alta);
            if (resultado.IsOk)
            {
                return resultado.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
            }
        }
        public void Devolucion(int codigo, DateTime fechaDevolucion)
        {
            Prestamo p = TraerPorCodigo(codigo);
            if (p != null)
            {
                p.FechaDevolucionReal = fechaDevolucion;
                //Falta la lógica de modificar el prestamo en el servidor.
            }
            else
            {
                throw new Exception("Préstamo inexistente");
            }
        }
        
        public void EliminarPrestamo(int codigo)
        {
            Prestamo p = this.TraerPorCodigo(codigo);
            if (p != null)
            {
                //Lógica de eliminar el prestamo en servidor
            }
            else
            {
                throw new Exception("El préstamo no existe");
            }
        }

        public Prestamo TraerPorCodigo(int codigo)
        {
            foreach (Prestamo p in this.TraerTodos())
            {
                if (codigo == p.NumeroOperacion)
                {
                    return p;
                }
            }
            return null;
        }



    }
}
