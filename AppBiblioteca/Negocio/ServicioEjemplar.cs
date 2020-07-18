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
        private List<Ejemplar> _ejemplares;

        public List<Ejemplar> Ejemplares { get => _ejemplares; set => _ejemplares = value; }

        public ServicioEjemplar()
        {
            this._ejemplarMapper = new MapperEjemplares();
            this._librosServicio = new ServicioLibro();
            this._ejemplares = new List<Ejemplar>();
            this._ejemplares = _ejemplarMapper.TraerTodos();
            
        }

        public void CargarLibro(List<Ejemplar> ejemplares, List<Libro> libros)
        {
            foreach (Ejemplar ejem in ejemplares)
            {
                foreach (Libro libro in libros)
                {
                    if (ejem.CodigoLibro == libro.ISBN)
                    {
                        ejem.Libro = libro;
                    }
                }
            }
        }

        public void AsignarDisponibilidad(List<Ejemplar> ejemplares, List<Prestamo> prestamos)
        {
            foreach (Ejemplar ejem in ejemplares)
            {
                foreach (Prestamo prestamo in prestamos)
                {
                    if (ejem == prestamo.Ejemplar)
                    {
                        ejem.Disponible = false;
                        //revisar que el break haga que salga del foreach de prestamos pero que siga evaluando ejemplares
                        break;
                    }
                    else
                    {
                        ejem.Disponible = true;
                    }
                }
            }
        }

        public List<Ejemplar> TraerTodos()
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            ejemplares = _ejemplares;
            CargarLibro(ejemplares, _librosServicio.Libros);
            CalcularStock(ejemplares, _librosServicio.Libros);
            return ejemplares;
        }

        public void CalcularStock(List<Ejemplar> ejemplares, List<Libro> libros)
        {
            foreach (Ejemplar ejem in ejemplares)
            {
                foreach (Libro libro in libros)
                {
                    if (ejem.Libro == libro)
                    {
                        libro.StockPermanente += 1;
                        if (ejem.Disponible)
                        {
                            libro.StockDisponible += 1;
                        }
                        //revisar que el break haga que salga del foreach de libros pero que siga evaluando ejemplares
                        break;
                    }
                }
            }
        }
    }
}
