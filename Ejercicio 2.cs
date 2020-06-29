using System;
using System.Diagnostics.Tracing;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float")
            //y luego los muestre en el orden contrario al que se introdujeron.

            float[] num = new float[5];
            int counter = 1;
            float invert;

            Console.Write("Introduzca 5 numeros reales:  ");
            num[0] = Convert.ToSingle(Console.ReadLine());

            while (counter != 5)
            {
                counter++;
                Console.Write("Introduzca 5 numeros reales:  ");
                num[1] = Convert.ToSingle(Console.ReadLine());
                counter++;
                Console.Write("Introduzca 5 numeros reales:  ");
                num[2] = Convert.ToSingle(Console.ReadLine());
                counter++;
                Console.Write("Introduzca 5 numeros reales:  ");
                num[3] = Convert.ToSingle(Console.ReadLine());
                counter++;
                Console.Write("Introduzca 5 numeros reales:  ");
                num[4] = Convert.ToSingle(Console.ReadLine());
            }

            invert = num[4];
            
            Array.Reverse(num);
            Console.WriteLine("La forma invertida es:");
            Array.ForEach(num, Console.WriteLine);
        }
    }
}
