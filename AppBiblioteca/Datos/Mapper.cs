using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

//namespace Datos
//{
//    internal abstract class Mapper
//    {
//        internal List<Type> Traer(Type entidad, string url)
//        {
//            string json = WebHelper.Get(url);
//            List<Type> lst = MapList(json);
//            return lst;
//        }
//        internal TransactionResult Insert(Type entidad, string url, NameValueCollection obj)
//        {
//            //NameValueCollection obj = ReverseMap(entidad);
//            string json = WebHelper.Post(url, obj);
//            TransactionResult resultado = MapResult(json);
//            return resultado;

//        }

//        internal List<Type> MapList(string json)
//        {
//            List<Type> lst = JsonConvert.DeserializeObject<List<Type>>(json);
//            return lst;
//        }
//        internal abstract NameValueCollection ReverseMapInsertUpdate(Type type);
//        internal abstract NameValueCollection ReverseMapDelete(Type type);
     
//        internal TransactionResult MapResult(string json)
//        {
//            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
//            return resultado;
//        }
//        public TransactionResult Update(Type entidad, string url, NameValueCollection obj)
//        {
//           // NameValueCollection obj = ReverseMap(entidad);
//            string result = WebHelper.Put(url, obj);

//            TransactionResult resultadoTransaccion = MapResult(result);

//            return resultadoTransaccion;
//        }

//        internal TransactionResult Delete(Type entidad, string url, NameValueCollection obj)
//        {
//            //NameValueCollection obj = new NameValueCollection();
//            //obj.Add("id", cliente.Codigo.ToString());

//            string result = WebHelper.Delete(url, obj);

//            TransactionResult resultadoTransaccion = MapResult(result);

//            return resultadoTransaccion;
//        }

//    }
//}
