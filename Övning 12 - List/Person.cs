using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_12___List {
    internal class Person {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }



        public Person(string firstName, string lastName, string email, string phone) {

            FistName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }



    }
}
