using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private long _isbn;
        private string _titulo;
        private string _autor; //¿Podría ser el tipo de dato Persona?
        private int _edicion;
        private string _editorial;
        private int _cantPaginas;
        private int _año;
        private string _tema;
        private int _stockPermanente;
        private int _stockDisponible;
        private List<Libro> _libros;
        public long ISBN
        {
            set
            {
                this._isbn = value;
            }
            get
            {
                return this._isbn;
            }
        }
        public string Titulo
        {
            set
            {
                this._titulo = value;
            }
            get
            {
                return this._titulo;
            }
        }
        public string Autor
        {
            set
            {
                this._autor = value;
            }
            get
            {
                return this._autor;
            }
        }
        public int Edicion
        {
            set
            {
                this._edicion = value;
            }
            get
            {
                return this._edicion;
            }
        }
        public string Editorial
        {
            set
            {
                this._editorial = value;
            }
            get
            {
                return this._editorial;
            }
        }
        public int CantidadPaginas
        {
            set
            {
                this._cantPaginas = value;
            }
            get
            {
                return this._cantPaginas;
            }
        }
        public int Año
        {
            set
            {
                this._año = value;
            }
            get
            {
                return this._año;
            }
        }
        public string Tema
        {
            set
            {
                this._tema = value;
            }
            get
            {
                return this._tema;
            }
        }
        public int StockPermanente
        {
            set
            {
                this._stockPermanente = value;
            }
            get
            {
                return this._stockPermanente;
            }
        }
        public int StockDisponible
        {
            set
            {
                this._stockDisponible = value;
            }
            get
            {
                return this._stockDisponible;
            }
        }
        public List<Libro> ListaLibros
        {
            get
            {
                return this._libros;
            }
        }
    }
}
