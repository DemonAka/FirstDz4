using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в массиве: ");
            int line = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[line, column];

            Random random = new Random();

            for (int i = 0; i < line ; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i,j] = random.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
