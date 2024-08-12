using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BasePerson
    {

        private string name; // BasePerson classından name field
        private string surName; // BasePerson classından surName field

        public string Name // BasePerson classından Name property
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string SurName // BasePerson classından SurName property
        {
            get
            {
                return surName;
            }
            set
            {
                surName = value;
            }
        }

        public void PrintPerson() // BasePerson için metot
        {
            Console.WriteLine($"Hoşgeldiniz {name} {surName}");
        }

    }

    public class Student : BasePerson // BasePerson'a ait özellikleri Student'a inheritance özellliği ile aktarıyoruz.
    {
        private int studentNumber; // Student classından studentNumber field

        public int StudentNumber // Student classından StudentNumber property
        {
            get
            {
                return studentNumber;
            }
            set
            {
                studentNumber = value;
            }
        }

        public void PrintStudent() // Student için metot
        {
            PrintPerson(); // BasePerson'dan alınan metot
            Console.WriteLine($"Öğrenci numaranız {studentNumber}\n");
            
        }
    }

    public class Teacher : BasePerson // BasePerson'a ait özellikleri Teacher'a inheritance özellliği ile aktarıyoruz.
    {
        private int salary; // Student classından salary field

        public int Salary // Student classından Salary property
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public void PrintTeacher() // Teacher için metot
        {
            PrintPerson(); // BasePerson'dan alınan metot
            Console.WriteLine($"Öğretmen maaşınız {salary}\n");
        }
    }

}
