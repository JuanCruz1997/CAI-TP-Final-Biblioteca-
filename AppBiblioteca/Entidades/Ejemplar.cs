using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ejemplar : Libro
    {
        private int _codigo;
        private Libro _libro;
        private bool _estaPrestado;
        private List<Ejemplar> _ejemplares;
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
        public Libro Libro
        {
            set
            {
                this._libro = value;
            }
            get
            {
                return this._libro;
            }
        }
        public Boolean EstaPrestado
        {
            set
            {
                this._estaPrestado = value;
            }
            get
            {
                return this._estaPrestado;
            }
        }
        public List<Ejemplar> Ejemplares
        {
            get
            {
                return this._ejemplares;
            }
        }
    }
}
