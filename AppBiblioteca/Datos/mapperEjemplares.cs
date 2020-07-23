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
    public class MapperEjemplares : Mapper<Ejemplar>
    {
        private string URL { get => ConfigurationManager.AppSettings["Ejemplares"]; }
        public override NameValueCollection ReverseMapInsertUpdate(Ejemplar entidad)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("idLibro", entidad.CodigoLibro.ToString());
            nvc.Add("Observaciones", entidad.Descripcion);
            nvc.Add("Precio", entidad.Precio.ToString());
            nvc.Add("FechaAlta", entidad.FechaAlta.ToString());            
            return nvc;
        }
        public override NameValueCollection ReverseMapDelete(Ejemplar entidad)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("id", entidad.Codigo.ToString());
            return nvc;
        }
        public override string GetURL()
        {
            return this.URL;
        }
    }
}
