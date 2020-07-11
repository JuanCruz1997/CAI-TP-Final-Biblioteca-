using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Prestamo
    {
        [DataMember(Name = "id")]
        private int _numeroOperacion;
        [DataMember]
        private int _idCliente;
        [DataMember]
        private int _idEjemplar;
        [DataMember]
        private int _plazoPrestamo;
        [DataMember]
        private DateTime _fechaHoraPrestamo;
        //[DataMember]
        //private DateTime _fechaDevolucionTentativa;
        [DataMember]
        private DateTime _fechaDevolucionReal;

        private Cliente _cliente;
        private Ejemplar _ejemplar;

        
        public int NumeroOperacion { get => _numeroOperacion; set => _numeroOperacion = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEjemplar { get => _idEjemplar; set => _idEjemplar = value; }
        public int PlazoPrestamo { get => _plazoPrestamo; set => _plazoPrestamo = value; }
        public DateTime FechaHoraPrestamo { get => _fechaHoraPrestamo; set => _fechaHoraPrestamo = value; }
        public DateTime FechaDevolucionTentativa { get => _fechaHoraPrestamo.AddDays(_plazoPrestamo); }
        public DateTime FechaDevolucionReal { get => _fechaDevolucionReal; set => _fechaDevolucionReal = value; }

        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Ejemplar Ejemplar { get => _ejemplar; set => _ejemplar = value; }

        public int DiasDeAtraso 
        {
            get
            {
                if(FechaDevolucionTentativa>= DateTime.Today)
                {
                    return (int)(FechaDevolucionTentativa - DateTime.Today).TotalDays;
                } else
                {
                    return 0;
                }
            }
        }
        public double Deuda { get => Ejemplar.Precio * DiasDeAtraso; }
    }
}
