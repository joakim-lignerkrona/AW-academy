namespace Övning7b_MerryMethods {
    internal class Program {
        static void Main(string[] args) {
            MethodBench methodBench = new MethodBench();
            int i = 0;
            do {
                methodBench.FirstMethod();
                i++;
            } while(i < 3);
            methodBench.SecondMethod("C# Now and Forever!");
            Console.Write("Write a message: ");
            var input = Console.ReadLine();
            methodBench.SecondMethod(input);
            Console.Write("use upper case? (U): ");
            var key = Console.ReadLine();
            bool userWantsUpper = key == "U";
            methodBench.ThirdMethod(input, userWantsUpper);
            bool screaming = methodBench.FourthMethod();
            methodBench.ThirdMethod(input, screaming);
            var (name, haslongName) = methodBench.SixthMethod();
            Console.WriteLine($" {name} är{(haslongName ? " " : " inte ")}ett långt namn");

        }
    }
}