using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Administrator : Person, IEmployee
    {
        public string laboratory { get; set; }
        public DateTime Startjob { get; }
        public Administrator(string laboratory, DateTime Startjob, string surname, DateTime DoB)
            : base(surname, DoB)
        {
            this.laboratory = laboratory;
            this.Startjob = Startjob;
        }
        public int getWorkExp()
        {
            DateTime now = DateTime.Today;
            int exp = now.Year - Startjob.Year;
            if (Startjob > now.AddYears(-exp)) exp--;
            return (exp);
        }
        public int getSalary(string a)
        {
            int experience = getWorkExp();
            return (50000 + experience*5000);
        }
        public override void getFullInfo()
        {
            base.getFullInfo();
            Console.WriteLine("Профессия: Администратор\n Лаборатория: {0}\n Стаж: {1}\n Зарплата: {2}\n Возраст: {3}",
                laboratory , getWorkExp(), getSalary(laboratory), getAge());

        }
    }
}
