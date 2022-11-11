using Spectre.Console;
namespace CodealongRepetition {
    internal class Program {
        static void Main(string[] args) {
            AnsiConsole.Write(new FigletText("Hello World!").Centered());
            var person = new Person();
            person.Name = null;
            Console.WriteLine(person.Name);
        }
    }

    class Person {

        private string name;

        public string Name {
            get { return name; }
            set {
                if(value == null) {
                    throw new ArgumentNullException(nameof(Name));
                }
                this.name = value;
            }
        }


        //public string GetName() {
        //    return name;
        //}
        //public void SetName(string name) {
        //    if(name == null) {
        //        throw new ArgumentNullException();
        //    }
        //    this.name = name;
        //}

    }

}