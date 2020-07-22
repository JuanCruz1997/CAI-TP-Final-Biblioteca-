using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Master
    {       

        private ServicioCliente sC;
        private ServicioLibro sL;
        private ServicioEjemplar sE;
        private ServicioPrestamo sP;

        private List<Cliente> clientes;
        private List<Libro> libros;
        private List<Ejemplar> ejemplares;
        private List<Prestamo> prestamos;

        public Master()
        {
            this.SC = new ServicioCliente(this);
            this.SL = new ServicioLibro(this);
            this.SE = new ServicioEjemplar(this, SL);
            this.SP = new ServicioPrestamo(this, SE, SC);

            this.Clientes = SC.TraerTodos();
            this.Libros = SL.TraerTodos();
            this.Ejemplares = SE.TraerTodos();
            this.Prestamos = SP.TraerTodos();
        }

        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public List<Libro> Libros { get => libros; set => libros = value; }
        public List<Ejemplar> Ejemplares { get => ejemplares; set => ejemplares = value; }
        public List<Prestamo> Prestamos { get => prestamos; set => prestamos = value; }
        public ServicioCliente SC { get => sC; set => sC = value; }
        public ServicioLibro SL { get => sL; set => sL = value; }
        public ServicioEjemplar SE { get => sE; set => sE = value; }
        public ServicioPrestamo SP { get => sP; set => sP = value; }

        public void ActualizarCache( string servicio)
        {
            if(servicio == SC.ToString())
            {
                SC.TraerTodos();
            } else if (servicio == SL.ToString())
            {
                SL.TraerTodos();
            }else if (servicio == SE.ToString())
            {
                SE.TraerTodos();
            }else if (servicio == SP.ToString())
            {
                SP.TraerTodos();
            }
        }

        



    }
}
