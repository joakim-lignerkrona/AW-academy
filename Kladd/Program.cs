namespace Kladd {
    internal class Program {
        static void Main(string[] args) {
            SingleTest mySingle = SingleTest.GetInstance();

            SingleTest secondSingle = SingleTest.GetInstance();
            DateTime soon = DateTime.Now;
            soon = soon.AddSeconds(1);
            while(DateTime.Now.ToFileTimeUtc() < soon.ToFileTimeUtc()) {
                mySingle.StartCounting();
            }
            Console.WriteLine(secondSingle.CurrentCount());


        }

    }
}