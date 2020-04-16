using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Compilation_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(0, 20);

            List<int> array = new List<int>();
            for (int i = 0; i < n; i++)
            {
                array.Add(rnd.Next(1000));
                Console.Write($"{array[i]} ");
            }

            decimal result = 0;

            while (array.Count != 0)
            {
                int max = array[0];
                foreach (var item in array)
                {
                    if ((item * Convert.ToInt32(Math.Pow(10, max.ToString().Length)) + max) > (max * Convert.ToInt32(Math.Pow(10, item.ToString().Length)) + item))
                    {
                        max = item;
                    }
                }
                array.Remove(max);
                result = result * Convert.ToInt32(Math.Pow(10, max.ToString().Length)) + max;
            }

            Console.WriteLine($"Number = {result}");
            Console.ReadKey();
        }
    }
}
