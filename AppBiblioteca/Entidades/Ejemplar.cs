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
        private int _codigo;
        private int _codigoLibro;
        private string _descripcion;
        private double _precio;
        private DateTime fechaAlta;
        private Libro _libro;
        private bool disponible;

        //revisar [DataMember]
        //private bool _estaPrestado;

        [DataMember(Name = "id")]
        public int Codigo { get => _codigo; set => _codigo = value; }
        [DataMember(Name = "idLibro")]
        public int CodigoLibro { get => _codigoLibro; set => _codigoLibro = value; }
        [DataMember(Name = "Observaciones")]
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        [DataMember]
        public double Precio { get => _precio; set => _precio = value; }
        [DataMember]
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public Libro Libro { get => _libro; set => _libro = value; }
        public bool Disponible { get => disponible; set => disponible = value; }


    }

}
