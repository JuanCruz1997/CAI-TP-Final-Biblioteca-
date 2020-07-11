using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class mapperCliente
    {
        public List<Cliente> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/cliente");
            List<Cliente> lst = MapList(json);
            return lst;
        }
        public  TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Post("/api/v1/cliente", obj);
            TransactionResult resultado = MapResult(json);
            return resultado;

        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("nombre", cliente.Nombre);
            nvc.Add("apellido", cliente.Apellido);
            nvc.Add("direccion", cliente.Direccion);
            nvc.Add("email", cliente.Mail);
            nvc.Add("telefono", cliente.Telefono.ToString());
            //nvc.Add("fechaNacimiento", cliente.);
            //nvc.Add("fechaAlta", cliente);
            nvc.Add("activo", cliente.Activo.ToString());
            //nvc.Add("usuario", cliente);
            //nvc.Add("host", cliente);
            return nvc;
        }
        private TransactionResult MapResult(string json)
        {
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }
    }
}
