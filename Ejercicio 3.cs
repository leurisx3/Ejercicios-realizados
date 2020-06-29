using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un programa que almacene los días de la semana en un array y luego mostrarlo.

            string[] daysOfWeek = new string[7];
            DateTime days = DateTime.Now;

            for(int i = 0; i <= 1; i++)
            {
                daysOfWeek[0] = Convert.ToString(days.AddDays(0));
                daysOfWeek[1] = Convert.ToString(days.AddDays(1));
                daysOfWeek[2] = Convert.ToString(days.AddDays(2));
                daysOfWeek[3] = Convert.ToString(days.AddDays(3));
                daysOfWeek[4] = Convert.ToString(days.AddDays(4));
                daysOfWeek[5] = Convert.ToString(days.AddDays(5));
                daysOfWeek[6] = Convert.ToString(days.AddDays(6));
            }

            Array.ForEach(daysOfWeek, Console.WriteLine);
            

        }
    }
}
