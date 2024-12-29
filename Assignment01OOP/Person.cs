using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOP
{
    internal class Person
    {
        private string name = "";
        private int age = 0;

        public void SetName(string name)
        {
            if(name.Length >= 3 && name.Length <= 20)
            {
                this.name = name;
            }
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetAge(int age)
        {
            if (age > 0 && age < 100)
            {
                this.age = age;
            }
        }
        public int GetAge()
        {
            return this.age;
        }

        public Person(string name, int age)
        {
            SetName(name);  
            SetAge(age);
        }

        public override string ToString()
        {
            return $"Name : {name}, Age : {age}";
        }
    }
}
