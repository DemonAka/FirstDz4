using System;

namespace FirstDz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в массиве: ");
            int line = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[line, column];
            int sum = 0;
            Random random = new Random();

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(-100, 100);
                    sum = sum + matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех чисел матрицы равна : {sum}");
            Console.ReadKey();
        }
    }
}
