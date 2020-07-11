using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        private int _codigo;
        [DataMember]
        private string _nombre;
        [DataMember]
        private string _apellido;
        [DataMember]
        private string _direccion;
        [DataMember]
        private long _telefono;
        [DataMember]
        private string _mail;
        [DataMember]
        private bool _activo;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public long Telefono { get => _telefono; set => _telefono = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
