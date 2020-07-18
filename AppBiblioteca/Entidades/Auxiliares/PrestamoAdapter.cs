using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamoAdapter
    {
        private string _nombre;
        private string _apellido;
        private string _titulo;
        private string _autor;
        private DateTime _fechaAltaPrestamo;
        private DateTime _fechaDevolucionPrestamo;
        private int _plazoRestante;
        private bool _estado; //ver si se usa
        public PrestamoAdapter(Prestamo p) //No debería recibir un libro, sino el libro del préstamo
        {
            this._nombre = p.Cliente.Nombre;
            this._apellido = p.Cliente.Apellido;
            //No hace falta, accedes al libro del ejemplar desde la propiedad libro asignada al ejemplar
            //this._titulo = p.Libro.Titulo;
            //this._autor = p.Libro.Autor;
            this._titulo = p.Ejemplar.Libro.Titulo;
            this._autor = p.Ejemplar.Libro.Autor;
            this._fechaAltaPrestamo = p.FechaHoraPrestamo;
            this._plazoRestante = p.PlazoPrestamo;
            this._fechaDevolucionPrestamo = p.FechaDevolucionReal;
            
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public DateTime FechaAltaPrestamo { get => _fechaAltaPrestamo; set => _fechaAltaPrestamo = value; }
        public DateTime FechaDevolucionPrestamo { get => _fechaDevolucionPrestamo; set => _fechaDevolucionPrestamo = value; }
        public int PlazoRestante { get => _plazoRestante; set => _plazoRestante = value; }
        public bool Estado { get => _estado; set => _estado = value; }
    }
}
