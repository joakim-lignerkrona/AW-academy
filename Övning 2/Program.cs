namespace Övning_2 {
    internal class Program {
        static void Main(string[] args) {
            ÖvningEttTillFyra();
            HittaFel();
        }

        private static void ÖvningEttTillFyra() {
            AskForName();
            AddTwoNumbers();
            AddThreeNumbersWithAvg();
            PrintClosestIntFromDecimal();
        }

        private static void HittaFel() {
            Fixed1();
            Fixed2();
            ExperimentingWithModulus();
        }

        private static void AskForName() {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
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

        private static void PrintClosestIntFromDecimal() {
            Console.WriteLine("Enter a decimal number:");
            var input = double.Parse(Console.ReadLine());
            //            var number = convert.todecimal(input);
            var roundedNumber = Math.Round(input);
            Console.WriteLine($"The closest integer to {input} is {roundedNumber}");
        }

        private static void Fixed1() {
            float a = 1;
            float b = 2;
            float c = a / b;
            Console.WriteLine(c);
        }
        private static void Fixed2() {
            int a = 1;
            int b = 2;
            float c = (float)a / (float)b;
            Console.WriteLine(c);
        }
        private static void ExperimentingWithModulus() {
            int a = 8 % 3;
            Console.WriteLine(a);
            for(int i = 0; i < 100; i++) {
                if(i % 10 == 0) {
                    Console.WriteLine(i);
                }
            }

        }

    }
}