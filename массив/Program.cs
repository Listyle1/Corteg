using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Random r = new Random();
            int max = int.MinValue;
            int min = int.MaxValue;
            int Mid = 0;
            for (int i=0; i<numbers.Length; i++)
            {
                numbers[i] = r.Next(50, 100);
                Console.Write("{0},", numbers[i]);
                Mid += numbers[i];
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("\nМаксимальное значение массива: {0}", max);
            Console.WriteLine("Минимальное значение массива: {0}", min);
            Console.WriteLine("Среднеарифметическое значение массива: {0}", Mid/numbers.Length);
            Console.ReadKey();

        }
    }
}
