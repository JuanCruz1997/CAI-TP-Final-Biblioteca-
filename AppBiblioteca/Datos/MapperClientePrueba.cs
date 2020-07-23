using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Configuration;

namespace Datos
{
    public class MapperClientePrueba : Mapper<Cliente>
    {
        public string URL { get => ConfigurationManager.AppSettings["Clientes"]; }
        public override NameValueCollection ReverseMapInsertUpdate(Cliente cliente)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("id", cliente.Codigo.ToString());
            nvc.Add("nombre", cliente.Nombre);
            nvc.Add("apellido", cliente.Apellido);
            nvc.Add("direccion", cliente.Direccion);
            nvc.Add("email", cliente.Mail);
            nvc.Add("telefono", cliente.Telefono.ToString());
            return nvc;
        }
        public override NameValueCollection ReverseMapDelete(Cliente cliente)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("id", cliente.Codigo.ToString());
            return nvc;
        }
    }
}
