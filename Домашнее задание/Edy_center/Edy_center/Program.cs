using System;
using System.Collections.Generic;
using Persons;

namespace Edy_center
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("ИКС", "К3121", new DateTime(2019, 9, 1), "Михайлов", new DateTime(2001, 6, 7));
            Teacher tch = new Teacher("Радиотехника", "professor", 5, "Газманов", new DateTime(1975, 5, 10));
            Administrator admin = new Administrator("Lab1", new DateTime(2011, 5, 1), "Воронин", new DateTime(1991, 12, 12));
            Manager mng = new Manager("Прикладная информатика", "top", new DateTime(2015, 9, 1), "Арутенян", new DateTime(1987, 2, 24));
            List<Person> itlist = new List<Person>();
            itlist.AddRange(new Person[] { st, tch, admin, mng});
            foreach (Person x in itlist)
            {
                x.getFullInfo();
            }
        }
    }
}
