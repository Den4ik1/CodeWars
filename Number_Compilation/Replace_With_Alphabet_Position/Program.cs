using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_With_Alphabet_Position
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {

            string[] soft = { "Microsoft", "Google", "Apple" };
            string[] hard = { "Apple", "IBM", "Samsung" };

            // разность последовательностей
            var result = soft.Except(hard);

            //foreach (string s in result)
             //   Console.WriteLine(s);

            int[] x = { 1, 2, 2, 2, 3 };
            int[] y = { 1 };

            var result1 = x.Except(y).ToArray();

            foreach (var s in result1)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
