namespace MultiDemintionalArray {
    internal class Program {
        static int numberOfPlayers = 0;
        static void Main(string[] args) {
            bool validPlayers = false;
            while(!validPlayers) {
                validPlayers = InitializeGame();
            }
            Game[] games = new Game[numberOfPlayers];
            for(int i = 0; i < games.Length; i++) {
                games[i] = new Game(3, 3);
            }
            games[0].Turn();
        }

        private static bool InitializeGame() {
            bool valid = false;
            Console.Clear();
            Console.WriteLine("How manny players are there?");
            var inputString = Console.ReadLine();
            valid = int.TryParse(inputString, out numberOfPlayers);
            if((numberOfPlayers > 4 && numberOfPlayers < 0) || !valid) {
                return false;
            }
            Console.WriteLine("Whats size of game board do you want? (min: 2x2, max: 9x9)");
            inputString = Console.ReadLine();
            var splitSting = inputString.Split('x');
            if(splitSting.Length == 2) {
                Console.WriteLine($"{splitSting[0]}/{splitSting[1]}");
                // int? number;


            }

            return false;

        }
    }
}