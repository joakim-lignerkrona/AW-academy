namespace LinqLab
{
    internal class Person : IEqualityComparer<Person>
    {
        public string Name { get; set; }
        public DateTime NameDay { get; set; }

        public Person(string name, DateTime nameDay)
        {
            this.Name = name;
            this.NameDay = nameDay;
        }
        public override string ToString()
        {
            return $"{Name}, {NameDay.ToLocalTime()}";
        }

        public bool Equals(Person? x, Person? y) => x.ToString() == y.ToString();


        public int GetHashCode([DisallowNull] Person obj)
        {
            return obj.GetHashCode();
        }

    }
}