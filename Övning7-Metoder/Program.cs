namespace Övning7_Metoder {
    internal class Program {
        static void Main(string[] args) {
            double num1 = 100;
            double num2 = 100;
            int momsSats = 12;
            double res = Add(num1, num2);
            double moms = Moms(num1);
            double momsCustom = Moms(num1, momsSats);
            Console.WriteLine($"{num1} + {num2} = {res}");
            Console.WriteLine($"total: {num1}, moms (25%): {moms}");
            Console.WriteLine($"total: {num1}, moms ({momsSats}%): {momsCustom}");
        }

        /// <summary>
        /// Adds the sum of two numbers
        /// </summary>
        /// <param name="num1">A number to add</param>
        /// <param name="num2">A second number to add</param>
        /// <returns>The sum of the two arguments</returns>
        private static double Add(double num1, double num2) {
            return num1 + num2;
        }

        private static double Moms(double priceExMoms) {
            return (priceExMoms * 0.25);
        }

        private static double Moms(double priceExMoms, int momsSats) {
            return ((momsSats / (double)100) * priceExMoms);
        }
    }
}