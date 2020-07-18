using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class Validaciones
    {
        public static string ValidarString(string palabra)
        {
            int comprobacion = 0;
            if (int.TryParse(palabra, out comprobacion))
            {
                return "";
            }
            else
            {
                return palabra;
            }
        }
        public static int ValidarInt(string numero)
        {
            int comprobacion = 0;
            if (!int.TryParse(numero, out comprobacion))
            {
                return -1;
            }
            else
            {
                return comprobacion;
            }
        }
        public static double ValidarDouble(string numero)
        {
            double comprobacion = 0;
            if (!double.TryParse(numero, out comprobacion))
            {
                return -1;
            }
            else
            {
                return comprobacion;
            }
        }

        public static string StringValidation(string txt, string campo)
        {

            if (int.TryParse(txt, out int result))
            {
                throw new ArgumentException("El valor ingresado en " + campo + " no posee el formato adecuado. Ingreselo nuevamente");
            }
            else
            {
                return txt;
            }

        }

        public static char CharValidation(string txt, string campo)
        {

            if (int.TryParse(txt, out int intResult) || !char.TryParse(txt, out char charResult))
            {
                throw new ArgumentException("El valor ingresado en " + campo + " no posee el formato adecuado. Ingreselo nuevamente");
            }
            else
            {
                return charResult;
            }
        }

        public static int IntValidation(string txt, int min, int max, string campo)
        {
            if(string.IsNullOrEmpty(txt))
            {
                return 0;
            }
            else if (!int.TryParse(txt, out int result))
            {
                throw new ArgumentException("El valor ingresado en " + campo + " no posee el formato adecuado. Ingreselo nuevamente");
            }
            else if (result < min || result > max)
            {
                throw new Exception("El valor ingresado en " + campo + " no se encuentra dentro del rango requerido.\nDebe ingresar un valor entre " + min + " y " + max);
            }
            else
            {
                return result;
            }

        }
        public static double DoubleValidation(string txt, double min, double max, string campo)
        {

            if (string.IsNullOrEmpty(txt))
            {
                return 0;
            }
            else if(!double.TryParse(txt, out double result))
            {
                throw new ArgumentException("El valor ingresado en " + campo + " no posee el formato adecuado. Ingreselo nuevamente");
            }
            else if (result < min || result > max)
            {
                throw new Exception("El valor ingresado en " + campo + " no se encuentra dentro del rango requerido.\nDebe ingresar un valor entre " + min + " y " + max);
            }
            else
            {
                return result;
            }

        }

        public static long LongValidation(string txt, long min, long max, string campo)
        {

            if (string.IsNullOrEmpty(txt))
            {
                return 0;
            }
            else if(!long.TryParse(txt, out long result))
            {
                throw new ArgumentException("El valor ingresado en " + campo + " no posee el formato adecuado. Ingreselo nuevamente");
            }
            else if (result < min || result > max)
            {
                throw new Exception("El valor ingresado en " + campo + " no se encuentra dentro del rango requerido.\nDebe ingresar un valor entre " + min + " y " + max);
            }
            else
            {
                return result;
            }
        }
    }
}
