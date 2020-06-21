using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private long _telefono;
        private string _mail;
        public string Nombre
        {
            set
            {
                this._nombre = value;
            }
            get
            {
                return this._nombre;
            }
        }
        public string Apellido
        {
            set
            {
                this._apellido = value;
            }
            get
            {
                return this._apellido;
            }
        }
        public string Direccion
        {
            set
            {
                this._direccion = value;
            }
            get
            {
                return this._direccion;
            }
        }
        public long Telefono
        {
            set
            {
                this._telefono = value;
            }
            get
            {
                return this._telefono;
            }
        }
        public string Mail
        {
            set
            {
                this._mail = value;
            }
            get
            {
                return this._mail;
            }
        }
    }
}
