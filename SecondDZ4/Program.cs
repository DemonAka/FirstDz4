using System;

namespace SecondDZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите длинну последовательности : ");
            int legth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последовательно числа через enter : ");
            int[] mas = new int[legth];
            int min = int.MaxValue;

            for (int i = 0; i < legth; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < legth; j++)
            {
                if (mas[j] <= min) min = mas[j];
            }
            Console.WriteLine($"Наименьшее число из данных чисел равно : {min}");
            Console.ReadKey();
        }
    }
}
