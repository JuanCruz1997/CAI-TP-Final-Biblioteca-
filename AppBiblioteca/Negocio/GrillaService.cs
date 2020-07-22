using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class GrillaService
    {
        private Master m;
        public GrillaService(Master m)
        {

            this.m = m;
        }
        public List<PrestamoAdapter> GetListaPrestamosCompleta(int idCodigoCliente, int idCodigoEjemplar)
        {
            List<Prestamo> listaPrestamo = new List<Prestamo>();
            List<PrestamoAdapter> listaPrestamoAdapter = new List<PrestamoAdapter>();

            listaPrestamo = m.SP.BuscarPrestamo(idCodigoCliente, idCodigoEjemplar);
            foreach (Prestamo p in listaPrestamo)
            {
                listaPrestamoAdapter.Add(new PrestamoAdapter(p));
            }

            return listaPrestamoAdapter;
        }
        public List<PrestamoAdapter> GetListaPrestamosAbiertos(int idCodigoCliente, int idCodigoEjemplar)
        {
            List<Prestamo> listaPrestamo = new List<Prestamo>();

            List<PrestamoAdapter> listaPrestamoAdapter = new List<PrestamoAdapter>();

            listaPrestamo = m.SP.BuscarPrestamo(idCodigoCliente, idCodigoEjemplar);
            foreach (Prestamo p in listaPrestamo)
            {
                if(p.Abierto)
                {
                    listaPrestamoAdapter.Add(new PrestamoAdapter(p));
                }
                
            }
            return listaPrestamoAdapter;
        }

    }
}
