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
        private int _numeroOperacion;
        private int _idCliente;
        private int _idEjemplar;
        private int _plazoPrestamo;
        private DateTime _fechaHoraPrestamo;
        private DateTime _fechaDevolucionReal;
        private Cliente _cliente;
        private Ejemplar _ejemplar;
        private double _precioPactado;
        private bool _abierto;

        [DataMember(Name = "id")]
        public int NumeroOperacion { get => _numeroOperacion; set => _numeroOperacion = value; }
        [DataMember]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember]
        public int IdEjemplar { get => _idEjemplar; set => _idEjemplar = value; }
        [DataMember(Name = "Plazo")]
        public int PlazoPrestamo { get => _plazoPrestamo; set => _plazoPrestamo = value; }
        public int PlazoRestante
        {
            get
            {
                if (Abierto)
                {
                    return (FechaDevolucionTentativa - DateTime.Today).Days; 
                }
                else
                {
                    return 0;
                }

            }
        
        }
        [DataMember(Name ="FechaPrestamo")]
        public DateTime FechaHoraPrestamo { get => _fechaHoraPrestamo; set => _fechaHoraPrestamo = value; }
        [DataMember]
        public DateTime FechaDevolucionTentativa { get => _fechaHoraPrestamo.AddDays(_plazoPrestamo); }
        [DataMember]
        public DateTime FechaDevolucionReal { get => _fechaDevolucionReal; set => _fechaDevolucionReal = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Ejemplar Ejemplar { get => _ejemplar; set => _ejemplar = value; }
        [DataMember]
        public bool Abierto { get => _abierto; set => _abierto = value; }



        public int DiasDeAtraso 
        {
            get
            {
                if(Abierto && DateTime.Today > FechaDevolucionTentativa)
                {
                    return -(FechaDevolucionTentativa - DateTime.Today).Days;
                }
                else
                {
                    return 0;
                }
            }
        }
        public double Deuda { get => Ejemplar.Precio * DiasDeAtraso; }
        public double PrecioPactado { get => _precioPactado; set => _precioPactado = value; }

        public Prestamo(int idCliente, int idEjemplar, int plazo, double precio)
        {
            this.IdCliente = idCliente;
            this.IdEjemplar = idEjemplar;
            this.PlazoPrestamo = plazo;
            this.FechaDevolucionReal = DateTime.MinValue;
            this.FechaHoraPrestamo = DateTime.Today;
            this.PrecioPactado = precio;
            this.Abierto = true;
        }
    }

}
