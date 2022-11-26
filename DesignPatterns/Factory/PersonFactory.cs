using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    public class PersonFactory
    {
        private readonly List<Person> people = new List<Person>();
        public Person CreatePerson(string Name)
        {
            var p = new Person(Name, people.Count);
            people.Add(p);
            return p;
        }
    }
}
