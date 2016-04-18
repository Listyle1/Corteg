using System;
using System.Text;

namespace MyArray
{
    class Program
    {
        public Tuple<int, int, int> Corteg (int[] numbers)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int summ = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                summ += numbers[i];//сумма элементов массива
                Console.Write(" {0},", numbers[i]);
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                else if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("(Max, Min, Average)");
            return Tuple.Create<int, int, int>(max, min, summ / numbers.Length);
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Random r = new Random();//рандомное значение переменной r
            for (int i = 0; i < numbers.Length; i++)//присваивает каждому эл-ту массива рандомное число от 50 до 100
            {
                numbers[i] = r.Next(50, 100);
            }
            Program Arg = new Program();//Arg экземпляр класса Program
            Console.WriteLine(Arg.Corteg(numbers));//вызов метода и передача ему массива numbers
            Console.ReadKey();
        }
    }
}

