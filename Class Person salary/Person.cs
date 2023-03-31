using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Person_salary
{
    internal class Person
    {
        private string name;
        private int age;
        private double salary;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public Person(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;   
        }
        public void IncreaseSalary(double percent)
        {
            if (age>30)
            {
                this.salary += salary * percent / 100;
            }
            else
            {
                this.salary+=salary * percent / 200;
            }
        }
    }
}
