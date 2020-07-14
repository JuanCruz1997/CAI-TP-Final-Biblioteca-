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
        private ServicioPrestamo _prestamoServicio;
        public GrillaService()
        {
            this._prestamoServicio = new ServicioPrestamo();
        }
        public List<PrestamoAdapter> GetListaPrestamos(List<Cliente> clientes)
        {
            List<PrestamoAdapter> lista = new List<PrestamoAdapter>();
            foreach(Cliente c in clientes)
            {
                List<Prestamo> prestamosXCliente = _prestamoServicio.TraerPorCliente(c.Codigo);
                foreach(Prestamo p in prestamosXCliente)
                {
                    lista.Add(new PrestamoAdapter(c, p));
                }
            }
            return lista;
        }
    }
}
