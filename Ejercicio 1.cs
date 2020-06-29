using System;

namespace Datos_y_formatos_en_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Un programa que pida al usuario 4 números, los memorice (utilizando una tabla),
            //calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.

            
            int counter = 1;
            int[] number = new int[4];
            int average;

            Console.Write("Introduzca 4 numeros: ");
            number[0] = Convert.ToInt32(Console.ReadLine());

            while (counter != 4)
            {
                counter++;
                Console.Write("Introduzca 4 numeros: ");
                number[1] = Convert.ToInt32(Console.ReadLine());
                counter++;
                Console.Write("Introduzca 4 numeros: ");
                number[2] = Convert.ToInt32(Console.ReadLine());
                counter++;
                Console.Write("Introduzca 4 numeros: ");
                number[3] = Convert.ToInt32(Console.ReadLine());
            }

            average = (number[0] + number[1] + number[2] + number[3]) / 4;
            Console.WriteLine($"La media aritmerica es: {average}");

            Console.WriteLine("Los numero introducidos son: ");
            Array.ForEach(number, Console.WriteLine);
        }
    }
}
