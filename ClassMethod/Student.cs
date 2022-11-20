using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;
        public Student(string name, string surname, string group, int point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isGraduated;
        }
        public void StudentAllName()
        {
            Console.WriteLine(Name+" "+Surname);
        }

        public void StudentInfo()
        {
            Console.WriteLine(Name+" "+Surname+" "+Group+" " +Point+" "+IsGraduated);
        }

        public void Mezun()
        {
            if (IsGraduated)
            {
                Console.WriteLine("Telebe Mezun Olub");
            }
            else
            {
                Console.WriteLine("Telebe Mezun Olmayib");
            }
        }


        public void Imtahan()
        {
            if (Point>80)
            {
                Console.WriteLine("Ikinci imtahana girmeye sansiniz var");
            }
            else
            {
                Console.WriteLine("Ikinci imtahana girmeye sansiniz yoxdur");
            }
        }
    }
}
