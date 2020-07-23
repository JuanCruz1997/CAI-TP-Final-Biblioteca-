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
    public abstract class Mapper<T>
    {
        public abstract string GetURL();
        public List<T> TraerTodo()
        {
            string url = GetURL();
            string json = WebHelper.Get(url);
            List<T> lst = MapList(json);
            return lst;
        }
        public TransactionResult Insert(T entidad)
        {
            NameValueCollection obj = ReverseMapInsertUpdate(entidad);
            string url = GetURL();
            string json = WebHelper.Post(url, obj);
            TransactionResult resultado = MapResult(json);
            return resultado;
        }
        public TransactionResult Update(T entidad)
        {
            NameValueCollection obj = ReverseMapInsertUpdate(entidad);
            string url = GetURL();
            string result = WebHelper.Put(url, obj);

            TransactionResult resultadoTransaccion = MapResult(result);

            return resultadoTransaccion;
        }

        public TransactionResult Delete(T entidad)
        {
            NameValueCollection obj = ReverseMapDelete(entidad);
            string url = GetURL();
            string result = WebHelper.Delete(url, obj);

            TransactionResult resultadoTransaccion = MapResult(result);

            return resultadoTransaccion;
        }
        public List<T> MapList(string json)
        {
            List<T> lst = JsonConvert.DeserializeObject<List<T>>(json);
            return lst;
        }
        public abstract NameValueCollection ReverseMapInsertUpdate(T entidad);
        public abstract NameValueCollection ReverseMapDelete(T entidad);

        public TransactionResult MapResult(string json)
        {
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }


    }
}
