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
        private DateTime _fechaAlta;
        private Libro _libro;
        private bool _disponible;

        public Ejemplar(int codLibro, double precio)
        {
            this._codigoLibro = codLibro;
            this._precio = precio;
            this._descripcion = string.Empty;
            this._disponible = true;
        }

        [DataMember(Name = "id")]
        public int Codigo { get => _codigo; set => _codigo = value; }
        [DataMember(Name = "idLibro")]
        public int CodigoLibro { get => _codigoLibro; set => _codigoLibro = value; }
        [DataMember(Name = "Observaciones")]
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        [DataMember]
        public double Precio { get => _precio; set => _precio = value; }
        [DataMember]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public Libro Libro { get => _libro; set => _libro = value; }
        public bool Disponible { get => _disponible; set => _disponible = value; }

        public override string ToString()
        {
            string disp = string.Empty;
            if (this._disponible == true)
            {
                disp = "Disponible";
            }
            else
            {
                disp = "Prestado";
            }
            return string.Format("{0}) $ {1, 0.00} - {2}", this._codigo, this._precio, disp);
        }
    }

}
