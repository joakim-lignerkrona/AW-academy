using JockanNiceHaves;
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
        public List<Adress> Adresses { get; set; }



        public Person(string firstName, string lastName, string email, string phone) {

            FistName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public Person() {
            FistName = NameLibrary.GetRandomFirstName(randomGender: true);
            LastName = NameLibrary.GetRandomLastName();
            Email = $"{this.FistName.ToLower().Replace(' ', '-')}.{this.LastName.Replace(' ', '-').ToLower()}@domain.com";
            Phone = "N/A";
            FistName = this.FistName.Substring(0, 1) + this.FistName.Substring(1).ToLower();
            LastName = this.LastName.Substring(0, 1) + this.LastName.Substring(1).ToLower();
        }



    }
}
