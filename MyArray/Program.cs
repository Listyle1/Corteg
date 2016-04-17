using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
}
class Program
{
    public string Array(int[] numbers)//Метод Array принимает массив int[] numbers
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
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return " \nМаксимальное значение: " + max + " \nМинимальное значение: " + min + " \nСреднее значение: " + summ/numbers.Length;
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
        Console.WriteLine(Arg.Array(numbers));//вызов метода и передача ему массива numbers
        Console.ReadKey();
    }
}

