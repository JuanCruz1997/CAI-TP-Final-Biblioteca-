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
        public List<T> TraerTodo(string url)
        {
            string json = WebHelper.Get(url);
            List<T> lst = MapList(json);
            return lst;
        }
        public TransactionResult Insert(string url, T entidad)
        {
            NameValueCollection obj = ReverseMapInsertUpdate(entidad);
            string json = WebHelper.Post(url, obj);
            TransactionResult resultado = MapResult(json);
            return resultado;
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
        public TransactionResult Update(string url, T entidad)
        {
            NameValueCollection obj = ReverseMapInsertUpdate(entidad);
            string result = WebHelper.Put(url, obj);

            TransactionResult resultadoTransaccion = MapResult(result);

            return resultadoTransaccion;
        }

        public TransactionResult Delete(string url, T entidad)
        {
            NameValueCollection obj = ReverseMapDelete(entidad);

            string result = WebHelper.Delete(url, obj);

            TransactionResult resultadoTransaccion = MapResult(result);

            return resultadoTransaccion;
        }

    }
}
