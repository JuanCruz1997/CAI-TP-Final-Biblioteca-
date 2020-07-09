using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    public class Ejemplar : Libro
    {
        private int _codigo;
        private Libro _libro;
        private bool _estaPrestado;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public Libro Libro { get => _libro; set => _libro = value; }
        public bool EstaPrestado { get => _estaPrestado; set => _estaPrestado = value; }
    }
}
