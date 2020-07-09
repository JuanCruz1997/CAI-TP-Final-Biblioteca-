using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    public class Prestamo
    {
        private Cliente _cliente;
        private Ejemplar _ejemplar;
        private int _plazoPrestamo;
        private DateTime _fechaHoraPrestamo;
        private DateTime _fechaDevolucionReal;

        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Ejemplar Ejemplar { get => _ejemplar; set => _ejemplar = value; }
        public int PlazoPrestamo { get => _plazoPrestamo; set => _plazoPrestamo = value; }
        public DateTime FechaHoraPrestamo { get => _fechaHoraPrestamo; set => _fechaHoraPrestamo = value; }
        public DateTime FechaDevolucionTentativa { get => _fechaHoraPrestamo.AddDays(_plazoPrestamo); }
        public DateTime FechaDevolucionReal { get => _fechaDevolucionReal; set => _fechaDevolucionReal = value; }
    }
}
