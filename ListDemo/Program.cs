namespace ListDemo {
    internal class Program {
        static void Main(string[] args) {
            var ints = new List<int>();
            try {
                for(int i = 0; i < int.MaxValue; i++) {
                    ints.Add(i);
                }
            }
            catch(Exception) {


                Console.WriteLine(ints.Capacity);
            }


        }
    }
}