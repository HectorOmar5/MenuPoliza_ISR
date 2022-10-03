using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public class ISR
    {
        private static List<ISR> _listISR = new List<ISR>();

        public decimal limInf { get; set; }
        public decimal limSup { get; set; }
        public decimal cuotaFija { get; set; }
        public decimal porExced { get; set; }
        public decimal subsidio { get; set; }

        public static void CargarTabla()
        {
            string[] ArchivosSeparados = new string[5];
            string[] TextoArchivo = File.ReadAllLines(@"C:\Users\Tichs\source\C#\TablaISR.csv");
            foreach (string line in TextoArchivo)
            {
                ISR objitemISR = new ISR();

                ArchivosSeparados = line.Split(',');
                objitemISR.limInf = Convert.ToDecimal(ArchivosSeparados[0]);
                objitemISR.limSup = decimal.Parse(ArchivosSeparados[1]);
                objitemISR.cuotaFija = decimal.Parse(ArchivosSeparados[2]);
                objitemISR.porExced = decimal.Parse(ArchivosSeparados[3]);
                objitemISR.subsidio = decimal.Parse(ArchivosSeparados[4]);

                _listISR.Add(objitemISR); //Agregar objeto a la lista
            }
        }
        public static void Calcular(decimal sueldoMensual)
        {
            decimal sueldoQuincenal = sueldoMensual / 2;

            ISR objitemISR = new ISR();
            foreach ( ISR isr in _listISR)
            {
                if(sueldoQuincenal >= isr.limInf && sueldoQuincenal <= isr.limSup)
                {
                    objitemISR = isr;
                    break;
                }
            }

            decimal resultadoISR = (sueldoQuincenal - objitemISR.limInf) * (objitemISR.porExced / 100);
            decimal impuesto = resultadoISR + objitemISR.cuotaFija + objitemISR.subsidio;

        }
    }
}
