using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    internal static class ExtentionCollection
    {
        public static IEnumerable<Person> WhereNameDayIs(this IEnumerable<Person> p, DateTime dateTime)
        {
            return p.Where(person => person.NameDay.DayOfYear == dateTime.DayOfYear);

        }

        public static IEnumerable<Person> WhereMonthIsAndStartsWith(this IEnumerable<Person> p, DateTime month, string c)
        {
            return p.Where(person => person.NameDay.Month == month.Month && person.Name.StartsWith(c, true, null));

        }
        public static void PrintLetterStartTotal(this IEnumerable<Person> p)
        {
            var q3 = p.GroupBy(p => p.Name.Substring(0, 1));
            var no = 1;
            foreach(var group in q3)
            {
                Console.Write($"{group.Key}: {group.Count()}{(no++ % 10 == 0 ? ",\n" : ", ")}");
            }
            Console.WriteLine();
        }
        public static void PrintWithHeader(this IEnumerable<Person> p, string header)
        {
            Console.WriteLine(header);
            int no = 1;
            foreach(var person in p)
            {
                Console.Write($"{person}{(no++ % 10 == 0 ? "\n" : "")}");
            }
            Console.WriteLine();
        }
    }
}
