using System.Globalization;

namespace LinqLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("sv-SE");
            var file = File.ReadLines(@"names.csv", System.Text.Encoding.Latin1);
            var people = file
                .Select(line => line.Split(',', ';'))
                .Select(name => new Person(name[0], DateTime.Parse(name[1])))
                .DistinctBy(p => p.Name)
                .ToList();

            Console.WriteLine($"People: {people.Count}");

            var q2 = people.OrderBy(p => p.Name);
            var q2a = q2.GroupBy(p => p.Name.Substring(0, 2));


            Console.WriteLine($"Unique: {q2.Count()}");
            Console.ReadLine();
            int no = 1;
            //foreach(var person in q2)
            //{
            //    Console.WriteLine($"{no++}. {person.Name} {person.NameDay.ToLongDateString()}");

            //}
            Console.WriteLine("Grouped:");
            foreach(var group in q2a)
            {
                Console.WriteLine(group.Key);
                no = 1;
                Console.Write("\t");
                foreach(var person in group)
                {
                    Console.Write($"{person.Name}, {(no++ % 5 == 0 ? "\n\t" : "")}");
                }
                Console.WriteLine();
            }

            var q2b = people.WhereNameDayIs(DateTime.Now);

            foreach(var person in q2b)
            {
                Console.WriteLine($"{person.Name} {person.NameDay.ToLongDateString()}");
            }

            var q2c = people.WhereMonthIsAndStartsWith(DateTime.Now.AddMonths(3), "b");

            foreach(var person in q2c)
            {
                Console.WriteLine($"{person.Name} {person.NameDay.ToString("MMMM")}");
            }

            q2.PrintLetterStartTotal();

            var q4a = q2.GroupBy(p => p.NameDay.Month);
            var q4b = q2.GroupBy(p => getQuatter(p.NameDay)).OrderBy(g => g.Key);

            foreach(var group in q4a)
            {
                Console.WriteLine($"{new DateTime(1, group.Key, 1).ToString("MMMM")}: {group.Count()}");
            }
            foreach(var group in q4b)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
            var q5c = q2.GroupBy(p => p.NameDay.DayOfYear).OrderBy(g => g.Count()).Take(5);
            foreach(var group in q5c)
            {
                Console.WriteLine($"{new DateTime(DateTime.Now.Year, 1, 1).AddDays(group.Key - 1).ToString("d MMMM")}: {group.Count()}");
            }


        }

        private static string getQuatter(DateTime nameDay)
        {
            switch(nameDay.Month)
            {
                case 1:
                case 2:
                case 3:
                    return "Q1";
                case 4:
                case 5:
                case 6:
                    return "Q2";
                case 7:
                case 8:
                case 9:
                    return "Q3";
                case 10:
                case 11:
                case 12:
                    return "Q4";
                default:
                    return "Unknown";
            }

        }

        public static bool getDate(Person p)
        {
            return p.NameDay == new DateTime(2015, 1, 1);
        }

    }
}