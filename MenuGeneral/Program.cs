using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool F = false;
            while (!F)
            {
                try
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\t1.- Cadenas");
                    Console.WriteLine("\t2.- Enteros");
                    Console.WriteLine("\t3.- Convierte Oracion Mayuscula");
                    Console.WriteLine("\t4.- Calculo De Poliza");
                    Console.WriteLine("\t5.- Leer Un Archivo");
                    Console.WriteLine("\t6.- Escribir Un Archivo");
                    Console.WriteLine("\t7.- Calcular ISR");
                    Console.WriteLine("\t8.- Opcion 8");
                    Console.WriteLine("\tF.- Termina");
                    Console.WriteLine("\nSeleccione Una Opcion De La Lista");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            //Console.WriteLine("Ud Seleccionó La Opcion: Hola Mundo");
                            Arreglos.Cadenas();
                            Console.WriteLine("\n");
                            break;
                        case "2":
                            //Console.WriteLine("Ud Seleccionó La Opcion: Conversion Tipo Oracion");
                            Arreglos.Enteros();
                            Console.WriteLine("\n");
                            break;
                        case "3":
                            Arreglos.ConvierteATipoOperacion();
                            //Console.WriteLine("Ud Seleccionó La Opcion 3");
                            Console.WriteLine("\n");
                            break;
                        case "4":
                            Poliza.Presentacion();
                            //Console.WriteLine("Ud Seleccionó La Opcion 4");
                            Console.WriteLine("\n");
                            break;
                        case "5":
                            Archivotxt.Presentacion();
                            //Console.WriteLine("Ud Seleccionó La Opcion 5");
                            Console.WriteLine("\n");
                            break;
                        case "6":
                            Console.WriteLine("Ingrese Su Ruta Del Archivo");
                            string ruta = Console.ReadLine();
                            Console.WriteLine("Seleccione \n1.- Nuevo Registro \n2.-Agregar Registros ");
                            int Registro = int.Parse(Console.ReadLine());
                            bool AddRegistro = Registro == 1 ? false : true;
                            Console.WriteLine("Ingrese el tipo de codificacion \n1.-UTF7 \n2.-UTF8 \n3.-Unicode \n4.-UTF32 \n5.-ASCII");
                            int codificacion = int.Parse(Console.ReadLine());
                            Archivotxt.EscribirTXT(ruta, AddRegistro, codificacion);
                            //Console.WriteLine("Ud Seleccionó La Opcion 6");
                            Console.WriteLine("\n");
                            break;
                        case "7":
                            Console.WriteLine("Ingresa Tu Sueldo Mensual");
                            decimal sueldoMensual = Convert.ToDecimal(Console.ReadLine());
                            ISR.Calcular(sueldoMensual);
                            //Console.WriteLine("Ud Seleccionó La Opcion 7");
                            Console.WriteLine("\n");
                            break;
                            //continue;
                        case "8":
                            Console.WriteLine("Ud Seleccionó La Opcion 8");
                            Console.WriteLine("\n");
                            break;
                            default:
                            Console.WriteLine("Ud Selecciono Una Opcion Incorrecta");
                            break;
                        case "F":
                        case "f":
                            Console.WriteLine("¿Deseas Salir De La Consola? Presiona <ENTER>");
                            Console.WriteLine("\n");
                            F = true;
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
           Console.ReadLine();
        }
    }
}
