using System;

namespace ThirdDZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра отгадай число!!! ");
            Console.WriteLine("Для начала введите максимальное возможное число: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int findNumber = random.Next(0, maxValue);
            Console.WriteLine("Отгадайте число. Введите любое число: ");
            do
            {
                string number = Console.ReadLine();

                if (String.IsNullOrEmpty(number))
                {
                    Console.WriteLine($"ВЫ не смогли найти загаданное число, которое было равна {findNumber}");
                    break;
                }
                else if (Convert.ToInt32(number) == findNumber)
                {
                    Console.WriteLine("Поздравляю, вы отгадали число");

                    break;
                }
                else if (Convert.ToInt32(number) > findNumber) Console.WriteLine("Ваше число, больше загаданного числа");
                else if (Convert.ToInt32(number) < findNumber) Console.WriteLine("Ваше число, меньше загаданного числа");
            } while (true);

            Console.ReadKey();
        }

    }
}
