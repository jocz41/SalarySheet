/*
* PRÁCTICA.............: Práctica 6
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario. Controles básicos.
* FECHA de ENTREGA.....: 21 de Diciembre de 2017
*/

namespace Practica_6
{
    class Empleado
    {
        #region Atributos
        private sbyte categoria, numHijos, numTrienios;
        private string nif, nombre;
        #endregion

        #region Constructores
        public Empleado()
        {
            categoria = -1;
            numHijos = -1;
            numTrienios = -1;
            nif = null;
            nombre = null;
        }

        public Empleado(sbyte c, sbyte nH, sbyte nT, string dni, string name)
        {
            categoria = c;
            numHijos = nH;
            numTrienios = nT;
            nif = dni;
            nombre = name;
        }
        #endregion

        #region Propiedades
        public sbyte Categoria
        {
            get => categoria;
        }

        public sbyte NumHijos
        {
            get => numHijos;
        }

        public sbyte NumTrienios
        {
            get => numTrienios;
        }

        public string Nif
        {
            get => nif;
        }

        public string Nombre
        {
            get => nombre;
        }
        #endregion
    }
}
