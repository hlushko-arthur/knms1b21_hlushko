using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0103_task2
{
    class User
    {
        protected string name;
        protected int age;
        public void SetName(string nasme)
        {
            name = nasme;
        }
        public string getName()
        {
            return name;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
    }
    class Worker : User
    {
        private int salary;
        public void SetSalary(int salary)
        {
            this.salary = salary;
        }
        public int GetSalary()
        {
            return salary;
        }
    }
    class Student : User
    {
        private int scolarship;
        private int course;
        public int Scolarship
        {
            get { return scolarship; }
            set { scolarship = value; }
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
    }
    class Driver : Worker
    {
        private int driving_xp;
        private char driving_category;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            Worker worker2 = new Worker();
            worker1.SetName("Iван");
            worker1.SetAge(25);
            worker1.SetSalary(1000);

            worker2.SetName("Вася");
            worker2.SetAge(26);
            worker2.SetSalary(2000);

            Console.WriteLine($"Сума зарплат Iвана i Васi: {worker1.GetSalary() + worker2.GetSalary()} грн");

        }
    }
}
