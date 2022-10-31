
using JockanUI;

namespace Övning6_Fortsättning {


    internal class Program {
        static Transaction[] transactions = new Transaction[10];
        static double saldo = 0;
        static int transactionID = 0;
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
            Console.WriteLine("Welcome to ATM!");
            JUIMenu.ShowBoxMenu(new string[] { "[D]eposit", "[W]ithdraw", "[B]alance", "[Q]uit" });
        }
        private static bool Deposit() {
            Console.WriteLine("Deposit");
            double amount = 0;
            bool parseSuccess = false;
            while(!parseSuccess) {
                parseSuccess = double.TryParse(Console.ReadLine(), out amount);
            }
            if(amount < 0) {
                return false;
            }
            transactions[transactionID % transactions.Length] = new Transaction(transactionID++, TransactionType.Deposit, amount);
            saldo += amount;

            return true;
        }

        private static bool Withdraw() {
            Console.WriteLine("Withdraw");
            double amount = 0;
            bool parseSuccess = false;
            while(!parseSuccess) {
                parseSuccess = double.TryParse(Console.ReadLine(), out amount);
            }
            if(amount < 0 || saldo < amount) {
                return false;
            }
            transactions[transactionID % transactions.Length] = new Transaction(transactionID++, TransactionType.Withdraw, amount);
            saldo -= amount;

            return true;
        }

        private static void Balance() {
            Console.WriteLine("Balance");
            string[] list = new string[transactions.Length + 1];


            int index = transactionID - 1;
            for(int i = 0; i < transactions.Length; i++) {
                if(index >= 0) {
                    Transaction trans = transactions[index-- % transactions.Length];
                    list[i] = $"{(trans.type == TransactionType.Withdraw ? "Withdraw" : "Deposit")} | {trans.amount}";
                }
            }
            list[transactions.Length] = $"Ditt Saldo är: {saldo}";


            JockanUI.JUITable.ShowTable(list);
            Console.ReadLine();

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