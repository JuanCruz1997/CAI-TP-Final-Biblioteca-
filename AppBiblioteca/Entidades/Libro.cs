using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Libro
    {
        //private long _isbn;
        private int _ISBN;
        private string _titulo;
        private string _autor;
        private int _edicion;
        private string _editorial;
        private int _cantPaginas;
        //private int _año;
        private string _tema;

        //Calculable, necesitan set y variable? 
        private int _stockPermanente;
        private int _stockDisponible;

        //private List<Libros> ver xq silvio lo puso en agregacion

        // public long Isbn { get => _isbn; set => _isbn = value; }
        [DataMember(Name = "id")]
        public int ISBN { get => _ISBN; set => _ISBN = value; }
        [DataMember]
        public string Titulo { get => _titulo; set => _titulo = value; }
        [DataMember]
        public string Autor { get => _autor; set => _autor = value; }
        [DataMember]
        public int Edicion { get => _edicion; set => _edicion = value; }
        [DataMember]
        public string Editorial { get => _editorial; set => _editorial = value; }
        [DataMember(Name ="Paginas")]
        public int CantPaginas { get => _cantPaginas; set => _cantPaginas = value; }
        // public int Año { get => _año; set => _año = value; }
        [DataMember]
        public string Tema { get => _tema; set => _tema = value; }
        public int StockPermanente { get => _stockPermanente; set => _stockPermanente = value; }
        public int StockDisponible { get => _stockDisponible; set => _stockDisponible = value; }
        }
}
