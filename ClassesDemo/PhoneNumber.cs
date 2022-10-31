using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo {
    internal class PhoneNumber {
        public string CountryCode { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public PhoneNumber(string type, string countrycode, string number) {
            Type = type;
            CountryCode = countrycode;
            Number = number;
        }
    }
}
