namespace Enums {
    internal class Program {
        static void Main(string[] args) {
            var today = DateTime.Now;
            DayOfWeekAction(today.DayOfWeek);

        }

        private static void DayOfWeekAction(DayOfWeek dayOfWeek) {
            switch(dayOfWeek) {
                case DayOfWeek.Monday:
                    Console.WriteLine("Monday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Thursday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Friday");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Saturday");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    break;
            }
        }
    }
}