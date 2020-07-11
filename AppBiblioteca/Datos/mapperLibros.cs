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
    class MapperLibros
    {
        public List<Libro> TraerTodos()
        {
            string json = WebHelper.Get("api/v1/Biblioteca/Libros");
            List<Libro> lst = MapList(json);
            return lst;
        }
        public TransactionResult Insert(Libro libro)
        {
            NameValueCollection obj = ReverseMap(libro);
            string json = WebHelper.Post("api/v1/Biblioteca/Libros", obj);
            TransactionResult resultado = MapResult(json);
            return resultado;
        }
        private List<Libro> MapList(string json)
        {
            List<Libro> lst = JsonConvert.DeserializeObject<List<Libro>>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(Libro libro)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("titulo", libro.Titulo);
            nvc.Add("autor", libro.Autor);
            nvc.Add("edicion", libro.Edicion.ToString());
            nvc.Add("editorial", libro.Editorial);
            nvc.Add("paginas", libro.CantPaginas.ToString());
            nvc.Add("temas", libro.Tema);
            return nvc;
        }
        private TransactionResult MapResult (string json)
        {
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }
    }
}
