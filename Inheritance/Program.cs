using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            // Student classından student1 nesnesi üretiyoruz.

            Student student1 = new Student();
            student1.Name = "Mehmet";
            student1.SurName = "Göçer";
            student1.StudentNumber = 148;
            Console.WriteLine("Öğrenci 1");
            student1.PrintStudent();

            // Student classından student2 nesnesi üretiyoruz.

            Student student2 = new Student();
            student2.Name = "Zeynep";
            student2.SurName = "Adıgüzel";
            student2.StudentNumber = 440;
            Console.WriteLine("Öğrenci 2");
            student2.PrintStudent();

            // Teacher classından teacher1 nesnesi üretiyoruz.

            Teacher teacher1 = new Teacher();
            teacher1.Name = "Zehra";
            teacher1.SurName = "Güneş";
            teacher1.Salary = 50000;
            Console.WriteLine("Öğretmen 1");
            teacher1.PrintTeacher();

            // Teacher classından teacher2 nesnesi üretiyoruz.

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Cengiz";
            teacher2.SurName = "Kaya";
            teacher2.Salary = 30000;
            Console.WriteLine("Öğretmen 2");
            teacher2.PrintTeacher();
        }
    }
}
