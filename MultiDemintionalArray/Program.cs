namespace MultiDemintionalArray {
    internal class Program {
        static void Main(string[] args) {
            string[,] chessBoard = new string[4, 8];

            for(int y = 0; y < chessBoard.GetLength(1); y++) {
                for(int x = 0; x < chessBoard.GetLength(0); x++) {
                    chessBoard[x, y] = $"[{x}, {y}] ";
                }
            }
            for(int y = 0; y < chessBoard.GetLength(1); y++) {
                for(int x = 0; x < chessBoard.GetLength(0); x++) {
                    Console.Write(chessBoard[x, y]);
                }
                Console.WriteLine();
            }

        }
    }
}