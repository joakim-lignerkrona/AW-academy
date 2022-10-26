namespace Övning_3 {
    internal class Program {
        static void Main(string[] args) {
            var running = true;
            while(running) {
                Console.Clear();
                Console.WriteLine("Välj en uppgift");
                Console.WriteLine("1. Laget");
                Console.WriteLine("2. Temperatur");
                Console.WriteLine("3. Temperatur Utvecklad");
                Console.WriteLine("0. Exit");
                var key = Console.ReadKey();

                if(key.KeyChar == '1') {
                    Laget();
                }
                else if(key.KeyChar == '2') {
                    Temperatur();
                }

                else if(key.KeyChar == '3') {
                    TemperaturV2();
                }
                else if(key.KeyChar == '0') {
                    running = false;
                }
            }
        }

        private static void Laget() {
            Console.WriteLine("Är MFF bästa laget?");
            if(Console.ReadLine() == "ja") {
                Console.WriteLine("Helt rätt!");
                Console.ReadLine();
            }
        }

        private static void Temperatur() {
            Console.WriteLine("Ange Temp i Jukkasjärvi");
            var jukkasjärvi = Console.ReadLine();
            Console.WriteLine("Ange Temp i Svedala");
            var svedala = Console.ReadLine();
            Console.Clear();
            double jukkasjärviNumeric;
            double svedalaNumeric;
            try {
                jukkasjärviNumeric = double.Parse(jukkasjärvi);

            }
            catch(Exception) {
                jukkasjärviNumeric = 0;

            }
            try {
                svedalaNumeric = double.Parse(svedala);
            }
            catch(Exception) {

                svedalaNumeric = 0;
            }


            if(jukkasjärviNumeric > svedalaNumeric) {
                Console.WriteLine("Svedala är kallast");
            }
            else {
                Console.WriteLine("Jukkasjärvi är kallast");
            }
            Console.ReadLine();
        }

        private static void TemperaturV2() {
            //ask user to input temperatures from svedala, jukkasjärvi and visby
            Console.WriteLine("Ange Temp i Jukkasjärvi");
            var jukkasjärvi = Console.ReadLine();
            Console.WriteLine("Ange Temp i Svedala");
            var svedala = Console.ReadLine();
            Console.WriteLine("Ange Temp i Visby");
            var visby = Console.ReadLine();
            Console.Clear();
            //convert the strings to doubles
            double jukkasjärviNumeric;
            double svedalaNumeric;
            double visbyNumeric;
            try {
                jukkasjärviNumeric = double.Parse(jukkasjärvi);

            }
            catch(Exception) {
                jukkasjärviNumeric = 0;

            }
            try {
                svedalaNumeric = double.Parse(svedala);
            }
            catch(Exception) {

                svedalaNumeric = 0;
            }
            try {
                visbyNumeric = double.Parse(visby);
            }
            catch(Exception) {

                visbyNumeric = 0;
            }


        }

    }
}