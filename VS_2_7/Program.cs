using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            Console.WriteLine("Задание 1");

            string full_name = "Иванов иван иванович";
            int age = 26;
            string email = "IvanovII@gmail.com";
            float points_programming = 5;
            float points_mathematics = 4.5f;
            float points_physics = 4.3f;

            string data = "Ф.И.О: {0}\n" +
                          "Возраст: {1}\n" +
                          "Email: {2}\n" +
                          "Баллы по программированию: {3}\n" +
                          "Баллы по математике: {4}\n" +
                          "Баллы по физике: {5}\n";

            Console.WriteLine(data, full_name, age, email, points_programming, points_mathematics, points_physics);
            #endregion
            Console.ReadLine();
            #region Exercise 2
            Console.WriteLine("Задание 2");

            float sum = points_programming + points_mathematics + points_physics;
            float points_average = sum / 3;

            data = "Сумма баллов: {0}\n" +
                   "Средний балл: {1}";

            Console.WriteLine(data, sum, points_average);
            #endregion
            Console.ReadLine();
        }
    }
}
