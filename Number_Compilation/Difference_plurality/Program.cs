using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_plurality
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 2 };
            int[] b = new int[] { 1 };
            //var res = a.ToList();

            //foreach (int item in b)
            //{
            //    while (res.Contains(item))
            //    { 
            //        res.Remove(item);
            //    }
            //}

            var res = a.Where(x => !b.Contains(x)).ToArray();

            foreach (var item in res)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }

    }
}
