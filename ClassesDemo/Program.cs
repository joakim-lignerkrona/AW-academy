namespace ClassesDemo {
    internal class Program {
        static void Main(string[] args) {
            Person[] people = new Person[3];
            for(int i = 0; i < people.Length; i++) {
                people[i] = new Person("Joakim", "Lignerkrona", new DateTime(1994, 01, 15));
                people[i].contactInfo.AddAdress("Översättravägen 56", "184 70", "Åkersberga");
                people[i].contactInfo.AddPhoneNumber(new PhoneNumber("Home", "+46", "70 945 67 08"));
            }
            people[1] = new Person("bo", "svensson", new DateTime(1999, 01, 01));
            people[1].contactInfo.AddPhoneNumber(new PhoneNumber(type: "Home", countrycode: "+46", number: "76 303 07 33"));
            people[1].contactInfo.AddPhoneNumber(new PhoneNumber(type: "Work", countrycode: "+46", number: "76 303 07 33"));
            people[1].contactInfo.AddPhoneNumber(new PhoneNumber(type: "Other", countrycode: "+46", number: "76 303 07 33"));
            Console.WriteLine(people[people.Length - 1].Id);

            for(int personIndex = 0; personIndex < people.Length; personIndex++) {
                Console.WriteLine($"  {people[personIndex].FirstName} {people[personIndex].LastName}: ");
                for(int infoIndex = 0; infoIndex < people[personIndex].contactInfo.PhoneNumbers.Length; infoIndex++) {
                    var phoneNumber = people[personIndex].contactInfo.PhoneNumbers[infoIndex];
                    Console.WriteLine($"\t{phoneNumber.Type}: {phoneNumber.CountryCode} {phoneNumber.Number}");
                }
                Console.WriteLine("    -------------------------------");
            }




        }
    }
}