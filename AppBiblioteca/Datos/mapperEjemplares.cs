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
    public class MapperEjemplares
    {
        public List<Ejemplar> TraerPorLibro(int idLibro)
        {
            string json = WebHelper.Get("/api/v1/Biblioteca/Ejemplares/" + idLibro);
            List<Ejemplar> lst = MapList(json);
            return lst;
        }


        public TransactionResult Insert (Ejemplar ejemplar)
        {
            NameValueCollection obj = ReverseMap(ejemplar);
            string json = WebHelper.Post("/api/v1/Biblioteca/Ejemplares", obj);
            TransactionResult resultado = MapResult(json);
            return resultado;

        }
        private List<Ejemplar> MapList(string json)
        {
            List<Ejemplar> lst = JsonConvert.DeserializeObject<List<Ejemplar>>(json);
            return lst;
        }
        private NameValueCollection ReverseMap (Ejemplar ejemplar)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("idLibro", ejemplar.CodigoLibro.ToString());
            nvc.Add("Observaciones", ejemplar.Descripcion);
            nvc.Add("Precio", ejemplar.Precio.ToString());
            
            return nvc;

        }
        private TransactionResult MapResult(string json)
        {
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        } 
    }
}
