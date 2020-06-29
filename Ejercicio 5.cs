using System;
using System.Dynamic;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Un programa que almacene en una tabla el número de días que tiene cada mes(de un año no bisiesto),
            //pida al usuario que le indique un mes(ej. 2 para febrero) y un día(ej.el día 15)
            //y diga qué número de día es dentro del año(por ejemplo, el 15 de febrero sería el día número 46,
            //el 31 de diciembre sería el día 365).

            int[] days = { 0, 31, 30, 28 };
            
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


            string[] meses = { "Index0", "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio",
                              "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

 
            //Comienza desde
            //Creo una variable con agno actual
            var year = DateTime.Now.Year;
            var start = new DateTime(year, 1, 1);

            //Pidiendo fecha al usuario

            Console.Write("Enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day: ");
            int dayUser = Convert.ToInt32(Console.ReadLine());

            //Agrendo los valores al metodo DateTime

            var date = new DateTime(year, month, dayUser);
            
            var daysBetween = date - start;

            Console.WriteLine($"{date.ToLongDateString()} would be the day: {daysBetween.Days}");
        }
    }
}