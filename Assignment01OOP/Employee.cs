using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOP
{

    public enum Gender
    {
        F,
        M
    }
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public SecurityLevel SecurityPrivilege { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }

        public Employee(int id, string name, Gender gender, SecurityLevel securityPrivilege, decimal salary, HireDate hireDate)
        {
           
            ID = id;
            Name = name;
            Gender = gender;
            SecurityPrivilege = securityPrivilege;
            Salary = salary;
            HireDate = hireDate;
           
        }

        public override string ToString()
        {
            return $"Employee ID: {ID} :: Name: {Name} :: Gender: {Gender} :: Security Level: {SecurityPrivilege} Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)} Hire Date: {HireDate.ToShortDateString()}";
        }

    }

    public class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            if (!(day < 1 || day > 31 || month < 1 || month > 12 || year < 1))
            {
                Day = day;
                Month = month;
                Year = year;
            }   
        }

        public override string ToString()
        {
            return $"{Day} / {Month} / {Year}";
        }
    }

}
