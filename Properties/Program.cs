namespace Properties {
    internal class Program {
        static void Main(string[] args) {
            Car[] cars = new Car[0];
            bool addMore = true;
            while(addMore) {
                cars = AddCar(cars);
                Console.WriteLine("Do you want to add another car? [Y/n]");
                bool validInput = false;
                while(!validInput) {
                    var key = Console.ReadKey();
                    if(key.Key == ConsoleKey.Y) {
                        validInput = true;
                    }
                    else if(key.Key == ConsoleKey.N) {
                        validInput = true;
                        addMore = false;
                    }
                }
            }
            foreach(Car car in cars) {
                Console.WriteLine(car.LicenseNumber);
            }
        }

        private static Car[] AddCar(Car[] cars) {
            var localCars = new Car[cars.Length + 1];
            for(int i = 0; i < cars.Length; i++) {
                localCars[i] = cars[i];
            }
            var car = new Car();

            bool validInput = true;
            bool validPlate = false;
            do {
                try {
                    if(!validPlate) {
                        Console.Write("License: ");
                        //car.SetLicenseNumber(Console.ReadLine());
                        car.LicenseNumber = Console.ReadLine();
                        validPlate = true;
                    }
                    Console.Write("Color: ");
                    car.Color = Console.ReadLine();
                    validInput = true;

                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    validInput = false;
                }
            }
            while(!validInput);

            localCars[localCars.Length - 1] = car;

            return localCars;
        }
    }
}
