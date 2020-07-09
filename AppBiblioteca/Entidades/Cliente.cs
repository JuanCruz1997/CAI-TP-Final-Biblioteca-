using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int _codigo;
        private bool _activo;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
