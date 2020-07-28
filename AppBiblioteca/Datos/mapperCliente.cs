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
    public class MapperCliente : Mapper<Cliente>
    {
        private string URL { get => ConfigurationManager.AppSettings["Clientes"]; }
        private string ParametroURL { get => ConfigurationManager.AppSettings["Usuario"]; }

        public new List<Cliente> TraerTodo()
        {
            string url = GetURL();
            string json = WebHelper.Get(url + "/"+ParametroURL); //Necesito hacer new porque el comportamiento es distinto por el parámetro de la url
            List<Cliente> lst = MapList(json);
            return lst;
        }
        public override NameValueCollection ReverseMapInsertUpdate(Cliente entidad)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("nombre", entidad.Nombre);
            nvc.Add("apellido", entidad.Apellido);
            nvc.Add("direccion", entidad.Direccion);
            nvc.Add("email", entidad.Mail);
            nvc.Add("telefono", entidad.Telefono.ToString());
            nvc.Add("id", entidad.Codigo.ToString());
            nvc.Add("usuario", entidad.Usuario);
            return nvc;
        }
        public override NameValueCollection ReverseMapDelete(Cliente entidad)
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
