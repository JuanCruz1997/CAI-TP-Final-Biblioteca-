using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int _codigo;
        private DateTime _fechaAlta;
        private bool _activo;
        private List<Cliente> _clientes;
        public int Codigo
        {
            set
            {
                this._codigo = value;
            }
            get
            {
                return this._codigo;
            }
        }
        public DateTime FechaAlta
        {
            set
            {
                this._fechaAlta = value;
            }
            get
            {
                return this._fechaAlta;
            }
        }
        public Boolean Activo
        {
            set
            {
                this._activo = value;
            }
            get
            {
                return this._activo;
            }
        }
        public List<Cliente> ListaClientes
        {
            get
            {
                return this._clientes;
            }
        }
    }
}
