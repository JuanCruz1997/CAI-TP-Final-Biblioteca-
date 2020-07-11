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
        [DataMember(Name = "id")]
        private int _ISBN;
        [DataMember]
        private string _titulo;
        [DataMember]
        private string _autor; //¿Podría ser el tipo de dato Persona?
        [DataMember]
        private int _edicion;
        [DataMember]
        private string _editorial;
        [DataMember]
        private int _cantPaginas;
        //private int _año;
        [DataMember]
        private string _tema;

        //Calculable, necesitan set y variable? 
        private int _stockPermanente;
        private int _stockDisponible;

        //private List<Libros> ver xq silvio lo puso en agregacion

        // public long Isbn { get => _isbn; set => _isbn = value; }
        public int ISBN { get => _ISBN; set => _ISBN = value; }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public int Edicion { get => _edicion; set => _edicion = value; }
        public string Editorial { get => _editorial; set => _editorial = value; }
        public int CantPaginas { get => _cantPaginas; set => _cantPaginas = value; }
       // public int Año { get => _año; set => _año = value; }
        public string Tema { get => _tema; set => _tema = value; }
        public int StockPermanente { get => _stockPermanente; set => _stockPermanente = value; }
        public int StockDisponible { get => _stockDisponible; set => _stockDisponible = value; }
        }
}
