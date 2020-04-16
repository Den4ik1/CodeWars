using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"{1} 123 {0}";
            string s0 = "srcond";
            string s1 = "First";

            str = String.Format(str, s0, s1);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
