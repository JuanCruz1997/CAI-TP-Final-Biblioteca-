using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ServicioEjemplar
    {
        private MapperEjemplares _ejemplarMapper;
        private Master m;     
        

        public ServicioEjemplar(Master m, ServicioLibro sL)
        {
            this._ejemplarMapper = new MapperEjemplares();
            this.m = m;       
            
        }

        public void CargarLibro(List<Ejemplar> ejemplares)
        {            
            foreach (Ejemplar ejem in ejemplares)
            {
                foreach (Libro libro in m.Libros)
                {
                    if(ejem.CodigoLibro == libro.ISBN)
                    {
                        ejem.Libro = libro;
                        break;
                    }
                    
                }
                
            }
                
        }
        
        public void AsignarDisponibilidad(List<Ejemplar> ejemplares, List<Prestamo> prestamos)
        {            
            foreach (Ejemplar ejem in ejemplares)
            {
                ejem.Disponible = true;
                foreach (Prestamo prestamo in prestamos)
                {
                    if (ejem.Codigo == prestamo.IdEjemplar && prestamo.Abierto)
                    {
                        ejem.Disponible = false;
                        break;
                    }
                }
            }
        }
        //Traer sólo por código de libro
        public List<Ejemplar> TraerPorLibro(Libro libro)
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            foreach (Ejemplar ej in m.Ejemplares)
            {
                if(libro.ISBN == ej.CodigoLibro)
                {

                    ejemplares.Add(ej);
                }
            }
            
            m.SL.CalcularStock(ejemplares, libro);
            return ejemplares;
        }

        public List<Ejemplar> TraerTodos()
        {
            List<Ejemplar> ejemplares = _ejemplarMapper.TraerTodos();
            CargarLibro(ejemplares);
            return ejemplares;
        }

        
        public int AltaEjemplar(int codLibro, double precio)
        {
            Ejemplar alta = new Ejemplar(codLibro, precio);

            TransactionResult resultado = _ejemplarMapper.Insert(alta);

            if (resultado.IsOk)
            {
                this.m.ActualizarCache(this.ToString());
                return resultado.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
            }
        }
        public String AltaMultiplesEjemplares(int cantidadAAgregar, int id, double precio)
        {
            int iteraciones = cantidadAAgregar;
            String codigos = string.Empty;
            for (int i = 0; i < iteraciones; i++)
            {
                codigos += (this.AltaEjemplar(id, precio)).ToString() + "\n";
            }
            return codigos;
        }
        public Ejemplar TraerPorCodigo(int codigo)
        {
            foreach(Ejemplar e in m.Ejemplares)
            {
                if (codigo == e.Codigo)
                {
                    return e;
                }
            }
            return null;
        }
        public int ModificarEjemplar(int codigo, double precio, string descripcion)
        {
            Ejemplar ej = TraerPorCodigo(codigo);
            if (ej != null)
            {
                ej.Precio = precio;
                ej.Descripcion = descripcion;
                TransactionResult resultado = _ejemplarMapper.Update(ej);
                if (resultado.IsOk)
                {
                    this.m.ActualizarCache(this.ToString());
                    return resultado.Id;
                }
                else
                {
                    throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
                }
            }
            else
            {
                throw new Exception("Ejemplar inexistente");
            }
        }
    }
}
