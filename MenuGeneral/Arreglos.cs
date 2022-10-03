using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Arreglos
    {
        public static void Cadenas()
        {
            Console.WriteLine("Proporciona el nombre completo");
            string nombreCompleto = Console.ReadLine();
            string[] partesNombre = nombreCompleto.Split(' '); // Dividiendo la cadena "mensaje" usando el carácter espaci

            Console.WriteLine("Hola, ");
            Console.WriteLine(partesNombre[0]); //Nombre
            Console.WriteLine(partesNombre[1]); //Primer Apellido
            Console.WriteLine(partesNombre[2]); //Segundo Apellido

            char[] letxlet = partesNombre[1].ToCharArray();

            foreach (char i in letxlet)
            {
                Console.WriteLine(i);
            }

        }
        public static void Enteros()
        {
            int[] num = new int[5];

            int i = 0;
            int Mayor = 0;
            while (i < num.Length) //Cuenta los items dentro un array (arreglo)
            {
                Console.WriteLine("Proporcione un número", i + 1);
                num[i] = int.Parse(Console.ReadLine());
                
                if (num[i] > Mayor)
                {
                    Mayor = num[i];
                }
                i++;
            }
            Console.WriteLine("El numero mayor es " + Mayor);
        }
        public static void ConvierteATipoOperacion()
        {
            Console.WriteLine("\nIntroduzca El Texto A Convertir");
            string TextUser = Console.ReadLine(); //Texto Ususario
            string[] TextUserList = TextUser.Split(' '); //Guarda el texto y corta el texto
            string[] CadenaConvert = new string[TextUserList.Length]; //Lo que almacena la cadena convertida
            int i=0;
            foreach (string Text in TextUserList)
            {
                //char[] CortaPalabra = Text.ToCharArray();
                string TextCovert = Text.First().ToString().ToUpper() + Text.Substring(1);
                CadenaConvert[i] = TextCovert;
                i++;
            }
            Console.WriteLine(String.Join(" ", CadenaConvert));
            
        }


    }
}
