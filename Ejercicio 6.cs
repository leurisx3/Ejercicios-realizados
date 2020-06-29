using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario la fecha, detallando el día(1 al 31)
            //y el mes(1 = enero, 12 = diciembre), luego muestre en pantalla el número
            //de días que quedan hasta final de año.

            
            var year = DateTime.Now.Year;
            var endOfYear = new DateTime(year, 12, 31);

            Console.Write("Enter a month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day: ");
            int dayUser = Convert.ToInt32(Console.ReadLine());

            var date = new DateTime(year, month, dayUser);

            var daysBetween = endOfYear - date;

            Console.WriteLine($"{date.ToLongDateString()} It needs: {daysBetween.Days} days to ends the year.");
        }
    }
}
