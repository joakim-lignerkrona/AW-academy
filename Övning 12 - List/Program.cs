namespace Övning_12___List {
    internal class Program {

        static bool runApp = true;
        static ContactList contacts = new ContactList();
        static void Main(string[] args) {
            if(!contacts.LoadFromJsonSerializer()) {
                contacts.FillWithSampleData();
            }
            while(runApp) {
                int selection = ShowMainMenu();
                try {
                    HandleSelect(selection);
                }
                catch(Exception exeption) {
                    Console.Clear();
                    Console.WriteLine(exeption.Message);
                    Console.WriteLine("");

                }
            }
            Console.WriteLine("Thank You, bye!");
        }

        private static void HandleSelect(int selection) {
            Console.Clear();
            switch(selection) {
                case 0:
                    ConfirmExit();
                    break;
                case 1:
                    contacts.AddContact();
                    break;
                case 2:
                    contacts.ListContacts();
                    break;
                case 3:
                    contacts.RemoveContact();
                    break;
                case 4:
                    contacts.SortContacts();
                    break;
                case 5:
                    contacts.SaveToFile();
                    break;
                case 22:
                    break;
                default:
                    throw new Exception("Invalid input!");

            }

        }

        private static void ConfirmExit() {
            Console.Write("Are you sure you want to exit? (Y/n): ");
            string optionConfirmed = Console.ReadLine();
            if(optionConfirmed == "y" || optionConfirmed == "Y") {
                runApp = false;
                contacts.SortContacts();
                contacts.SaveToFile();
            }
        }

        private static int ShowMainMenu() {


            Console.WriteLine("Welcome, Let's make a fruitsallad!");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. List contacts");
            Console.WriteLine("3. Remove contact");
            Console.WriteLine("4. Sort");
            Console.WriteLine("5. Save to file");
            Console.WriteLine("0. Exit application");

            try {
                string input = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine(input);
                if(input != "\r") {
                    int selection = int.Parse(input);
                    return selection;

                }
                return 22;
            }
            catch(Exception) {

                return -1;
            }

        }
    }
}