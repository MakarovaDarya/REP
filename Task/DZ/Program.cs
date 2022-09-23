using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Натуральный логарифм");
            double e = Math.E;
            Console.WriteLine(e);
            Console.ReadKey();

            Console.WriteLine("Задание 2. 50 и 10");
            Console.WriteLine(50+"\n"+ 10);
            Console.ReadKey();

            Console.WriteLine("Задание 3.Столбик");
            Random rand = new Random();
            
            for (int i = 1; i < 5; i++)
            {
                int ch = rand.Next();
                Console.WriteLine(ch);
            }
            Console.ReadKey();

            Console.WriteLine("Задание 4");
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + 10);
            Console.ReadKey();

            Console.WriteLine("Задание 5");
            Console.Write("Введите число: ");
            int stor = int.Parse(Console.ReadLine());
            int P = stor * 4;
            Console.WriteLine("Периметр равен " + P);
            Console.ReadKey();


            Console.WriteLine("Задание 6");
            Console.Write("Введите число: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"Радиус окружности = {r}");
            Console.WriteLine("Длина окружности = "+2*Math.PI*r);
            Console.WriteLine("Площадь круга = " + r*r * Math.PI ); 
            Console.ReadKey();


            Console.WriteLine("Задание 7");
            Console.Write("Введите Х: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение косинуса равно " + Math.Cos(x));
            Console.ReadKey();


            Console.WriteLine("Задание 8");
            
            
            Console.ReadKey();

            Console.WriteLine("Задание 9");
            Console.Write("Введите сколько кг яблок вы купили: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите сколько кг конфет вы купили: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите сколько кг печенек вы купили: ");
            double p = double.Parse(Console.ReadLine());
            
            double appleKG = 50;
            double cookieKG = 60;
            double candiesKG = 70;
            double stoimost = A * appleKG + c * cookieKG + p * candiesKG;
            Console.WriteLine("Допустим кг яблок стоит 50р, кг печенек - 60, кг конфет - 70");
            Console.WriteLine("Стоимость всей покупки составляет = " + stoimost);

            Console.ReadKey();

            

            Console.WriteLine("Задание 10");
            Console.WriteLine("Мир" + "\n" + "    " + "Труд" + "\n" + "         " + "Май");
            Console.ReadKey();

            Console.WriteLine("Задание 11");

            Console.ReadKey();

            Console.WriteLine("Задание 12");
            Console.ReadKey();

            Console.WriteLine("Задание 13");
            Console.Write("Введите число: ");
            int chislo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {chislo}");
            Console.ReadKey();


            Console.WriteLine("Задание 14");
            Console.WriteLine("2 кг\n13 17");
            Console.ReadKey();

            Console.WriteLine("Задание 15");
            Random Rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                int Ch = Rand.Next();
                Console.WriteLine(Ch);
            }
            Console.ReadKey();

            Console.WriteLine("Задание 16");
            Console.Write("Введите первый коэфф: ");
            int ax = int.Parse(Console.ReadLine());
            Console.Write("Введите второй коэфф: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите третий коэфф: ");
            int C = int.Parse(Console.ReadLine());

            double D = B * B - 4 * ax * C;
            if (D < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (D == 0)
            {
                double X = -1 * B / 2 * ax;
                Console.WriteLine($"Корень равен {X}");
            }
            else if (D > 0)
            {
                double x1 = (-B + Math.Sqrt(D)) / 2 * ax;
                double x2 = (-B - Math.Sqrt(D)) / 2 * ax;
                Console.WriteLine($"Корни кв уранвения равны {x1} и {x2} ");

            }

            Console.ReadKey();

            Console.WriteLine("Задание 17"); 
            Console.Write("Введите первое число: ");
            int ch1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int ch2 = int.Parse(Console.ReadLine());

            double arifm = (ch1 + ch2) / 2;
            double geom = Math.Sqrt(ch1 * ch2);
            Console.WriteLine($"Среднее арифметичское равно {arifm}, среднее геометрическое равно {geom} ");
            Console.ReadKey();

            Console.WriteLine("Задание 18");
            Console.WriteLine("Введите координаты точек");
            Console.WriteLine("Введите коорд первой точки по х: ");
            int ox1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коорд первой точки по у: ");
            int oy1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коорд второй точки по х: ");
            int ox2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коорд второй точки по у: ");
            int oy2 = int.Parse(Console.ReadLine());
            double rast = Math.Sqrt(Math.Pow((ox1 - ox2), 2) + Math.Pow((oy1 - oy2), 2));
            Console.WriteLine($"Расстояние между точками равно {rast}"); 
            Console.ReadKey();

            Console.WriteLine("Задание 19а");
            Console.WriteLine("Введите значения a, b, c, по порядку");
            int A1= int.Parse(Console.ReadLine());
            int B1 = int.Parse(Console.ReadLine());
            int C1 = int.Parse(Console.ReadLine());
            int BB1 = B1;
            Console.WriteLine($"a={A1}, b={B1}, c={C1}");
            B1 = C1;
            A1 = BB1;
            C1 = A1;
            Console.WriteLine($"{A1} {B1} {C1}");
            Console.WriteLine("Задание 19б");
            BB1 = B1;
            B1 = A1;
            C1 = BB1;
            A1 = C1;
            Console.WriteLine($"{A1} {B1} {C1}");
            Console.ReadKey();

            Console.WriteLine("Задание 20");
            Console.WriteLine("Введите значение n");
            int n = int.Parse(Console.ReadLine());

            int chas = n / 3600;
            int min = (n % 3600) / 60;
            int sec = n / 60;
            Console.WriteLine($"а){chas},б){min},в){sec}");
            Console.ReadKey();

            Console.WriteLine("Задание 21");
            int Pram = 543 * 130;
            int kv = 130 * 130;
            Console.WriteLine(Pram / kv);
            Console.ReadKey();

            Console.WriteLine("Задание 22");
            Console.Write("Введите трехзначное число: ");
            int AA = int.Parse(Console.ReadLine());
            Console.WriteLine($"{AA % 10}{AA / 10}");
            Console.ReadKey();

            Console.WriteLine("Задание 23");
            Console.Write("Введите число большее 999: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"а) число сотен = {(N / 100) % 10}" + "\n" + $"б) число тысяч = {N / 1000}");

            Console.ReadKey();

            Console.WriteLine("Задание 24");
            Console.Write("Введите четырехзначное число: ");
            string CH = Console.ReadLine();
            Console.WriteLine("а)" + CH[3] + CH[2] + CH[1] + CH[0]);
            Console.WriteLine("б)" + CH[1] + CH[0] + CH[3] + CH[2]);
            Console.WriteLine("в)" + CH[0] + CH[2] + CH[1] + CH[3]);
            Console.WriteLine("г)" + CH[2] + CH[3] + CH[0] + CH[1]);
            Console.ReadKey();
            

            Console.WriteLine("Задание 25");
            Console.Write("Введите число трехзначное число n: ");
            string NN = Console.ReadLine();
            int chisloN = int.Parse(NN);

            if (chisloN != 0)
            {
                Console.WriteLine(NN[1] + NN[2] + NN[0]);
            }
            else
            {
                Console.WriteLine("Вывод невозможен");
            }
            Console.ReadKey();

            Console.WriteLine("Задание 26");

            Console.ReadKey();

            Console.WriteLine("Задание 27");
            Console.ReadKey();

            Console.WriteLine("Задание 28");
            Console.ReadKey();

            Console.WriteLine("Задание 29");
            Console.ReadKey();

            Console.WriteLine("Задание 30");
            Console.ReadKey();

            Console.WriteLine("Задание 31");
            Console.ReadKey();

            Console.WriteLine("Задание 32");
            Console.ReadKey();

            Console.WriteLine("Задание 33");
            Console.ReadKey();

            Console.WriteLine("Задание 34");
            Console.ReadKey();



        }
    }
}
