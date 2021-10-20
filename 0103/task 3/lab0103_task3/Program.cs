using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0103_task3
{
    class Parent
    {
        DateTime date = DateTime.Today;
        public Parent() { }
        public Parent(DateTime date)
        {
            this.date = date;
        }
        public bool leap_year()
        {
            if (DateTime.IsLeapYear(date.Year))
                return true;
            else
                return false;
        }
        public void increase_date()
        {
            date = date.AddDays(5);
        }
        public void display_info()
        {
            Console.WriteLine($"Date: {date.ToString("dd/MM/yyyy")}");
        }
    }
    class Child : Parent
    {
        private string FIO;
        private string phone_number;
        private DateTime birthday = new DateTime();
        public Child(string FIO, string phone_number, DateTime birthday)
        {
            this.FIO = FIO;
            this.phone_number = phone_number;
            this.birthday = birthday;
        }
        public void count_of_days_to_birthday()
        {
            DateTime today = DateTime.Today;
            DateTime next = birthday.AddYears(today.Year - birthday.Year);
            if (next < today)
            {
                if (!DateTime.IsLeapYear(next.Year + 1))
                    next = next.AddYears(1);
                else
                    next = new DateTime(next.Year + 1, birthday.Month, birthday.Day);
            }
            int numDays = (next - today).Days;
            Console.WriteLine(numDays);
        }
        public void display_info()
        {
            Console.WriteLine($"ПIБ: {FIO}\nНомер телефону: {phone_number}\nДень народження: {birthday.ToString("dd/MM/yyyy")}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(2002, 01, 31);

            Parent parent = new Parent(today);
            Child child = new Child("Глушко Артур Вiкторович", "380969912498", birthday);

        }
    }
}
