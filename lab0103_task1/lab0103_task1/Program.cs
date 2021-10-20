using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0103_task1
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I`m studying");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I`m explaining");
        }
    }
    class StudentProfessorTest
    {
        public void Main()
        {
            Console.WriteLine("Person:");
            Person person = new Person();
            person.Greet();
            Console.WriteLine("\nStudent:");
            Student student = new Student();
            student.Greet();
            student.SetAge(19);
            student.Study();
            student.ShowAge();
            Console.WriteLine("\nProfessor:");
            Professor professor = new Professor();
            professor.Greet();
            professor.SetAge(46);
            professor.Explain();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentProfessorTest test = new StudentProfessorTest();
            test.Main();
        }
    }
}
