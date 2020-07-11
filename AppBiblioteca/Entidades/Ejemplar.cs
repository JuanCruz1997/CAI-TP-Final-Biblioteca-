using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Ejemplar
    {
        [DataMember(Name = "id")]
        private int _codigo;
        [DataMember(Name = "idLibro")]
        private int _codigoLibro;
        [DataMember(Name = "observaciones")]
        private string _descripcion;
        [DataMember]
        private double _precio;
        [DataMember]
        private DateTime fechaAlta;


        private Libro _libro;

        //revisar [DataMember]
        //private bool _estaPrestado;
        

        public int Codigo { get => _codigo; set => _codigo = value; }
        public int CodigoLibro { get => _codigoLibro; set => _codigoLibro = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }


        //revisar
        /*public Libro Libro { get => _libro; set => _libro = value; }
        public bool EstaPrestado { get => _estaPrestado; set => _estaPrestado = value; }*/
          }

}
