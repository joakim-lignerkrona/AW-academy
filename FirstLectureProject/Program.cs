namespace FirstLectureProject {
    internal class Program {
        static void Main(string[] args) {
            //AskForName();
            //AddTwoNumbers();
            //AddThreeNumbersWithAvg();
            PrintClosestIntFromDecimal();
        }

        private static void PrintClosestIntFromDecimal() {
            Console.WriteLine("Enter a decimal number:");
            var input = double.Parse(Console.ReadLine());
            //            var number = convert.todecimal(input);
            var roundedNumber = Math.Round(input);
            Console.WriteLine($"The closest integer to {input} is {roundedNumber}");
        }

        private static void AddThreeNumbersWithAvg() {
            Console.WriteLine("Enter three numbers to add");
            double num1 = double.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            double sum = num1 + num2 + num3;
            double avg = sum / 3;
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The average is " + avg);
        }

        private static void AddTwoNumbers() {
            Console.WriteLine("Enter a number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int number2 = int.Parse(Console.ReadLine());
            int sum = AddTwoNumbers(number1, number2);
            Console.WriteLine("The sum of the two numbers is " + sum);
        }
        private static int AddTwoNumbers(int num1, int num2) {
            int sum = num1 + num2;
            return sum;
        }

        private static void AskForName() {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {2} {2} {2}, ", name, 2, "test");
        }


    }
}