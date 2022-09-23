using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test=Console.ReadLine();
            string[] temp = test.Split(new Char[] { ' ' });
            foreach(string item in temp)
            {
                int num = int.Parse(item);
                Console.WriteLine("Слово= "num[1]);
            }






            Console.WriteLine("Упражнение 2.1");
            Console.Write("Как Вас зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуй, {name}");
            Console.ReadKey();

            Console.WriteLine("Упражнение 2.2");
            try
            {
                Console.WriteLine("Введите число:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число:");
                int b = int.Parse(Console.ReadLine());
                int del = a / b;
                Console.WriteLine($"Результат деления={del}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение");
            }
            Console.ReadKey();

            Console.WriteLine("ДЗ 2.1");
            Console.WriteLine("Введите букву латинского алфавита:");
            string c = Console.ReadLine();
            if (c == "z")
            {
                Console.WriteLine("Следующая буква: а");
            }
            else
            {
                int code = char.Parse(c);
                int cod = code + 1;
                char a = (char)cod;
                Console.WriteLine($"Следующая буква: " + a);

                Console.WriteLine("ДЗ 2.2");
            }
            

            Console.ReadKey();
            Console.WriteLine("Введите первый коэффициент");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй коэффициент");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий коэффициент");
            int C = int.Parse(Console.ReadLine());
            int d = Convert.ToInt32(Math.Sqrt(B * B - 4 * A * C));
            int x1 = (-B + d) / 2 * A;
            int x2 = (-B - d) / 2 * A;
            Console.WriteLine("x1=" + x1);
            Console.WriteLine("x2=" + x2);
            









        }
    }
}
