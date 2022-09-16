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
            Console.WriteLine("Введите первый коэффициент");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй коэффициент");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий коэффициент");
            int c = int.Parse(Console.ReadLine());
            int d = Convert.ToInt32(Math.Sqrt(b * b - 4 * a * c));
            int x1 = (-b + d) / 2 * a;
            int x2 = (-b - d) / 2 * a;
            Console.WriteLine("x1=" + x1);
            Console.WriteLine("x2=" + x2);
            Console.ReadKey();


        }
    }
}
