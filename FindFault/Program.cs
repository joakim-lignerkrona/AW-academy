namespace FindFault {
    internal class Program {
        static void Main(string[] args) {
            Fixed1();
            Fixed2();

            ExperimentingWithModulus();
        }

        private static void ExperimentingWithModulus() {
            int a = 8 % 3;
            Console.WriteLine(a);
            for(int i = 0; i < 100; i++) {
                if(i % 10 == 0) {
                    Console.WriteLine(i);
                }
            }

        }

        private static void Fixed1() {
            float a = 1;
            float b = 2;
            float c = a / b;
            Console.WriteLine(c);
        }
        private static void Fixed2() {
            int a = 1;
            int b = 2;
            float c = (float)a / (float)b;
            Console.WriteLine(c);
        }
    }
}