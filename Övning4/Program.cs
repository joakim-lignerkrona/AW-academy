namespace Övning4 {
    internal class Program {
        static void Main(string[] args) {
            #region WhileLoopar
            WhileLoop();
            Console.Write("Enter starting number: ");
            WhileLoop(int.Parse(Console.ReadLine()));
            #endregion

            DoWhileLoop();
            Console.Write("Enter starting number: ");
            DoWhileLoop(int.Parse(Console.ReadLine()));
        }
        static void WhileLoop() {
            int i = 0;
            while(i < 20) {
                Console.WriteLine(++i);
            }
        }
        static void WhileLoop(int i) {

            while(i <= 100 && i > 0) {
                Console.WriteLine(i++);
            }
        }

        static void DoWhileLoop() {
            int i = 0;
            do {
                Console.WriteLine(++i);
            } while(i < 20);
        }
        static void DoWhileLoop(int i) {
            if(i <= 100 && i > 0)
                do {
                    Console.WriteLine(i++);
                } while(i <= 100 && i > 0);
        }
    }
}