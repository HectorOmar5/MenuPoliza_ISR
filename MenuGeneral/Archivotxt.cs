using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace MenuGeneral
{
    internal class Archivotxt
    {
        public static void Mostrartxt(string ruta)
        {
            StreamReader archivo = new StreamReader(ruta);
            Console.WriteLine(archivo.ReadToEnd());
            archivo.Close();

            Console.WriteLine("\n");


        }
        public static void MostrarCSV(string ruta)
        {
            //String UbicacionArchivo = @"C:\Users\Tichs\source\C#\TablaAlumnos.csv";
            StreamReader archivo = new StreamReader(ruta);
            Console.WriteLine(archivo.ReadToEnd());
            archivo.Close();
        }
        public static void Presentacion()
        {
            Console.WriteLine("Teclea La Ruta Del Archivo txt");
            String UbicacionArchivo = Console.ReadLine(); //pedir ruta a usuario
            Mostrartxt(UbicacionArchivo);

            Console.WriteLine("Teclea La Ruta Del Archivo csv");
            String UbicacionArchivo2 = Console.ReadLine(); //pedir ruta a usuario
            MostrarCSV(UbicacionArchivo2);

            Console.WriteLine("Presiona Cualquier Tecla Para continuar...");
            Console.ReadKey();
        }
        public static void EscribirTXT(string ruta, bool AdiRegistros, int TipoCodificacion)
        {

            //@"C:\Users\Tichs\source\C#\Texto1.txt
            Encoding codificacion = Encoding.Default;
            switch (TipoCodificacion)
            {
                case 1:
                    codificacion = Encoding.UTF7;
                    break;
                case 2:
                    codificacion = Encoding.UTF8;
                    break;
                case 3:
                    codificacion = Encoding.Unicode;
                    break;
                case 4:
                    codificacion = Encoding.UTF32;
                    break;
                case 5:
                    codificacion = Encoding.ASCII;
                    break;
            }
            using (StreamWriter Escribetexto = new StreamWriter(ruta, AdiRegistros, codificacion))
            {
                int opcion;
                do
                {
                    Console.WriteLine("Ingrese el nombre del alumno");
                    string nombre = Console.ReadLine().Trim();
                    Console.WriteLine("Ingrese el apellido paterno");
                    string app = Console.ReadLine().Trim();
                    Console.WriteLine("Ingrese el apellido materno");
                    string appm = Console.ReadLine().Trim();
                    Console.WriteLine("Ingrese la edad");
                    int edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el estado del alumno ");
                    string estado = Console.ReadLine().Trim();
                    Escribetexto.WriteLine($"{nombre},{app},{appm},{edad},{estado}");

                    Console.WriteLine("Desea Agregar Un Nuevo Alumno");
                    Console.WriteLine("\t1.- Si");
                    Console.WriteLine("\t2.- No");
                    opcion = int.Parse(Console.ReadLine().Trim());


                }
                while (opcion == 1);

                Escribetexto.Close();
                
            }
        }
    }
}   

