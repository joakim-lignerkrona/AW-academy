using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo {
    internal class Car {
        public string LicenseNumber { get; private set; }
        public string Color { get; set; }

        public Car(string licenseNumber, string Color) {
            this.LicenseNumber = licenseNumber;
            this.Color = Color;
        }
        public Car() : this("N/A", "N/A") { }
    }
}
