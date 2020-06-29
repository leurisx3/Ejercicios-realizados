using System;
using System.Linq;

namespace Ejemplo_almacena_dias_en_mes
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Un programa que almacene en una tabla el número de días que tiene cada mes
            //(supondremos que es un año no bisiesto), pida al usuario que le indique un mes
            //(1 = enero, 12 = diciembre)
            //y muestre en pantalla el número de días que tiene ese mes.

            int[] days = new int[4];
            days[1] = 31;
            days[2] = 30;
            days[3] = 28;

            int[] months = new int[13];
            months[1] = days[1];
            months[2] = days[3];
            months[3] = days[1];
            months[4] = days[2];
            months[5] = days[1];
            months[6] = days[2];
            months[7] = days[1];
            months[8] = days[1];
            months[9] = days[2];
            months[10] = days[1];
            months[11] = days[2];
            months[12] = days[1];


            Console.Write("Introduzca un mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El mes es {mes} y tiene {months[mes]} dias");

            //Entiendo que relaciona el valor de (mes) con el array de (months)
        }
    }
}
