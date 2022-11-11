namespace DelegatesDemoHåkan
{
    internal class Person
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - Birthday.Year;
                if(Birthday > today.AddYears(-age))
                    age--;
                return age;
            }
        }

    }
}
