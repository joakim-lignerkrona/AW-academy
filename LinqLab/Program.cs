namespace LinqLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new Person[]
            {
                new Person { Name = "Bo", Age = 20 },
                new Person { Name = "Li", Age = 30 },
                new Person { Name = "An", Age = 40 },
                new Person { Name = "Anna", Age = 50 },
            };

            var q1 = people.Where(p => p.Age > 25).OrderByDescending(p => p.Name).ThenByDescending(p => p.Age);
            foreach(var p in q1)
            {
                Console.WriteLine(p);
            }
            var q2 = people.Where(p => p.Age < 25).Count();

            Console.WriteLine($"Ppl under 25: {q2}");

            Console.WriteLine(people.Max(p => p.Age));
            Console.WriteLine(people.MinBy(p => p.Age).Name);
            Console.WriteLine(people.Average(p => p.Age));
            Console.WriteLine(people.MaxBy(p => p.Name.Length).Name);
            Console.WriteLine(people.FirstOrDefault(p => p.Name == "Li"));
            var q3 = people.GroupBy(p => p.Name.Length);
            foreach(var g in q3)
            {
                Console.WriteLine($"Letters: {g.Key}, People: {g.Count()}");
            }
            people.Print();
            people.Print(p => p.Name);

        }
    }
    static class Helper
    {
        public static void Print<T>(this IEnumerable<T> collection, Func<T, string> selector)
        {



            string value;
            using(IEnumerator<T> e = collection.GetEnumerator())
            {
                if(!e.MoveNext())
                {
                    throw new InvalidOperationException("Sequence contains no elements");
                }


                do
                {
                    value = selector(e.Current);
                    Console.WriteLine(value);
                } while(e.MoveNext());

            }

        }
        public static void Print<T>(this IEnumerable<T> collection)
        {
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}