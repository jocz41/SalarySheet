/*
* PRÁCTICA.............: Práctica 6
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario. Controles básicos.
* FECHA de ENTREGA.....: 21 de Diciembre de 2017
*/

using System;
using System.Windows.Forms;

namespace Practica_6
{
    static class Principal
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HojaSalarial());            
        }
    }
}
