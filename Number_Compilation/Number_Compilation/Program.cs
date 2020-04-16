using System;

namespace Number_Compilation
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int n = rnd.Next(0, 20);


            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1000);
                Console.Write($"{array[i]} ");
            }

            ListNumbers numbers = new ListNumbers(array);

            decimal number = numbers.MaxNumber();

            Console.WriteLine($"Number = {number}");

            Console.ReadKey();
        }
    }
}
