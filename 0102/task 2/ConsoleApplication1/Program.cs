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
            public static int population_filter;
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
                set { name = Regex.Replace(value, @"[^A-zА-я0-9]+", String.Empty); }
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
                set { location = Regex.Replace(value, @"[^A-zА-я ]+", String.Empty); }
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
                    Console.WriteLine($"Назва: {name}\nГрупа: {group}\nЛокацiя: {location}\nПопуляцiя: {population}\n");
            }
            public bool filter()
            {
                if (population > antelope.population_filter)
                    return true;
                else
                    return false;
            }
        }
        static void Main(string[] args)
        {
            antelope[] Antelope = new antelope[10];
            Antelope[0] = new antelope("Джейран", "A", "Азiя", 30000);
            Antelope[0].display_info();
            Antelope[1] = new antelope("Гну", "B", "Африка", 560000);
            Antelope[1].display_info();
            Antelope[2] = new antelope("Бейза", "H", "Африка", 2500);
            Antelope[2].display_info();
            Antelope[3] = new antelope("Антилопа_4", "H", "Африка", 50000);
            Antelope[3].display_info();
            Antelope[4] = new antelope("Антилопа_5", "A", "Азiя", 10000);
            Antelope[4].display_info();
            Antelope[5] = new antelope("Антилопа_6", "U", "Пiвденна Америка", 70000);
            Antelope[5].display_info();
            Antelope[6] = new antelope("Антилопа_7", "B", "Африка", 180000);
            Antelope[6].display_info();
            Antelope[7] = new antelope("Антилопа_8", "G", "Азiя", 500000);
            Antelope[7].display_info();
            Antelope[8] = new antelope("Антилопа_9", "H", "Пiвденна Америка", 5000);
            Antelope[8].display_info();
            Antelope[9] = new antelope("Антилопа_10", "H", "Африка", 980000);
            Antelope[9].display_info();
            Console.WriteLine("Кiлькiсть об'єктiв в класi: " + antelope.count_of_objects);
            Console.WriteLine("\nВведiть мiнiмальне значення популяцiї для пошуку за критерiєм: ");
            antelope.population_filter = int.Parse(Console.ReadLine());
            Console.WriteLine("Об'єкти, популяцiя яких бiльша, нiж " + antelope.population_filter + ": \n");
            for (int i = 0; i < antelope.count_of_objects; i++)
                if (Antelope[i].filter())
                    Antelope[i].display_info();
        }
    }
}
