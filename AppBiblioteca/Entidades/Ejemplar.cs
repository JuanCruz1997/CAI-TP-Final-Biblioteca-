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
        [DataMember]
        private int _codigo;
        [DataMember]
        private int _idLibro;
        [DataMember]
        private string _observaciones;
        [DataMember]
        private double _precio;
        [DataMember]
        private DateTime fechaAlta;


        private Libro _libro;

        //revisar [DataMember]
        private bool _estaPrestado;
        

        public int Codigo { get => _codigo; set => _codigo = value; }
        public int IdLibro { get => _idLibro; set => _idLibro = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }


        //revisar
        public Libro Libro { get => _libro; set => _libro = value; }
        public bool EstaPrestado { get => _estaPrestado; set => _estaPrestado = value; }
          }

}
