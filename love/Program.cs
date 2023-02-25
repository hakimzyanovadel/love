using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace love
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, lastNumber;
            int i, ch, nch;

            Console.WriteLine("Введите начало диапазона");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона");
            lastNumber = int.Parse(Console.ReadLine());

            i = firstNumber;

            //счетчик четных чисел
            ch = 0;
            //счетчик нечетных чисел
            nch = 0;

            int sum1 = 0;
            int sum2 = 0;

            while (i >= firstNumber && i <= lastNumber)
            {
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                    ch++;
                }
                else if (i % 2 == 1)
                {
                    sum2 = sum2 + i;
                    nch++;
                }
                i++;
            }
            Console.WriteLine("Количество четных чисел - " + ch);
            Console.WriteLine("Количество нечетных чисел - " + nch);
            Console.WriteLine("Сумма четных чисел - " + sum1);
            Console.WriteLine("Сумма нечетных чисел - " + sum2);
        }
    }
}
