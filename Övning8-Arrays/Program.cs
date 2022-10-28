using System.Xml.Linq;

namespace Övning8_Arrays {
    internal class Program {
        static void Main(string[] args) {
            string[] names = new string[5];
            for(int i = 0; i < names.Length; i++) {
                names[i] = InputName();
            }

            //ListNamesReverse(names);
            //ChangeName(names);
            //ListNames(names);
            //ReportWeather();

            SortAlfaBublbe(names);
            ListNames(names);
        }

        private static void SortAlfaBublbe(string[] names) {
            for(int j = 0; j < names.Length; j++) {
                for(int i = 1; i < names.Length; i++) {
                    string name1 = names[i];
                    string name2 = names[i - 1];
                    if(name1.CompareTo(name2) < name2.CompareTo(name1)) {
                        names[i] = name2;
                        names[i - 1] = name1;
                    }
                }
            }
        }

        private static void ReportWeather() {
            int amountOfMessurments = AskForAmountOfMessurments();
            double[] readings = new double[amountOfMessurments];
            for(int i = 0; i < readings.Length; i++) {
                readings[i] = AskForReading(i);
            }
            PrintAvg(readings);
        }

        private static void PrintAvg(double[] readings) {
            double sum = 0;
            foreach(double reading in readings) {
                sum = sum + reading;
            }
            Console.WriteLine($"Medelvärdet av {readings.Length} mätningar är {((double)sum / readings.Length).ToString("0.0")}°C");
        }

        private static double AskForReading(int i) {
            Console.WriteLine($"What reading number {i + 1}? (°C)");
            return double.Parse(Console.ReadLine());
        }

        private static int AskForAmountOfMessurments() {
            Console.WriteLine("How many readings did you make?");
            return int.Parse(Console.ReadLine());
        }

        private static void ListNamesReverse(string[] names) {
            for(int i = 0; i < names.Length; i++) {
                Console.WriteLine($"{i + 1}. {names[names.Length - 1 - i]}");
            }
        }

        private static void ChangeName(string[] names) {
            ListNames(names);
            Console.Write("Enter the name you want to change:");

            names[int.Parse(Console.ReadLine()) - 1] = InputName();
        }


        private static void ListNames(string[] names) {
            var i = 0;
            foreach(var name in names) {
                Console.WriteLine($"{++i}. {name}");
            }
        }

        private static string InputName() {
            return Console.ReadLine();
        }
    }
}