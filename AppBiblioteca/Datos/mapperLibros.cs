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
    public class MapperLibros : Mapper<Libro>
    {
        private string URL { get => ConfigurationManager.AppSettings["Libros"]; }
        
        public override NameValueCollection ReverseMapInsertUpdate(Libro entidad)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("titulo", entidad.Titulo);
            nvc.Add("autor", entidad.Autor);
            nvc.Add("edicion", entidad.Edicion.ToString());
            nvc.Add("editorial", entidad.Editorial);
            nvc.Add("paginas", entidad.CantPaginas.ToString());
            nvc.Add("tema", entidad.Tema);
            return nvc;
        }

        public override NameValueCollection ReverseMapDelete(Libro entidad)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("id", entidad.ISBN.ToString());
            return nvc;
        }

        public override string GetURL()
        {
            return this.URL;
        }

    }
}
