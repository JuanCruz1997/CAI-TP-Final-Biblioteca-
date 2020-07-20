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
    public class MapperPrestamos
    {
        public List<Prestamo> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/Biblioteca/Prestamos");
            List<Prestamo> lst = MapList(json);
            return lst;
        }
        public TransactionResult Insert (Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);
            string json = WebHelper.Post("/api/v1/Biblioteca/Prestamos", obj);
            TransactionResult resultado = MapResult(json);
            return resultado;
        }
        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("idCliente", prestamo.IdCliente.ToString());
            nvc.Add("idEjemplar", prestamo.IdEjemplar.ToString());
            nvc.Add("plazo", prestamo.PlazoPrestamo.ToString());
            nvc.Add("FechaPrestamo", prestamo.FechaHoraPrestamo.ToString());
            nvc.Add("fechaDevolucionTentativa", prestamo.FechaDevolucionTentativa.ToString());
            nvc.Add("fechaDevolucionReal", prestamo.FechaDevolucionReal.ToString());
            return nvc;
        }
        private TransactionResult MapResult (string json)
        {
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

    }
}
