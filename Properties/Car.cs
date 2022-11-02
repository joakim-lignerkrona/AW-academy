using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties {
    internal class Car {
        string licenseNumber;
        public string LicenseNumber {
            get { return GetLicenseNumber(); }
            set { licenseNumber = SetLicenseNumber(value); }
        }
        string color;
        public string Color {
            get { return GetColor(); }
            set { color = SetColor(value); }
        }

        string GetLicenseNumber() {
            string formatedLicenseplate = $"*** {licenseNumber.Substring(0, 3).ToUpper()} {licenseNumber.Substring(3, 3)} ***";

            return formatedLicenseplate;
        }

        string SetLicenseNumber(string licenseNumber) {
            char[] charArray = licenseNumber.ToCharArray();
            if(charArray.Length != 6) {
                Console.WriteLine("incorrect length");
            }

            for(int i = 0; i < charArray.Length; i++) {
                if(charArray.Length != 6)
                    throw new FormatException("The licenseplate should have exact 6 characters");
                if(i < 3) {
                    if((int)charArray[i] < 64 && (int)charArray[i] > 91)
                        throw new FormatException("Three first characters should be letters a-z");

                }
                else {
                    if((int)charArray[i] < 47 && (int)charArray[i] > 58)
                        throw new FormatException("Three last characters should be numbers 0-9");
                }
            }


            return licenseNumber;
        }

        public string GetColor() {
            switch(color) {
                case "red":
                    return "röd";
                case "green":
                    return "grön";
                case "blue":
                    return "blå";
                case "yellow":
                    return "blå";
                default:
                    throw new Exception("color not defined");
            }

        }
        string SetColor(string color) {
            color = color.Trim().ToLower();

            if(!(color == "red" || color == "green" || color == "blue" || color == "yellow")) {
                throw new ArgumentException("The color must be red, gree, blue or yellow");
            }
            return color;
        }

    }
}
