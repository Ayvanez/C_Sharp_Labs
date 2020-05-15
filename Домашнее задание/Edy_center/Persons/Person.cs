using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public abstract class Person
    {
        public string surname { get; }
        public DateTime DoB { get; }
        public Person(string surname, DateTime DoB)
        {
            this.surname = surname;
            this.DoB = DoB;
        }
        public int getAge()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - DoB.Year;
            if (DoB > now.AddYears(-age)) age--;
            return (age);
        }
        public virtual void getFullInfo()
        {
            Console.WriteLine("\nФамилия: {0}\n Дата рождения: {1}", surname, DoB);
        }
    }
}
