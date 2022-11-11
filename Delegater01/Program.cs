namespace Delegater01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action[] carAction = new Action[] { Accelerate, Decelerate };

            foreach(Action action in carAction)
            {
                action();

            }


        }
        static void Accelerate() => Console.WriteLine("Accelerating");
        static void Decelerate() => Console.WriteLine("Decelerating");


    }
}