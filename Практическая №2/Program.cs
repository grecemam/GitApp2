namespace Практическая__2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(
            "Игры:\n" +
            "1. Игра 'Угадай число'\n" +
            "2. Таблица умножения \n" +
            "3. Вывод детителей числа\n" +
            "4. Выход\n");
            Console.WriteLine("Выберите игру");
            int g = Convert.ToInt32(Console.ReadLine());
            if (g == 1)
            {
                FirstGame();
            }
            else if (g == 2)
            {
                SecondGame();
            }
            else if (g == 3)
            {
                ThirdGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        static void FirstGame()
        {
            Console.WriteLine("Компьютер загадал число от 1 до 100, угадайте его!");
            Random rnd = new Random();
            int num = rnd.Next(0, 100);
            {
                while ("я хочу курить" == "я хочу курить")
                {
                    Console.WriteLine("Введите число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a > num)
                    {
                        Console.WriteLine("Надо меньше");
                    }
                    else if (a < num)
                    {
                        Console.WriteLine("Надо больше");
                    }
                    else
                    {
                        Console.WriteLine("Вы угадали число!");
                        break;
                    }
                }
                Console.WriteLine("Загаданное число:" + num);
            }
            Main();
        }
        static void SecondGame()
        {
            int[,] table = new int[9, 9];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] >= 10)
                    {
                        Console.Write(table[i, j] + "    ");
                    }
                    else
                    {
                        Console.Write(table[i, j] + "     ");
                    }
                }
                Console.WriteLine("\n");
            }
            Main();
        }
        static void ThirdGame()
        {
            int num;
            while ("подписывайтесь на мой инст __grecemam__" == "подписывайтесь на мой инст __grecemam__")
            {
                Console.WriteLine("Введите число, для выхода напишите 'выход': ");
                string i = Console.ReadLine();
                if (i.ToLower() == "выход")
                {
                  
                    Main();
                }
                num = Convert.ToInt32(i);
                for (int a = 1; a <= num; a++)
                {
                    if (num % a == 0)
                        Console.Write("{0} ", a);
                }
                Console.WriteLine();
            }
        }
    }
}