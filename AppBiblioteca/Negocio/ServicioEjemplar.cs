using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ServicioEjemplar
    {
        private MapperEjemplares _ejemplarMapper;
        private ServicioLibro _librosServicio;
        

        public ServicioEjemplar()
        {
            this._ejemplarMapper = new MapperEjemplares();
            this._librosServicio = new ServicioLibro();
            
            
        }

        public void CargarLibro(List<Ejemplar> ejemplares, int idLibro)
        {
            
            foreach (Ejemplar ejem in ejemplares)
            {
                ejem.Libro = _librosServicio.BuscarPorCodigo(idLibro);
            }
                
        }
        public bool AsignarDisponibilidadIndividual(Ejemplar ej, ServicioPrestamo sp)
        {
            bool disponible = true;
            foreach(Prestamo p in sp.TraerTodosMapper())
            {               
                if (p.IdEjemplar == ej.Codigo)
                {
                    ej.Disponible = false;
                    return disponible = false;
                }
                
            }
            return disponible;
        }
        public void AsignarDisponibilidad(List<Ejemplar> ejemplares, ServicioPrestamo sp)
        {            
            foreach (Ejemplar ejem in ejemplares)
            {
                ejem.Disponible = true;
                foreach (Prestamo prestamo in sp.TraerTodosMapper())
                {
                    if (ejem.Codigo == prestamo.IdEjemplar && prestamo.FechaDevolucionReal == DateTime.MinValue)
                    {
                        ejem.Disponible = false;
                        break;
                    }
                }
            }
        }
        //Traer sólo por código de libro
        public List<Ejemplar> TraerPorLibro(int idLibro)
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            ejemplares = _ejemplarMapper.TraerPorLibro(idLibro);
            CargarLibro(ejemplares, idLibro);
            return ejemplares;
        }

        public List<Ejemplar> ListaCompletaEjemplares()
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            foreach (Libro l in _librosServicio.TraerTodos())
            {
                ejemplares.AddRange(TraerPorLibro(l.ISBN));
            }
            return ejemplares;
        }

        public void CalcularStock(List<Ejemplar> ejemplares, Libro l)
        {
            int disponibles = 0;
            l.StockPermanente = ejemplares.Count;
            foreach (Ejemplar ej in ejemplares)
            {

                if (ej.Libro.ISBN == l.ISBN && ej.Disponible)
                {

                    disponibles += 1;
                        
                }
            }
            l.StockDisponible = disponibles;
        }
        public int AltaEjemplar(int codLibro, double precio)
        {
            Ejemplar alta = new Ejemplar(codLibro, precio);

            TransactionResult resultado = _ejemplarMapper.Insert(alta);

            if (resultado.IsOk)
            {
                return resultado.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
            }
        }
        public String AltaMultiplesEjemplares(int cantidadAAgregar, int id, double precio)
        {
            int iteraciones = cantidadAAgregar;
            String codigos = string.Empty;
            for (int i = 0; i < iteraciones; i++)
            {
                codigos += (this.AltaEjemplar(id, precio)).ToString() + "\n";
            }
            return codigos;
        }
        public Ejemplar TraerPorCodigo(int codigo)
        {
            foreach(Ejemplar e in this.ListaCompletaEjemplares())
            {
                if (codigo == e.Codigo)
                {
                    return e;
                }
            }
            return null;
        }
        public int ModificarEjemplar(int codigo, double precio, string descripcion)
        {
            Ejemplar ej = TraerPorCodigo(codigo);
            if (ej != null)
            {
                ej.Precio = precio;
                ej.Descripcion = descripcion;
                TransactionResult resultado = _ejemplarMapper.Update(ej);
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
                throw new Exception("Ejemplar inexistente");
            }
        }
    }
}
