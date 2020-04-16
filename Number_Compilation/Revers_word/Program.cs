using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revers_word
{
    class Program
    {
        static void Main(string[] args)
        {


            string addToResult(int countElement, string element)
            {
                if (countElement > 4)
                {
                    return new string(element.Reverse().ToArray());
                }
                return element;
            }

            string str = "This is another test";
            string word = "";
            string result = "";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                    count++;
                }
                else
                {
                    result += addToResult(count, word) + " ";
                    word = "";
                    count = 0;
                }
            }
            result += addToResult(count, word);



            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
