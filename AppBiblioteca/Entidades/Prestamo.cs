using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        private Cliente _cliente;
        private Ejemplar _ejemplar;
        private int _plazoPrestamo;
        private DateTime _fechaHoraPrestamo;
        private DateTime _fechaDevolucionTentativa;
        private DateTime _fechaDevolucionReal;
        private List<Prestamo> _prestamos;
        private List<Prestamo> _prestamosHistoricos;
        public Cliente Nombre
        {
            set
            {
                this._cliente = value;
            }
            get
            {
                return this._cliente;
            }
        }
        public Ejemplar Ejemplar
        {
            set
            {
                this._ejemplar = value;
            }
            get
            {
                return this._ejemplar;
            }
        }
        public int PlazoPrestamo
        {
            set
            {
                this._plazoPrestamo = value;
            }
            get
            {
                return this._plazoPrestamo;
            }
        }
        public DateTime FechaHoraPrestamo
        {
            set
            {
                this._fechaHoraPrestamo = value;
            }
            get
            {
                return this._fechaHoraPrestamo;
            }
        }
        public DateTime FechaDevolucionTentativa
        {
            set
            {
                this._fechaDevolucionTentativa = value;
            }
            get
            {
                return this._fechaDevolucionTentativa;
            }
        }
        public DateTime FechaDevolucionReal
        {
            set
            {
                this._fechaDevolucionReal = value;
            }
            get
            {
                return this._fechaDevolucionReal;
            }
        }
        public List<Prestamo> Prestamos
        {
            get
            {
                return this._prestamos;
            }
        }
        public List<Prestamo> PrestamosHistoricos
        {
            get
            {
                return this._prestamosHistoricos;
            }
        }
    }
}
