using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JockanNiceHaves {
    public static class NameLibrary {
        static string[] femaleFirstNames = File.ReadAllLines(@"C:\Users\jocka\tmp\femaleNames.txt");
        static string[] maleFirstNames = File.ReadAllLines(@"C:\Users\jocka\tmp\maleNames.txt");
        static string[] lastNames = File.ReadAllLines(@"C:\Users\jocka\tmp\lastNames.txt");

        static public string GetRandomFirstName(bool isFemale = true, bool randomGender = false) {
            if(randomGender) {
                isFemale = Random.Shared.Next(0, 2) == 0;
            }
            Random r = new Random();
            if(isFemale) {
                int index = r.Next(0, femaleFirstNames.Length);
                return femaleFirstNames[index];

            }
            else {
                int index = r.Next(0, maleFirstNames.Length);
                return maleFirstNames[index];
            }
        }
        static public string GetRandomLastName() {
            Random r = new Random();
            int index = r.Next(0, lastNames.Length);
            return lastNames[index];
        }
    }
}
