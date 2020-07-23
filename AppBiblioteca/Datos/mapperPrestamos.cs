using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class MapperPrestamos : Mapper<Prestamo>
    {
        private string URL { get => ConfigurationManager.AppSettings["Prestamos"]; }

        public override NameValueCollection ReverseMapInsertUpdate(Prestamo entidad)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("idCliente", entidad.IdCliente.ToString());
            nvc.Add("idEjemplar", entidad.IdEjemplar.ToString());
            nvc.Add("Plazo", entidad.PlazoPrestamo.ToString());
            nvc.Add("FechaPrestamo", entidad.FechaHoraPrestamo.ToString());
            nvc.Add("FechaDevolucionTentativa", entidad.FechaDevolucionTentativa.ToString());
            nvc.Add("FechaDevolucionReal", entidad.FechaDevolucionReal.ToString());
            nvc.Add("Abierto", entidad.Abierto.ToString());
            nvc.Add("id", entidad.NumeroOperacion.ToString());
            return nvc;
        }

        public override NameValueCollection ReverseMapDelete(Prestamo entidad)
        {
            NameValueCollection obj = new NameValueCollection();
            obj.Add("id", entidad.NumeroOperacion.ToString());
            return obj;
        }      

        public override string GetURL()
        {
            return this.URL;
        }

    }
}
