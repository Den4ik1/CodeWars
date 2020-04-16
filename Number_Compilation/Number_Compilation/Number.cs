using System;

namespace Number_Compilation
{
    class Number
    {
        public decimal Value { get; set; }
        public int CounteNumeral { get; set; }

        public Number()
        { }

        public Number(decimal number)
        {
            Value = number;
            CounteNumeral = CountingNumberSigns((int)number);
        }

        private int CountingNumberSigns(int number)
        {
            int res = 0;

            for (int i = 0; ; i++)
            {
                if (number / Convert.ToInt32(Math.Pow(10, i + 1)) > 0)
                {
                    res++;
                }
                else
                {
                    return res+1;
                }
            }
        }
    }
}
