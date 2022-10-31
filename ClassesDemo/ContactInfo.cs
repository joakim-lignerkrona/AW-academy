using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo {
    internal class ContactInfo {
        public PhoneNumber[] PhoneNumbers { get; set; }
        public Address address { get; private set; }
        public ContactInfo() {
            PhoneNumbers = new PhoneNumber[0];
            address = new Address();
        }
        public ContactInfo(PhoneNumber phoneNumber) {
            PhoneNumbers = new PhoneNumber[] { phoneNumber };
        }
        public void AddPhoneNumber(PhoneNumber phoneNumber) {
            PhoneNumber[] temp = new PhoneNumber[PhoneNumbers.Length + 1];
            for(int i = 0; i < PhoneNumbers.Length; i++) {
                temp[i] = PhoneNumbers[i];
            }
            temp[temp.Length - 1] = phoneNumber;
            this.PhoneNumbers = temp;

        }
        public void AddAdress(string address, string zipCode, string city) {
            this.address.Street = address;
            this.address.ZipCode = zipCode;
            this.address.City = city;
        }
    }
}
