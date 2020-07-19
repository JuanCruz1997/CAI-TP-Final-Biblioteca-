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
        private int _ISBN;
        private string _titulo;
        private string _autor;
        private int _edicion;
        private string _editorial;
        private int _cantPaginas;
        private string _tema;
        private int _stockPermanente;
        private int _stockDisponible;
        public Libro(string titulo, string autor, int edicion, string editorial, int pags, string tema)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._edicion = edicion;
            this._editorial = editorial;
            this._cantPaginas = pags;
            this._tema = tema;
        }
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

        [DataMember]
        public string Tema { get => _tema; set => _tema = value; }
        public int StockPermanente { get => _stockPermanente; set => _stockPermanente = value; }
        public int StockDisponible { get => _stockDisponible; set => _stockDisponible = value; }
    }
}
