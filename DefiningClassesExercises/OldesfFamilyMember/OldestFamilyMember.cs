using System;
using System.Reflection;

namespace OldesfFamilyMember
{
    public class OldestFamilyMember
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var N = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person();
                person.name = name;
                person.age = age;
                family.AddMember(person);
            }
            var oldestMember = family.GetOldestMember(family.people);
            Console.WriteLine($"{oldestMember.name} {oldestMember.age}");
        }
    }
}
