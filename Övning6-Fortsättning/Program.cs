using Spectre.Console;
using JockanUI;

namespace Övning6_Fortsättning {


    internal class Program {
        static Transaction[] transactions = new Transaction[10];
        static double saldo = 0;
        static int transactionID = 0;
        static void Main(string[] args) {
            bool running = true;
            while(running) {
                //DisplayMenu();
                running = SelectFunction(NewSelectFunction());

            }
        }

        private static string NewSelectFunction() {
            Console.Clear();
            AnsiConsole.Write(new FigletText("ATM").Centered());
            var selected = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What do you want to do?")
                    .PageSize(4)
                    .MoreChoicesText("[grey](Move up and down to reveal more choices)[/]")
                    .AddChoices(new[] {
                        "Deposit",
                        "Withdraw",
                        "Balance",
                        "Exit"
                    })
            );
            return selected;
        }
        private static bool SelectFunction(string selection) {
            //var key = Console.ReadKey(true);
            Console.Clear();
            switch(selection) {
                case "Withdraw":
                    Withdraw();
                    break;
                case "Deposit":
                    Deposit();
                    break;
                case "Balance":
                    Balance();
                    break;
                case "Exit":
                    return Quit();

                default:
                    return true;
            }
            return true;
        }




        private static void DisplayMenu() {
            Console.Clear();
            Console.WriteLine("Welcome to ATM!");
            JUIMenu.ShowBoxMenu(new string[] { "[D]eposit", "[W]ithdraw", "[B]alance", "[Q]uit" });
        }
        private static bool Deposit() {
            AnsiConsole.Write(new FigletText("Deposit").Centered());
            var value = AnsiConsole.Prompt(
    new TextPrompt<double>("Enter [green]amount[/] to be deposited: [blue](SEK)[/]")
        .PromptStyle("green")
        .ValidationErrorMessage("[red]That's not a valid amount[/]")
        .Validate(amount => {
            return amount switch {
                <= 1 => ValidationResult.Error("[red]You must deposit at least 1 SEK[/]"),

                _ => ValidationResult.Success(),
            };
        }));
            saldo += value;
            transactions[transactionID % transactions.Length] = new Transaction(transactionID++, TransactionType.Deposit, value);
            return true;


            //Console.WriteLine("Deposit");
            //double amount = 0;
            //bool parseSuccess = false;
            //while(!parseSuccess) {
            //    parseSuccess = double.TryParse(Console.ReadLine(), out amount);
            //}
            //if(amount < 0) {
            //    return false;
            //}
            //transactions[transactionID % transactions.Length] = new Transaction(transactionID++, TransactionType.Deposit, amount);
            //saldo += amount;

            //return true;
        }

        private static bool Withdraw() {

            //        AnsiConsole.Render(new FigletText("Withdraw").Centered());
            //        var value = AnsiConsole.Prompt(
            //new TextPrompt<double>("Enter [green]amount[/] to be withdrawn: [blue](SEK)[/]")
            //    .PromptStyle("green")
            //    .ValidationErrorMessage("[red]That's not a valid amount[/]")
            //    .Validate(amount => {
            //        var success = ValidationResult.Success();
            //        if(saldo < amount) {
            //            success = ValidationResult.Error("[red]You don't have enough money[/]");
            //        }
            //        if(amount < 0) {
            //            success = ValidationResult.Error("[red]You must deposit at least 1 SEK[/]");
            //        }

            //        return amount switch {
            //            <= 1 => ValidationResult.Error("[red]You must deposit at least 1 SEK[/]"),
            //            > saldo => 
            //            _ => ValidationResult.Success(),
            //        };
            //    }));
            //        saldo += value;
            //        transactions[transactionID % transactions.Length] = new Transaction(transactionID++, TransactionType.Deposit, value);
            //        return true;

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