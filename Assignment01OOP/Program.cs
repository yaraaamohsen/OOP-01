using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Security.Claims;
using System;

namespace Assignment01OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Part 01*/

            #region 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Write The First Point (x1, y1)");
            //double X1 = double.Parse(Console.ReadLine());
            //double Y1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write The Second Point (x2, y2)");
            //double X2 = double.Parse(Console.ReadLine());
            //double Y2 = double.Parse(Console.ReadLine());

            //Point P01 = new Point(X1, Y1);
            //Point P02 = new Point(X2, Y2);

            //double XDiff = P01.X - P02.X; 
            //double YDiff = P01.Y - P02.Y;

            //double TwoPointsDiff = Math.Sqrt(Math.Pow(XDiff, 2) + Math.Pow(YDiff, 2));
            //Console.WriteLine($"The Distance Between Two Points Is: {TwoPointsDiff}");
            #endregion

            #region 2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Console.WriteLine("Enter The Name Of 1st Person: ");
            //string Name01 = Console.ReadLine();
            //Console.WriteLine("Enter The Age Of 1st Person: ");
            //int Age01 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Name Of 2nd Person: ");
            //string Name02 = Console.ReadLine();
            //Console.WriteLine("Enter The Age Of 2nd Person: ");
            //int Age02 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Name Of 3rd Person: ");
            //string Name03 = Console.ReadLine();
            //Console.WriteLine("Enter The Age Of 3rd Person: ");
            //int Age03 = int.Parse(Console.ReadLine());

            //Person Per01 = new Person(Name01, Age01);
            //Person Per02 = new Person(Name02, Age02);
            //Person Per03 = new Person(Name03, Age03);

            //int OlderPerson = Math.Max(Age01, Math.Max(Age02, Age03));
            //Console.WriteLine(OlderPerson);

            //if (OlderPerson == Per01.GetAge())
            //{
            //    Console.WriteLine($"The Older Person Is : {Per01}");
            //}
            //else if(OlderPerson == Per02.GetAge()) 
            //{ 
            //    Console.WriteLine($"The Older Person Is : {Per02}"); 
            //}
            //else
            //{
            //    Console.WriteLine($"The Older Person Is : {Per01}");
            //}

            #endregion


            /*Part 02*/
            #region 3. Design and implement a Class for the employees in a company:
            /*
                Notes:
                Employee is identified by an ID, Name, security level, salary, hire date and Gender.
                We need to restrict the Gender field to be only M or F [Male or Female]
                Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum.
                We want to provide the Employee Class to represent Employee data in a string Form (override ToString()), display employee salary in a currency format. [Use String.Format() Function].
             */

            //Employee emp = new Employee(1, "Yara", 'F', SecurityLevel.Developer, 10000, DateTime.Now);
            //Console.WriteLine(emp);
            #endregion

            #region 4. Develop a Class to represent the Hiring Date Data: Consisting of fields to hold the day, month and Years.
            // Done In  Employee Class
            #endregion

            #region 5. Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)
            /*
              Notes:
              Implement All the Necessary Member Functions on the Class(Getters, Setters)
              Define all the Necessary Constructors for the Class
              Allow NO RUNTIME errors if the user inputs any data
              Write down all the necessary Properties(Instead of setters and getters)
             */

            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(2, "Yara", 'F', SecurityLevel.DBA, 12000, new DateTime(2020, 5, 20));
            EmpArr[1] = new Employee(3, "Hasnaa", 'F', SecurityLevel.Guest, 8000, new DateTime(2021, 3, 15));
            EmpArr[2] = new Employee(4, "Ahmed", 'M', SecurityLevel.Secretary, 15000, new DateTime(2019, 7, 10));

            foreach (var employee in EmpArr)
            {
                Console.WriteLine(employee);
            }
            #endregion

            #region 6. Sort the employees based on their hire date then Print the sorted array. While sorting(how many times Boxing and Unboxing process has occurred)
            Array.Sort(EmpArr, (x, y) => x.HireDate.CompareTo(y.HireDate));

            Console.WriteLine("Sorted Employees by Hire Date: ");
            foreach (var employee in EmpArr)
            {
                Console.WriteLine(employee);
            }
            #endregion
        }
    }
}
