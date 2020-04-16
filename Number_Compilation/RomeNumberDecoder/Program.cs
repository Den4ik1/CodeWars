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

            List<int> romeNumber = new List<int>() { 10, 10, 1, 10 };
            //int countList = romeNumber.Count();
            bool haveDuble = false;
            // for (int j = 0; j < romeNumber.Count; j++)
            //{
            while (HvaeD(romeNumber))
            {
                for (int i = 0; i <= romeNumber.Count - 2; i++)
                {
                    int index = 0;
                    int koef = 1;
                        while (romeNumber[index] == romeNumber[index + 1])
                        {
                            index++;
                            koef++;
                        }
                    romeNumber.Add(romeNumber[index] * koef);
                    romeNumber.RemoveRange(0, koef);
                }

                if (romeNumber[0] == 1)
                {
                    if (romeNumber[romeNumber.Count] < 3)
                        romeNumber[romeNumber.Count] += 1;
                    else
                        romeNumber.Add(1);

                }
                else
                {
                    //if (romeNumber[romeNumber.Count] == 1)
                    //    romeNumber[romeNumber.Count] -= 1;
                    //else
                    //    romeNumber.Add(romeNumber[0]);       
                    

                    if (romeNumber[romeNumber.Count - 1].ToString().ToCharArray().Length - romeNumber[0].ToString().ToCharArray().Length == -1)
                    {
                        romeNumber[romeNumber.Count - 1] = romeNumber[0] - romeNumber[romeNumber.Count - 1];
                    }
                    else
                    {
                        romeNumber.Add(1);
                    }
                }

                romeNumber.RemoveRange(0, 1);
            }
            //}

            for(int i = 0; i <= romeNumber.Count - 1; i++)
            {
                if (romeNumber[i] < romeNumber[i + 1])
                {

                }
            }

            foreach (var item in romeNumber)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
