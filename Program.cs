using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Degree()
        {
            Console.WriteLine("Введите число, которое хотите возвести в степень: ");
            int result = 1;
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень, в которую хотите возвести число");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int degree = 1; degree < n + 1; ++degree)
            {
                result *= a;
            }
            Console.WriteLine($"Ваш ответ {result}");
        }

        static void removeAndAdd()
        {
            Console.Write("Введите число x (x >= 100): ");
            int x = int.Parse(Console.ReadLine());

            if (x < 100)
            {
                Console.WriteLine("Число должно содержать более двух цифр.");
                return;
            }

            string temp = Convert.ToString(x);
            char secondDigit = temp[1];
            temp = Convert.ToString(x) + secondDigit;
            string answer = temp.Remove(1, 1);
            Console.WriteLine(answer);
        }

        static void Main()
        {
            Console.WriteLine("1. Возведение в степень.\n2. Переместить вторую цифру в конец.\n3. Очистить консоль.\n");

            Console.Write("Введите выбранный пункт: ");
            string UserAnswer = Console.ReadLine();

            switch (UserAnswer)
            {
                case "1":
                    Degree();
                    break;
                case "2":
                    removeAndAdd();
                    break;
                case "3":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("\nВыбранного пункта не существует! Повторите попытку!\n");
                    break;
            }
        }
    }
}