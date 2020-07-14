using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ServicioPrestamo
    {
        private MapperPrestamos _prestamoMapper;
        public ServicioPrestamo()
        {
            this._prestamoMapper = new MapperPrestamos();
        }
        //Resuelto así para que no arroje errores, modificar luego con lógica verdadera
        public List<Prestamo> TraerPorCliente(int idCliente)
        {
            List<Prestamo> lista = new List<Prestamo>();
            return lista;
        }
    }
}
