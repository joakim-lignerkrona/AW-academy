using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDemintionalArray {
    internal class Game {
        static bool debug = true;
        CoordinateState[,] gameBoard;

        public Game(int sizeX, int sizeY) {
            gameBoard = new CoordinateState[sizeX, sizeY];
            InitiateGameboard(gameBoard);
        }

        public void Turn() {

            Console.Clear();
            PrintBoard(gameBoard);
            string input = GetUserInput(gameBoard);
            ExecuteMove(input, gameBoard);
            Console.Clear();
            PrintBoard(gameBoard);
        }

        public static bool GameIsOver(CoordinateState[,] gameBoard) {
            bool gameOver = true;
            for(int y = 0; y < gameBoard.GetLength(1); y++) {
                for(int x = 0; x < gameBoard.GetLength(0); x++) {

                    if(gameBoard[x, y] == CoordinateState.Ship) {
                        gameOver = false;
                    }
                }
            }
            return gameOver;
        }

        public static void ExecuteMove(string input, CoordinateState[,] gameBoard) {
            var x = int.Parse(input.Substring(1, 1)) - 1;
            var y = LetterToNumber(input.Substring(0, 1).ToCharArray()[0]) - 1;

            if(gameBoard[x, y] == CoordinateState.Empty) {
                gameBoard[x, y] = CoordinateState.Miss;
            }
            if(gameBoard[x, y] == CoordinateState.Ship) {
                gameBoard[x, y] = CoordinateState.Hit;
            }

        }

        public static string GetUserInput(CoordinateState[,] gameBoard) {
            bool validInput = false;
            string inputCode = "";
            while(!validInput) {

                Console.Write("Enter a coordinate to fire at: ");
                var input = Console.ReadLine().ToUpper();
                if(input.Length == 2) {


                    int first = 0;
                    var firstIsNumber = int.TryParse(input.Substring(0, 1), out first);
                    int second = 0;
                    var secondIsNumber = int.TryParse(input.Substring(1, 1), out second);
                    if((firstIsNumber || secondIsNumber) && !(firstIsNumber && secondIsNumber)) {
                        validInput = true;
                        if(!firstIsNumber) {
                            inputCode = input;
                            if(gameBoard.GetLength(0) < LetterToNumber(input.Substring(0, 1).ToCharArray()[0]) || gameBoard.GetLength(1) < second) {
                                validInput = false;
                            }
                        }
                        else {
                            inputCode = input.Substring(1, 1) + input.Substring(0, 1);
                            if(gameBoard.GetLength(1) < LetterToNumber(input.Substring(1, 1).ToCharArray()[0]) || gameBoard.GetLength(0) < first) {
                                validInput = false;
                            }
                        }

                    }
                }

                if(!validInput)
                    Console.WriteLine("Invalid input, try again!");
            }
            return inputCode;
        }

        public static void PrintBoard(CoordinateState[,] gameBoard) {
            Console.Write($"    ");
            for(int x = 0; x < gameBoard.GetLength(0); x++) {
                Console.Write($"[{(x == 9 ? (0) : (x + 1))}] ");
            }
            Console.WriteLine();
            for(int y = 0; y < gameBoard.GetLength(1); y++) {
                Console.Write($"[{NumberToLetter(y + 1)}]");
                for(int x = 0; x < gameBoard.GetLength(0); x++) {
                    if(gameBoard[x, y] == CoordinateState.Ship && debug) {
                        Console.Write("  S ");
                    }
                    else if(gameBoard[x, y] == CoordinateState.Miss) {
                        Console.Write("  * ");
                    }
                    else if(gameBoard[x, y] == CoordinateState.Hit) {
                        Console.Write("  X ");
                    }
                    else {
                        Console.Write("  ~ ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void InitiateGameboard(CoordinateState[,] gameBoard) {
            int xCoordinate = debug ? new Random(14).Next(gameBoard.GetLength(0)) : new Random().Next(gameBoard.GetLength(0));
            int yCoordinate = debug ? new Random(15).Next(gameBoard.GetLength(1)) : new Random().Next(gameBoard.GetLength(1));
            for(int y = 0; y < gameBoard.GetLength(1); y++) {
                for(int x = 0; x < gameBoard.GetLength(0); x++) {

                    if(xCoordinate == x && yCoordinate == y) {
                        gameBoard[x, y] = CoordinateState.Ship;
                    }
                    else {

                        gameBoard[x, y] = CoordinateState.Empty;
                    }


                }
            }
        }

        static char NumberToLetter(int number) {
            return (char)(number + 64);
        }
        static int LetterToNumber(char letter) {
            return (int)letter - 64;
        }
    }
}
