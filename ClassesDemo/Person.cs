using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo {
    internal class Person {
        static int PersonIndex = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public ContactInfo contactInfo = new ContactInfo();


        public Person(string FirstName, string LastName, DateTime Birthday) {
            Id = ++PersonIndex;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
        }
    }
}
