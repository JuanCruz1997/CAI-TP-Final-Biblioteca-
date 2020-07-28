using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Configuration;

namespace Entidades
{
    [DataContract]
    public class Cliente
    {
        private int _codigo;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private string _mail;
        private string _usuario;

        [DataMember(Name ="id")]
        public int Codigo { get => _codigo; set => _codigo = value; }
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember]
        public string Apellido { get => _apellido; set => _apellido = value; }
        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }
        [DataMember]
        public string Telefono { get => _telefono; set => _telefono = value; }
        [DataMember(Name ="email")]
        public string Mail { get => _mail; set => _mail = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }

        //public List<Cliente> Clientes { get => _clientes; set => _clientes = value; }

        public Cliente(string nombre, string apellido, string direccion, string telefono, string mail)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._direccion = direccion;
            this._telefono = telefono;
            this._mail = mail;
            this.Usuario = ConfigurationManager.AppSettings["Usuario"];
        }
    }
}
