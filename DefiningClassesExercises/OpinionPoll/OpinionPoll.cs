using System;
using System.Linq;
using System.Collections.Generic;

namespace OpinionPoll
{
    public class OpinionPoll
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);

                var person = new Person();
                person.name = name;
                person.age = age;
                people.Add(person);
            }
            people
                .Where(p => p.age > 30)
                .OrderBy(p => p.name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.name} - {p.age}"));
        }
    }
}
