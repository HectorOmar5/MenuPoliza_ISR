using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Poliza
    {
        public static PolizaResultado Calcular(DateTime FechaDeInicioVigencia, string TipoPeriodo, int CantidadPeriodos,
            decimal SumaAsegurada, DateTime FechaNacimiento, string GeneroAsegurado)
        {
            PolizaResultado polizaresultado = new PolizaResultado();

          
            decimal[,] tabla =
            {
                {0m,20m,2m,0.05m},
                {21m,30m,2m,0.1m},
                {31m,40m,2m,0.4m},
                {41m,50m,2m,0.05m},
                {51m,60m,2m,0.65m},
                {61m,100m,2m,0.85m},
                {0m,20m,1m,0.05m},
                {21m,30m,1m,0.1m},
                {31m,40m,1m,0.4m},
                {41m,50m,1m,0.055m},
                {51m,60m,1m,0.7m},
                {61m,100m,1m,0.9m}
            };
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            int Genero = GeneroAsegurado == "Masculino" ? 1 : 2;
            decimal factor = 0;
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                if (edad >= tabla[i, 0] & edad <= tabla[i,1] & Genero == tabla[i, 2])
                {
                    factor = (decimal)tabla[i, 3];
                }
            }
            if (TipoPeriodo == "AÑOS" | TipoPeriodo == "AÑO")
            {
                polizaresultado.FechaTermino = FechaDeInicioVigencia.AddYears(CantidadPeriodos);
            }
            else if (TipoPeriodo == "MESES" | TipoPeriodo == "MES")
            {
                polizaresultado.FechaTermino = FechaDeInicioVigencia.AddMonths(CantidadPeriodos);
            }
            else if (TipoPeriodo == "DIAS" | TipoPeriodo == "DIA" | TipoPeriodo == "DÍAS" | TipoPeriodo == "DÍA")
            {
                polizaresultado.FechaTermino = FechaDeInicioVigencia.AddDays(CantidadPeriodos);
            }
            TimeSpan Intervalo = polizaresultado.FechaTermino - FechaDeInicioVigencia;
            
            polizaresultado.Prima = SumaAsegurada * (factor * (Intervalo.Days / 360m));


            return polizaresultado;
        }
        public static void Presentacion()
        {
            Console.WriteLine("Proporciona la fecha de inicio de Vigencia: ");
            DateTime fechainicio = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("Proporciona para cuanto tiempo requieres la póliza (ejemplo 2 años): ");
            string[] periodo = Console.ReadLine().Split(' ');
            string TipoPeriodo = periodo[1];
            int CantidadPeriodos = int.Parse(periodo[0]);

            Console.WriteLine("\n");
            Console.WriteLine("Proporciona la suma asegurada: ");
            decimal SumaAse = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("Proporciona la fecha de Nacimiento del asegurado: ");
            DateTime FechaNac = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("Proporciona el género del asegurado: ");
            string Gene = Convert.ToString(Console.ReadLine());



           PolizaResultado poliza = Calcular(fechainicio, TipoPeriodo.ToUpper(), CantidadPeriodos,
            SumaAse, FechaNac, Gene);

            Console.WriteLine("\n");
            Console.WriteLine($"La Póliza vencerá el: {poliza.FechaTermino.ToString("D")}");

            Console.WriteLine("\n");
            Console.WriteLine("La prima a pagar es: " + poliza.Prima.ToString("C2") );
        }

    }
}
