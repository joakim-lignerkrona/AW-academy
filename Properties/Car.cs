using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties {
    internal class Car {
        string licenseNumber, color;
        public string GetLicenseNumber() {
            return licenseNumber;
        }
        public string GetColor() {
            return color;
        }
        public void SetLicenseNumber(string licenseNumber) {
            char[] charArray = licenseNumber.ToCharArray();
            if(charArray.Length != 6) {
                Console.WriteLine("incorrect length");
            }
            bool lettersOK = false;
            bool numbersOK = false;
            for(int i = 0; i < charArray.Length; i++) {
                if(i < 3) {
                    if((int)charArray[i] < 0) {


                    }
                }
            }

            this.licenseNumber = licenseNumber;
        }
        public void SetColor(string color) {
            this.color = color;
        }

    }
}
