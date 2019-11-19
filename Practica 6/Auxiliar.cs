/*
* PRÁCTICA.............: Práctica 6
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario. Controles básicos.
* FECHA de ENTREGA.....: 21 de Diciembre de 2017
*/

using System;
using System.Text.RegularExpressions;

namespace Practica_6
{
    class Auxiliar
    {
        #region Lectura

        public static string leerNombre(string valor)
        {
            string mensaje = null;

            if (valor.Length == 0)
            {
                mensaje = "El campo NOMBRE no puede estar vacío";
                valor = null;
            }
            else if (valor.Length > 20)
            {
                mensaje = "El NOMBRE no debe ser más largo de 20 caracteres";
                valor = null;
            }
            else
            {
                Regex letras = new Regex("^[a-zA-z ñÑÀ-ÿ-]+$");

                if (!letras.Match(valor).Success)
                {
                    valor = null;
                    mensaje = "El NOMBRE no debe tener números";
                }
            }
            
            return mensaje;
        }

        public static string leerDNI(string valor)
        {
            string mensaje = null;

            valor = valor.Replace(" ", "");
            valor = valor.Replace("-", "");

            if (valor.Length == 0)
            {
                mensaje = "El campo DNI no puede estar vacío";
                valor = null;
            }
            else if (valor.Length != 9)
            {
                mensaje = "El DNI debe contener 9 caracteres";
                valor = null;
            }
            else if (mensaje == null && !estructuraNIFValida(valor.ToUpper()))
            {
                valor = null;
                mensaje = "El DNI no es correcto";                
            }

            return mensaje;
        }

        private static bool estructuraNIFValida(string s)
        {
            Regex letras = new Regex("^[a-zA-Z]+$");
            Regex numeros = new Regex("^[0-9]+$");
            const string LETRA = "TRWAGMYFPDXBNJZSQVHLCKE";

            bool correcta = false;
            string numero, letra;                    

            numero = s.Substring(0, 8);
            letra = s.Substring(8, 1);

            if (numeros.Match(numero).Success && letras.Match(letra).Success)
            {
                int n = Int32.Parse(numero);
                string c = LETRA[n % 23].ToString();

                correcta = (letra.Equals(c)) ? true : false;
            }

            return correcta;
        }
        
        public static string leerCat(string valor)
        {
            byte n = 0;
            string mensaje = null;

            try
            {
                n = byte.Parse(valor);

                if (n < 1 || n > 3)
                    throw new OverflowException();
            }
            catch (ArgumentNullException)
            {
                mensaje = "El campo CATEGORÍA no puede estar vacío";
            }
            catch (FormatException)
            {
                if (valor.Length == 0)
                    mensaje = "El campo CATEGORÍA no puede estar vacío";
                else
                    mensaje = "El campo CATEGORÍA debe ser un número (1 - 3)";
            }
            catch (OverflowException)
            {
                mensaje = "Fuera de rango (1 - 3)";
            }

            return mensaje;
        }

        public static string leerNum(string valor, string nombre, byte linf, byte lsup)
        {
            byte n = 0;
            string mensaje = null;

            try
            {
                n = byte.Parse(valor);

                if (n < linf || n > lsup)
                    throw new OverflowException();
            }
            catch (ArgumentNullException)
            {
                mensaje = "El campo " + nombre + " no puede estar vacío";
            }
            catch (FormatException)
            {
                if (valor.Length == 0)
                    mensaje = "El campo " + nombre + " no puede estar vacío";
                else
                    mensaje = "El campo " + nombre + " debe ser un número (" + linf + " - " + lsup + ")";
            }
            catch (OverflowException)
            {
                mensaje = nombre + " fuera de rango (" + linf + " - " + lsup + ")";
            }

            return mensaje;
        }
        
        #endregion
    }
}
