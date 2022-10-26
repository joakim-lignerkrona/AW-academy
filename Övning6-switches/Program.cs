namespace Övning6_switches {
    internal class Program {
        static void Main(string[] args) {
            bool running = true;
            while(running) {
                DisplayMenu();
                running = SelectFunction();

            }
        }

        private static bool SelectFunction() {
            var key = Console.ReadKey(true);
            Console.Clear();
            switch(key.Key) {
                case ConsoleKey.W:
                    Withdraw();
                    break;
                case ConsoleKey.D:
                    Deposit();
                    break;
                case ConsoleKey.B:
                    Balance();
                    break;
                case ConsoleKey.Q:
                    return Quit();

                default:
                    return true;
            }
            Console.ReadLine();
            return true;
        }




        private static void DisplayMenu() {
            Console.Clear();
            Console.WriteLine("""

                       -------------------
                      |                   |
                      |  Welcome to ATM!  |
                      |                   |
                       -------------------

                       [D]eposit
                       [W]ithdraw
                       [B]alance
                       [Q]uit
              """);
        }
        private static void Deposit() {
            Console.WriteLine("Deposit");
        }

        private static void Withdraw() {
            Console.WriteLine("Withdraw");
        }

        private static void Balance() {
            Console.WriteLine("Balance");
        }

        private static bool Quit() {
            Console.WriteLine("Are you sure you want to exit? (Y/n): ");
            switch(Console.ReadKey(true).Key) {
                case ConsoleKey.Y:
                    return false;
                default:
                    return true;
            }
        }
    }
}