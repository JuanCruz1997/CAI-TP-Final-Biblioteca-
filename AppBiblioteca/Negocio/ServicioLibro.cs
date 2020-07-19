using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ServicioLibro
    {
        private MapperLibros _mapperLibros;
        private List<Libro> _libros;

        public List<Libro> Libros { get => _libros; set => _libros = value; }

        public ServicioLibro()
        {
            this._mapperLibros = new MapperLibros();
            this._libros = new List<Libro>();
            this._libros = _mapperLibros.TraerTodos();
        }

        public List<Libro> TraerTodos()
        {
            List<Libro> libros = new List<Libro>();
            libros = this._libros;
            return libros;
        }

        public List<Libro> BuscarLibro(string titulo, string autor)
        {
            List<Libro> resultado = new List<Libro>();

            if (titulo == string.Empty && autor == string.Empty)
            {
                return resultado = this.TraerTodos();
            }
            else
            {
                foreach (Libro l in this.TraerTodos())
                {
                    if (l.Titulo != string.Empty || l.Autor != string.Empty)
                    {
                        if (l.Titulo.ToLower().Contains(titulo.ToLower()) && autor == string.Empty)
                        {
                            resultado.Add(l);
                        }
                        else if (titulo == string.Empty && l.Autor.ToLower().Contains(autor.ToLower()))
                        {
                            resultado.Add(l);
                        }
                        else if (l.Titulo.ToLower().Contains(titulo.ToLower()) && l.Autor.ToLower().Contains(autor.ToLower()))
                        {
                            resultado.Add(l);
                        }
                    }
                }
            }

            return resultado;
        }

        public int AltaLibro(string titulo, string autor, int edicion, string editorial, int pags, string tema)
        {
            Libro alta = new Libro(titulo, autor, edicion, editorial, pags, tema);

            TransactionResult resultado = _mapperLibros.Insert(alta);

            if (resultado.IsOk)
            {
                return resultado.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
            }
        }
        public List<Libro> TraerPorCodigo(int codLibro)
        {
            List<Libro> resultado = new List<Libro>();
            foreach(Libro l in this.TraerTodos())
            {
                if (codLibro == l.ISBN)
                {
                    resultado.Add(l);
                    break;
                }
            }
            return resultado;
        }
    }
}
