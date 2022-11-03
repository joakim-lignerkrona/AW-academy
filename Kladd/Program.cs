namespace Kladd {
    internal class Program {
        static void Main(string[] args) {
            const string fileName = @"C:\Users\jocka\tmp\fileName.txt";
            File.WriteAllLines(fileName, new string[] { "hej", "på", "dig" });

        }

    }
}