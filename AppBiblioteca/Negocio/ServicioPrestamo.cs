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
        private Master m;

        public ServicioPrestamo(Master m)
        {
            this._prestamoMapper = new MapperPrestamos();
            this.m = m;

        }
       
        public List<Prestamo> TraerTodos()
        {
            List<Prestamo> lista = new List<Prestamo>();
            lista = _prestamoMapper.TraerTodo();
                        
            m.SE.AsignarDisponibilidad(m.Ejemplares, lista);

            CargarClientes(lista, m.Clientes);
            CargarEjemplares(lista, m.Ejemplares);

            return lista;
        }
        
        public List<Prestamo> BuscarPrestamo(int idCodigoCliente, int idCodigoEjemplar)
        {
            List<Prestamo> resultado = new List<Prestamo>();

            if (idCodigoCliente == 0 && idCodigoEjemplar == 0)
            {
                return m.Prestamos;
            }
            else
            {
                foreach (Prestamo p in m.Prestamos)
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
                        break;
                    }
                }
            }
        }


        public int AltaPrestamo(Prestamo alta)
        {            
            TransactionResult resultado = _prestamoMapper.Insert(alta);
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
        public int Devolucion(int codigo, DateTime fechaDevolucion)
        {
            Prestamo p = TraerPorCodigo(codigo);
            if (p != null)
            {
                p.FechaDevolucionReal = fechaDevolucion;
                p.Abierto = false;
                TransactionResult resultado = _prestamoMapper.Update(p);
                if (resultado.IsOk)
                {
                    this.m.ActualizarCache(this.ToString());
                    return resultado.Id;
                }
                else
                {
                    throw new Exception("Hubo un error en la petición al servidor.Detalle: " + resultado.Error);
                }
            }
            else
            {
                throw new Exception("Préstamo inexistente");
            }
        }
        
        public int EliminarPrestamo(int codigo)
        {
            Prestamo p = this.TraerPorCodigo(codigo);
            if (p != null)
            {
                if ((DateTime.Today - p.FechaHoraPrestamo).Days > 30 )
                {
                    if (p.Abierto)
                    {
                        TransactionResult resultado = _prestamoMapper.Delete(p);
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
                        throw new Exception("No se pueden eliminar los préstamos cuyo ejemplar ya fue devuelto");
                    }   
                }
                else
                {
                    throw new Exception("El préstamo no pudo eliminarse debido a que han pasado 30 días de creado");
                }
                
            }
            else
            {
                throw new Exception("El préstamo no existe");
            }
        }

        public Prestamo TraerPorCodigo(int codigo)
        {
            foreach (Prestamo p in m.Prestamos)
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
