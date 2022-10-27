using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning7b_MerryMethods {
    internal class MethodBench {

        public void FirstMethod() {
            Console.WriteLine("Merry Methods");
        }
        public void SecondMethod(string msg) {
            Console.WriteLine(msg);
        }

        public void ThirdMethod(string msg, bool upperCase) {
            if(upperCase) {
                msg = msg.ToUpper();
            }
            else {
                msg = msg.ToLower();
            }
            this.SecondMethod(msg);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retruns true for screaming</returns>
        public bool FourthMethod() {
            ConsoleKey key = ConsoleKey.M;
            bool valid = false;
            while(!valid) {
                Console.WriteLine("Scream or whisper? (S/w): ");
                key = Console.ReadKey(true).Key;
                valid = key == ConsoleKey.S || key == ConsoleKey.W;

            }
            return key == ConsoleKey.S;
        }

        public (string Name, bool LegnthyName) SixthMethod() {

            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            bool longName = name.Length > 5;
            return (name, longName);

        }

    }
}
