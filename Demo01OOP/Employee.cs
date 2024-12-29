using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01OOP
{
    internal struct Employee
    {
        private int id = 1; // make it Read Only Attribute
        private string name;
        private double salary;
        #region Apply Encapsulation User Setter Getter Method
        // Apply Encapsulation User Setter Getter Method

        // Setter 
        public void SetId(int id)
        {
            //id = id; // Consider Both As Parameter
            this.id = id;
        }

        // Getter
        public int GetId()
        {
            return this.id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
        public double GetSalary()
        {
            return this.salary;
        }

        #endregion
        public Employee(int id, string name, double salary)
        {
            //SetId(id);
            SetName(name);
            SetSalary(salary);
        }

        public override string ToString()
        {
            return $"Id: {id} :: Name: {name} :: Salary: {salary}";
        }
    }

}
