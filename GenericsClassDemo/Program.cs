namespace GenericsClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListOfPerson listOfPersons = new ListOfPerson()
            {
                new Person("Jack", "Doe", 1972),
                new Person("Jane", "Doe", 1971),
                new Person("Jill", "Doe", 1973),
                new Person("John", "Doe", 1970),
                new Person("Jenny", "Doe", 1974),
            };
            foreach(Person person in listOfPersons)
            {
                Console.WriteLine(person);
            }
            listOfPersons.Sort((p1, p2) => string.Compare(p1.ToString(), p2.ToString(), true) > 0);
            Console.WriteLine("Sorted list:");
            foreach(Person person in listOfPersons)
            {
                Console.WriteLine(person);
            }
        }
    }
}