using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Manager : Person, IEmployee
    {
        public string faculty { get; set; }
        public string position { get; set; }
        public DateTime Startjob { get; }
        public Manager(string faculty, string position, DateTime Startjob, string surname, DateTime DoB)
            : base(surname, DoB)
        {
            this.faculty = faculty;
            this.position = position;
            this.Startjob = Startjob;
        }
        public int getWorkExp()
        {
            DateTime now = DateTime.Today;
            int exp = now.Year - Startjob.Year;
            if (Startjob > now.AddYears(-exp)) exp--;
            return (exp);
        }
        public int getSalary(string position)
        {
            int experience = getWorkExp(); 
            int salary = 0;
            if (position == "junior")
            {
                salary = 22000 + experience * 1000;
            }
            else if (position == "top")
            {
                salary = 40000 + experience * 3000;
            }
            return (salary);
        }
        public override void getFullInfo()
        {
            base.getFullInfo();
            Console.WriteLine("Профессия: Менеджер\n Должность: {0}\n Факультет: {1}\n Стаж: {2}\n Зарплата: {3}\n Возраст: {4}",
                position, faculty, getWorkExp(), getSalary(position), getAge());

        }
    }
}
