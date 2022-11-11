namespace Delegater02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, bool> PrintIt = PrintItM;

            PrintItM("hello", true);
            PrintItM("hello", false);
        }
        static void PrintItM(string s, bool b)
        {
            if(b)
            {
                Console.WriteLine(s.ToUpper());
                return;
            }
            Console.WriteLine(s.ToLower());
        }

    }
}