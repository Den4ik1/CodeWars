using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//  1 5 10 50 100 500 1000 
//  I V X  L  C   D   M
namespace Str
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> number = new Dictionary<char, int>(7);
            number.Add('I', 1   );
            number.Add('V', 5   );
            number.Add('X', 10  );
            number.Add('L', 50  );
            number.Add('C', 100 );
            number.Add('D', 500 );
            number.Add('M', 1000);

            string s = "XVI";

            var strArray = s.ToList();
            List<int> strList = new List<int>();

            foreach (var item in strArray)
            {
                strList.Add(number[item]);
            }

            string str = @"{1} 123 {0}";
            string s0 = "srcond";
            string s1 = "First";

            //str = String.Format(str, s0, s1);
            //Console.WriteLine(str);

            foreach (var item in strList)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
