using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Övning_12___List {
    internal class ContactList {
        public List<Person> contacts = new List<Person>();
        public void FillWithSampleData(int amount = 30) {
            for(int i = 0; i < amount; i++) {
                contacts.Add(new Person());
            }
        }
        public void ChangeContactFirstName(int index, string newFirstName) {
            contacts[index].FistName = newFirstName;
        }
        public void ChangeContactLastName(int index, string newLastName) {
            contacts[index].LastName = newLastName;
        }
        public void ChangeContactEmail(int index, string newEmail) {
            contacts[index].Email = newEmail;
        }
        public void ChangeContactPhone(int index, string newPhone) {
            contacts[index].Phone = newPhone;
        }

        public void AddContact() {
            Console.WriteLine("Add contact");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Person newContact = new Person(firstName, lastName, email, phone);
            contacts.Add(newContact);
        }
        public void ListContacts() {
            Console.Clear();
            Console.WriteLine("List contacts");
            Console.Write(" ");
            for(int i = 0; i < LongestCombined(14) + 9; i++) {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine($"|{{0,-{LongestFirstName(14)}}} | {{1,-{LongestLastName(14)}}} | {{2,-{LongestEmail(14)}}} | {{3,-{LongestPhone(14)}}}|", "First name:", "Last Name:", "Email:", "Phone:");

            foreach(Person contact in contacts) {
                Console.WriteLine($"|{{0,-{LongestFirstName(14)}}} | {{1,-{LongestLastName(14)}}} | {{2,-{LongestEmail(14)}}} | {{3,-{LongestPhone(14)}}}|", contact.FistName, contact.LastName, contact.Email, contact.Phone);
            }
            Console.Write(" ");
            for(int i = 0; i < LongestCombined(14) + 9; i++) {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        public void SaveToFile() {
            string json = JsonSerializer.Serialize(contacts);
            File.WriteAllText(@"C:\Users\jocka\tmp\Övning12osv\contacts.json", json);
        }
        public bool LoadFromJsonSerializer() {
            try {
                string json = File.ReadAllText(@"C:\Users\jocka\tmp\Övning12osv\contacts.json");
                contacts = JsonSerializer.Deserialize<List<Person>>(json);
                return true;
            }
            catch(Exception) {
                return false;
            }

        }

        public void RemoveContact() {
            Console.WriteLine("Remove contact");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            int index = contacts.FindIndex(contact => contact.FistName == firstName && contact.LastName == lastName);
            contacts.Remove(contacts[index]);
        }
        public void SortContacts() {
            Console.WriteLine("Sort contacts");
            contacts.Sort((x, y) => x.FistName.CompareTo(y.FistName));
        }
        int LongestFirstName(int min) {
            int longest = 0;
            foreach(Person contact in contacts) {
                if(contact.FistName.Length > longest)
                    longest = contact.FistName.Length;
            }
            if(longest < min) {
                longest = min;
            }
            return longest;
        }
        int LongestLastName(int min) {
            int longest = 0;
            foreach(Person contact in contacts) {
                if(contact.LastName.Length > longest)
                    longest = contact.LastName.Length;
            }
            if(longest < min) {
                longest = min;
            }
            return longest;
        }
        int LongestEmail(int min) {
            int longest = 0;
            foreach(Person contact in contacts) {
                if(contact.Email.Length > longest)
                    longest = contact.Email.Length;
            }
            if(longest < min) {
                longest = min;
            }
            return longest;
        }
        int LongestPhone(int min) {
            int longest = 0;
            foreach(Person contact in contacts) {
                if(contact.Phone.Length > longest)
                    longest = contact.Phone.Length;
            }
            if(longest < min) {
                longest = min;
            }
            return longest;
        }
        int LongestCombined(int min) {
            return LongestFirstName(min) + LongestLastName(min) + LongestEmail(min) + LongestPhone(min);
        }
    }
}
