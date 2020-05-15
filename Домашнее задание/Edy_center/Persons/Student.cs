using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Student : Person
    {
        public string faculty { get; set; }
        public string group { get; set; }
        public DateTime Startlearning { get; }
        public int scholarship = 5000;
        public Student(string faculty, string group, DateTime Startlearning, string surname, DateTime DoB)
           : base(surname, DoB)
        {
            this.faculty = faculty;
            this.group = group;
            this.Startlearning = Startlearning;
        }
        public int getLearningDuration()
        {
            DateTime now = DateTime.Today;
            int dur = now.Year - Startlearning.Year;
            if (Startlearning > now.AddYears(-dur)) dur--;
            return (dur);
        }
        public override void getFullInfo()
        {
            base.getFullInfo();
            Console.WriteLine("Студент\n Группа: {0}\n Факультет: {1}\n Длительность обучения: {2}\n Стипендия: {3}\n Возраст: {4}",
                group, faculty, getLearningDuration(), scholarship, getAge());

        }
    }
}
