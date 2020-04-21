using System;
using System.Collections.Generic;
using System.Linq;

namespace RomeNumberDecoder
{
    class Program
    {
       
          
        static void Main(string[] args)
        {
            bool HvaeD(List<int> x)
            {
                for (int i = 0; i <= x.Count - 2; i++)
                {
                    if (x[i] == x[i + 1])
                    {
                        return true;
                    }
                }
                return false;
            }

            Dictionary<char, int> number = new Dictionary<char, int>
            {
                {'I', 1   },
                {'V', 5   },
                {'X', 10  },
                {'L', 50  },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000}
            };

            List<int> romeNumber = new List<int>();

            string roman = "XVI";

            List<char> strList = roman.ToList();

            foreach (var item in strList)
            {
                romeNumber.Add(number[item]);
            }

            //Покуда в массиве есть повторяющиеся символы
            while (HvaeD(romeNumber))
             {
                 for (int i = 0; i <= romeNumber.Count - 2; i++)
                 {
                     //Перенос в конец массива суммы повторяющихся подрят символов
                     int index = 0;
                     int koef = 1;
                         while (romeNumber[index] == romeNumber[index + 1])
                         {
                             index++;
                             koef++;
                         }
                     romeNumber.Add(romeNumber[0] * koef);
                     romeNumber.RemoveRange(0, koef);
                 }
                 romeNumber.Add(romeNumber[0]);
                 romeNumber.RemoveAt(0);
             }

            int res = 0;

            while (romeNumber.Count > 1)
            { 
                res = romeNumber[0] < romeNumber[1] ? res - romeNumber[0] : res + romeNumber[0];
                romeNumber.RemoveAt(0);
            }
            res += romeNumber[0];
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
