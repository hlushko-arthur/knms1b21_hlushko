using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        class antelope
        {
            public static int count_of_objects = 0;
            private string name;
            private string group;
            private string location;
            private int population;
            private bool err = false;
            public antelope(string _name, string _group, string _location, int _population)
            {
                Name = _name;
                Group = _group;
                Location = _location;
                Population = _population;
                count_of_objects++;
            }
            public string Name
            {
                get { return name; }
                set { name = Regex.Replace(value, @"[^A-zА-я]+", String.Empty); }
            }
            public string Group
            {
                get { return group; }
                set
                {
                    if (value.Length != 1)
                    {
                        Console.WriteLine("Група повинна мiстити назву з однiєї букви!");
                        err = true;
                    }
                    else
                        group = value;
                }
            }
            public string Location
            {
                get { return location; }
                set { location = Regex.Replace(value, @"[^A-zА-я]+", String.Empty); }
            }
            public int Population
            {
                get { return population; }
                set
                {
                    if (value > 0)
                        population = value;
                    else
                        Console.WriteLine("Популяцiя не може бути вiд'ємною!");
                }
            }
            public void display_info()
            {
                if (!err)
                    Console.WriteLine($"Назва: {name}\nГрупа: {group}\nЛокацiя: {location}\nПопуляцiя: {population}");
            }
        }

        static void Main(string[] args)
        {
            antelope Antelope = new antelope("Джейран", "A", "Азiя", 30000);
            Antelope.display_info();
            antelope Antelope2 = new antelope("Гну", "B", "Африка", 560000);
            Antelope2.display_info();
            Console.WriteLine("Кiлькiсть об'єктiв в класi: " + antelope.count_of_objects);
        }
    }
}
