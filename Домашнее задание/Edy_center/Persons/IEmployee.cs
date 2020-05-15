using System;

namespace Persons
{
    public interface IEmployee
    {
        DateTime Startjob { get; }
        int getSalary(string position);
        int getWorkExp();
    }
}
