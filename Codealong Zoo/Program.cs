namespace Codealong_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var cat = new Cat();
            var dog = new Dog(10);
            var animals = new List<Animal> { cat, dog };
            //dog.Eats(cat);
            Console.WriteLine(cat.Weight);
            Console.WriteLine(dog.Weight);

            animals.ForEach(animal =>
            {
                var Chihuahua = new Dog(1);
                animal.MakeSound();
                Chihuahua.MakeSound();
                animal.Eats(Chihuahua);
                Console.WriteLine($"{animal.GetType().Name}: {animal.Weight}");
            });
        }
    }
    abstract class Animal
    {
        public double Weight { get; set; }

        public virtual void Eats(Animal food)
        {
            Weight += food.Weight;
        }
        public Animal(double weight)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return base.ToString() + ", Weight: " + Weight;
        }
        public abstract void MakeSound();
    }

    class Cat : Animal
    {
        public Cat() : base(4.5)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }


    class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {
        }

        public override void Eats(Animal food)
        {
            Weight += food.Weight * 0.8;
        }

        public override void MakeSound()
        {
            Console.WriteLine(Weight < 3 ? "Arf" : "Woof");
        }
    }
}