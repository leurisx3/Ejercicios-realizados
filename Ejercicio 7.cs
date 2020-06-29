using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un programa que pida al usuario 10 números,
            //calcule su media y luego muestre los que están por encima de la media.

            int[] nums = new int[10];

            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            int average = (nums[0] + nums[1] + nums[2] + nums[3] + nums[4] + nums[5]
                + nums[6] + nums[7] + nums[8] + nums[9]) / 10;

            Console.WriteLine($"la media es: {average}");

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > average)
                {
                    Console.WriteLine(nums[i]);
                }
            }
        }
    }
}