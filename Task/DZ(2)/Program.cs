using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2_
{
    struct Student
    {
        public string surname;
        public string name;
        public int ident;
        public string dateofB;
        public string category;
        public double alcohol;
        public Student(string surname,string name, int ident, string dateofB, string category, double alcohol)
        {
            this.surname = surname;
            this.name = name;
            this.ident = ident;
            this.dateofB = dateofB;
            this.category = category;
            this.alcohol = alcohol;
        }
        public double Alco()
        {
            return alcohol;
        }
        public void Print()
        {
            Console.WriteLine($"Фамилия:{surname},Имя:{name},Идентификатор:{ident},Дата рождения:{dateofB},Категория:{category}, Объем выпитого алкоголя:{alcohol}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Student student1 = new Student("Агиева", "Лилия", 1, "05.02.2004", "b", 0.8);
            student1.Print();
            Student student2 = new Student("Макарова", "Дарья", 2, "27.04.2004", "b", 0.5);
            student2.Print();
            Student student3 = new Student("Хамидуллина", "Диана", 3, "14.10.2004", "в", 0);
            student3.Print();
            Student student4 = new Student("Вальярова", "Алина", 4, "10.03.2004", "b", 0.5);
            student4.Print();
            Student student5 = new Student("Дания", "Муракаева", 5, "07.06.2004", "с", 0.2);
            student5.Print();
            double allV = student1.Alco() + student2.Alco() + student3.Alco() + student4.Alco() + student5.Alco();
            Console.WriteLine("Общий объем алкоголя: {allV}");
            Console.WriteLine($"Первый студент выпил: {Math.Round(student1.Alco() * 100 / allV, 1)}");
            Console.WriteLine($"Второй студент выпил: {Math.Round(student2.Alco() * 100 / allV, 1)}");
            Console.WriteLine($"Третий студент выпил: {Math.Round(student3.Alco() * 100 / allV, 1)}");
            Console.WriteLine($"Четвертый студент выпил: {Math.Round(student4.Alco() * 100 / allV, 1)}");
            Console.WriteLine($"Пятый студент выпил: {Math.Round(student5.Alco() * 100 / allV, 1)}");




        }
    }
}
