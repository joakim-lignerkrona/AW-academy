namespace DelegatesDemoHåkan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { FullName = "Håkan", Birthday = new DateTime(1970, 1, 1) },
                new Person {FullName = "Sven", Birthday = new DateTime(1964,3,13)},
                new Person {FullName = "Göran", Birthday = new DateTime(1962,2,21)}

            };
            people.Sort((p1, p2) => p1.Birthday.CompareTo(p2.Birthday));
            people.ForEach(person => Console.WriteLine(person.FullName));
        }
    }
}