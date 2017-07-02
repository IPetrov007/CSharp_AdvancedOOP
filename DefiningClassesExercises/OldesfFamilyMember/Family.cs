using System.Collections.Generic;
using System.Linq;

class Family
{
    public List<Person> people = new List<Person>();

    public void AddMember(Person person)
    {
        people.Add(person);
    }

    public Person GetOldestMember(List<Person> people)
    {
        return people.OrderByDescending(x => x.age).FirstOrDefault();
    }
}

