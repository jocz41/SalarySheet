/*
* PRÁCTICA.............: Práctica 6
* NOMBRE y APELLIDOS...: Sara Blanco Muñoz
* CURSO y GRUPO........: 2º DAM
* TÍTULO de la PRÁCTICA: Aplicaciones de Formulario. Controles básicos.
* FECHA de ENTREGA.....: 21 de Diciembre de 2017
*/

using System;

namespace Practica_6
{
    class Nomina
    {
        #region Constantes      
        private const byte PC_ANTIGUEDAD = 4, PC_HORAS_EXTRAS = 1;
        private const double PC_COTIZACION_SS = 4.51, PC_COTIZACION_SD = 1.97;
        #endregion

        #region Atributos
        private Empleado empleadoNomina;
        private DateTime fechaNomina;
        private sbyte numHorasExtras;
        #endregion

        #region Constructores
        public Nomina()
        {
            empleadoNomina = null;
            fechaNomina = default(DateTime);
            numHorasExtras = -1;
        }

        public Nomina(Empleado e, DateTime fecha, sbyte n)
        {
            this.empleadoNomina = e;
            this.fechaNomina = fecha;
            this.numHorasExtras = n;
        }
        #endregion

        #region Propiedades
        internal Empleado EmpleadoNomina
        {
            get => empleadoNomina;
        }
        
        public DateTime FechaNomina
        {
            get => fechaNomina;
        }
        
        public sbyte NumHorasExtras
        {
            get => numHorasExtras;
        }
        #endregion

        #region Métodos

        #region Cotizaciones
        public double cotizacionSegDesc()
        {
            return Math.Round(devengosPagaExtra() * PC_COTIZACION_SD / 100, 2);
        }

        public double cotizacionSegSoc()
        {
            return Math.Round((baseCotizacion() * PC_COTIZACION_SS / 100), 2);
        }
        #endregion

        public double devengosPagaExtra()
        {
            return Math.Round(salarioBase() + importeAntiguedad(), 2);
        }

        #region Importes
        public double importeAntiguedad()
        {
            return Math.Round((EmpleadoNomina.NumTrienios * salarioBase() * PC_ANTIGUEDAD/100), 2);
        }

        public double importeHorasExtras()
        {
            return Math.Round((numHorasExtras*salarioBase()*PC_HORAS_EXTRAS/100), 2);
        }
        #endregion

        public double retencionIRPF()
        {
            double irpf = totalDevengado();

            switch(FechaNomina.Month)
            {
                case 6:
                case 12:
                    irpf += devengosPagaExtra();
                    break;
            }

            return Math.Round(irpf * porcentajeIRPF() / 100, 2);
        }

        public double salarioBase()
        {
            double sal = 0;

            switch(EmpleadoNomina.Categoria)
            {
                case 1:
                    sal = 2500;
                    break;
                case 2:
                    sal = 2000;
                    break;
                case 3:
                    sal = 1500;
                    break;
            }

            return Math.Round(sal, 2);
        }

        #region Totales
        public double totalDescuentos()
        {
            return Math.Round((cotizacionSegSoc()+cotizacionSegDesc()+retencionIRPF()), 2);
        }

        public double totalDevengado()
        {
            double total = salarioBase() + importeAntiguedad() + importeHorasExtras();

            if (fechaNomina.Month == 6 || fechaNomina.Month == 12)
                total += devengosPagaExtra();

            return Math.Round(total, 2);
        }
        #endregion

        #endregion

        #region Métodos Adicionales

        private double porcentajeIRPF()
        {
            double pc = 0;

            switch (EmpleadoNomina.Categoria)
            {
                case 1:
                    pc = 18 - EmpleadoNomina.NumHijos;
                    break;
                case 2:
                    pc = 15 - EmpleadoNomina.NumHijos;
                    break;
                case 3:
                    pc = 12 - EmpleadoNomina.NumHijos;
                    break;
            }

            return (pc < 0) ? 0:pc;
        }

        public double liquidoAPercibir()
        {
            double liquido = totalDevengado() - totalDescuentos();

            return Math.Round(liquido, 2);
        }

        private double baseCotizacion()
        {
            return devengosPagaExtra() * 7 / 6;
        }
        
        #endregion
    }
}
