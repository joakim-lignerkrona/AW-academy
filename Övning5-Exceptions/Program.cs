namespace Övning5_Exceptions {
    internal class Program {
        static void Main(string[] args) {


            int numberBetween1_100 = GetUserIntInput(1, 100);
            Console.WriteLine($"You entered: {numberBetween1_100}");
            WhileLoop(numberBetween1_100);

        }

        private static int GetUserIntInput(int minValue, int maxValue) {
            bool invalidInput = true;
            int number = -1;
            do {
                Console.WriteLine($"Enter a number between {minValue} and {maxValue}");
                try {
                    number = int.Parse(Console.ReadLine());
                    if(number < minValue || number > maxValue)
                        throw new ArgumentException();
                    invalidInput = false;
                }
                catch(ArgumentException e) {
                    ShowErrorMessage("Number is not in range");
                }
                catch(OverflowException) {
                    ShowErrorMessage("Number is not in range");
                }
                catch(FormatException) {
                    ShowErrorMessage("Invalid input");
                }

            } while(invalidInput);
            return number;
        }

        private static void ShowErrorMessage(string message) {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine();
        }

        static void WhileLoop(int i) {

            while(i <= 100 && i > 0) {
                Console.WriteLine(i++);
            }
        }
    }
}
