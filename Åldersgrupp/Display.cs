using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Åldersgrupp
{
    public static class Display
    {
        public static void DisplayPeople(string description, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(description); 
            foreach (var person in people)
            {
                if(filter(person))
                {
                    Console.WriteLine($"{person.Name} ({person.Age} år)"); ;
                }
            }
            Console.WriteLine();
        }
        public static bool IsChild(Person person) => person.Age < 18;

        public static bool IsAdult(Person person) => person.Age >= 18 && person.Age < 65;

        public static bool IsPensioner(Person person) => person.Age >= 65;
    }
}
