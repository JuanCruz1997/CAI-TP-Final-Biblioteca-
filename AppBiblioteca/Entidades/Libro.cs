using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

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

        public long Isbn { get => _isbn; set => _isbn = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public int Edicion { get => _edicion; set => _edicion = value; }
        public string Editorial { get => _editorial; set => _editorial = value; }
        public int CantPaginas { get => _cantPaginas; set => _cantPaginas = value; }
        public int Año { get => _año; set => _año = value; }
        public string Tema { get => _tema; set => _tema = value; }
        public int StockPermanente { get => _stockPermanente; set => _stockPermanente = value; }
        public int StockDisponible { get => _stockDisponible; set => _stockDisponible = value; }
    }
}
