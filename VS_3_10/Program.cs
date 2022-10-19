using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise_1();
            //Exercise_2();
            //Exercise_3();
            //Exercise_4();
            Exercise_5();

            Console.WriteLine("End");
            Console.ReadLine();
        }

        private static void Exercise_1()
        {
            Console.WriteLine("Exercise 1");
            start:
            Console.WriteLine("Введите целое число:");
            try
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) Console.WriteLine($"Число: {x} четное.");
                else Console.WriteLine($"Число: {x} нечетное.");
            }
            catch { Console.WriteLine("Неверный формат ввода, повторите попытку."); goto start; }
        }
        private static void Exercise_2()
        {
            Console.WriteLine("Exercise 2");
            start:
            Console.WriteLine("Сколько карт у вас на руках?");
            try
            {
                int x = int.Parse(Console.ReadLine());
                int sum = 0;
                Console.WriteLine("Введите наминал карты 6,7,8,9,10,J,Q,K,T");
                for (int i = 0; i < x; i++)
                {
                    repeat:
                    string key = Console.ReadLine();

                    switch (key)
                    {
                        case "J": sum += 2; break;
                        case "Q": sum += 3; break;
                        case "K": sum += 4; break;
                        case "T": sum += 11; break;
                        default:
                            try
                            {
                                int n = int.Parse(key);
                                if (n >= 6 && n <= 10) sum += n;
                                else 
                                {
                                    Console.WriteLine("Неверный формат ввода, повторите попытку."); 
                                    goto repeat;
                                }
                            }
                            catch { Console.WriteLine("Неверный формат ввода, повторите попытку."); goto repeat; }
                            break;
                    }
                    Console.WriteLine("Введите следующую карту.");
                }
                Console.WriteLine($"Сумма карт: {sum} вы {(sum > 21 ? "перебрали" : "можно ещё")}");
                Console.ReadLine();
            }
            catch { Console.WriteLine("Неверный формат ввода, повторите попытку."); goto start; }

        }
        private static void Exercise_3()
        {
            Console.WriteLine("Exercise 3");
            start:
            Console.WriteLine("Введите целое число:");
            try
            {
                int x = int.Parse(Console.ReadLine());
                bool trig = true;
                for (int i = 2; i < x; i++)
                {
                    int n = x % i;
                    if (n == 0)
                    {
                        trig = false;
                        break;
                    }
                }
                if (trig) Console.WriteLine($"Число: {x} простое");
                else Console.WriteLine($"Число: {x} сложное");
                Console.ReadLine();
            }
            catch { Console.WriteLine("Неверный формат ввода, повторите попытку."); goto start; }
        }
        private static void Exercise_4()
        {
            Console.WriteLine("Exercise 4");
            start:
            Console.WriteLine("Введите длину последовательности:");
            try
            {
                int x = int.Parse(Console.ReadLine());
                int min = int.MaxValue;

                for (int i = 0; i < x; i++)
                {
                    repeat:
                    try
                    {
                        Console.WriteLine("Введите число:");
                        int n = int.Parse(Console.ReadLine());
                        if (min > n) min = n;
                    }
                    catch { Console.WriteLine("Неверный формат ввода, повторите попытку."); goto repeat; }
                }

                Console.WriteLine($"Минимальное число: {min}");
                Console.ReadLine();
            }
            catch { Console.WriteLine("Неверный формат ввода, повторите попытку."); goto start; }
        }
        private static void Exercise_5()
        {
            Console.WriteLine("Exercise 5");
            start:
            Console.WriteLine("Введите максимальное целое число:");
            try
            {
                int x = int.Parse(Console.ReadLine());
                Random random = new Random();
                int value = random.Next(0, x);

                Console.WriteLine($"Угадайте число от 0 до {x}");
                while (true)
                {
                    repeat:
                    string key = Console.ReadLine();
                    if (key == string.Empty) break;
                    try
                    {
                        int n = int.Parse(key);
                        if (n < value) Console.WriteLine("Меньше");
                        else if (n > value) Console.WriteLine("Больше");
                        else 
                        {
                            Console.WriteLine($"Правильно! Загаданное число {value}");
                            break;
                        }
                    }
                    catch { Console.WriteLine("Неверный формат ввода, повторите попытку."); goto repeat; }
                }
                Console.WriteLine("Конец игры.");
            }
            catch { Console.WriteLine("Неверный формат ввода, повторите попытку."); goto start; }
        }
    }
}
