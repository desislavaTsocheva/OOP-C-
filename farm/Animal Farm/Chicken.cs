using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Farm
{
    public class Chicken
    {
        private string name;
        private int age;
        private int eggs;
        public string Name
        {
            get
            {
                if (name.Length < 0)
                {
                    throw new ArgumentException("name can not be empty");
                }
                return this.name; 
            }
            set { this.name = value; }
        }
        public int Age
        {
            get 
            {
                if (age<0 ||age>15)
                {
                    throw new ArgumentException(" age should be between 0 and 15");
                }
                return this.age;
            }
            set { this.age = value; }
        }
        public int Eggs
        {
            get { return this.eggs; }
            set { this.eggs = value; }
        }
        public Chicken(string name, int age, int eggs)
        {
            Name = name;
            Age = age;
            this.eggs = eggs; 
        }
        public void CalsulateEggsForday()
        {
            Console.WriteLine($"Chicken {this.name}, age:{this.age} can produce {this.eggs} per day");
        }
    }
}
