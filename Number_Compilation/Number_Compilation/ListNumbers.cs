using System;

namespace Number_Compilation
{
    class ListNumbers
    {
        Number[] number;
        public bool Flage { get; set; }

        public ListNumbers(int[] array)
        {
            number = new Number[array.Length];
            //Перенос числового массива в массив Numbers
            for (int i = 0; i < array.Length; i++)
            {
                number[i] = new Number(array[i]);
            }
        }

        public Number this[int index]
        {
            get { return number[index]; }
            set { number[index].Value = value.Value; }
        }

        public decimal CreateNumber(decimal x, Number y)
        {
            //присоединение к числу X число Y
            return x * Convert.ToInt32(Math.Pow(10, y.CounteNumeral)) + y.Value;
        }

        public decimal MaxNumber()
        {
            decimal result = 0;
            //Перебор элементов
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    decimal temp1, temp2;

                    temp1 = CreateNumber(number[i].Value, number[j]);
                    temp2 = CreateNumber(number[j].Value, number[i]);
                    
                    //Сортировка 
                    if (temp1 < temp2)
                    {
                        Number temp = new Number();
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }

                //Добавление i-ого элемента к результату
                result = CreateNumber(result, number[i]);
            }
            //Добавление последнего элемента
            return result = result * Convert.ToInt32(Math.Pow(10, number[number.Length - 1].CounteNumeral)) + number[number.Length - 1].Value;
        }
    }
}
