using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamoAdapter
    {
        private int _codigo;
        private string _nombre;
        private string _apellido;
        private string _titulo;
        private string _autor;
        private DateTime _fechaAltaPrestamo;
        private DateTime _fechaDevolucionPrestamo;
        private int _plazoRestante;
        private int _codigoEjemplar;
        private bool _abierto;

        public PrestamoAdapter(Prestamo p) 
        {
            this.Codigo = p.NumeroOperacion;
            this._nombre = p.Cliente.Nombre;
            this._apellido = p.Cliente.Apellido;
            this._titulo = p.Ejemplar.Libro.Titulo;
            this._autor = p.Ejemplar.Libro.Autor;
            this._fechaAltaPrestamo = p.FechaHoraPrestamo;
            this._plazoRestante = p.PlazoRestante;
            this.FechaAltaPrestamo = p.FechaHoraPrestamo;
            this._fechaDevolucionPrestamo = p.FechaDevolucionReal;
            this._codigoEjemplar = p.IdEjemplar;
            this.Abierto = p.Abierto;
            
        }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public DateTime FechaAltaPrestamo { get => _fechaAltaPrestamo; set => _fechaAltaPrestamo = value; }
        public DateTime FechaDevolucionPrestamo { get => _fechaDevolucionPrestamo; set => _fechaDevolucionPrestamo = value; }
        public int PlazoRestante { get => _plazoRestante; set => _plazoRestante = value; }
        public int CodigoEjemplar { get => _codigoEjemplar; set => _codigoEjemplar = value; }
        public bool Abierto { get => _abierto; set => _abierto = value; }
        public bool Devuelto { get => !Abierto; }
        
    }
}
