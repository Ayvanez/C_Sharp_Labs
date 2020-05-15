using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Teacher : Person, IEmployee
    {
        public string faculty { get; set; }
        public string position { get; set; }
        public int experience { get; set; }
        public DateTime Startjob { get;}
        public Teacher(string faculty, string position, int experience, string surname, DateTime DoB)
            :base(surname, DoB)
        {
            this.faculty = faculty;
            this.position = position;
            this.experience = experience;
        }
        public int getSalary(string position)
        {
            int salary = 0;
            if (position == "assistant")
            {
                salary = 7000 + experience * 1000;
            }
            else if (position == "professor")
            {
                salary = 10000 + experience * 1500;
            }
            else if (position == "docent")
            {
                salary = 20000 + experience * 2000;
            }
            return (salary);
        }
        public override void getFullInfo()
        {
            base.getFullInfo();
            Console.WriteLine("Профессия: Преподаватель\n Должность: {0}\n Факультет: {1}\n Стаж: {2}\n Зарплата: {3}\n Возраст: {4}",
                position, faculty, experience, getSalary(position), getAge());

        }
        public int getWorkExp()
        {
            DateTime now = DateTime.Today;
            int exp = now.Year - Startjob.Year;
            if (Startjob > now.AddYears(-exp)) exp--;
            return (exp);
        }
    }
}
