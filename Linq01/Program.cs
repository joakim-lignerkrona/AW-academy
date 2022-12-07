namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pasteries = new List<Pastry>();
            pasteries.Add(new Pastry { Name = "Danish", Price = 45.50, Calories = 250 });
            pasteries.Add(new Pastry { Name = "Danish", Price = 42.50, Calories = 230 });
            pasteries.Add(new Pastry { Name = "Danish", Price = 42.50, Calories = 450 });
            pasteries.Add(new Pastry { Name = "Cheesecake", Price = 37.9, Calories = 380 });
            pasteries.Add(new Pastry { Name = "Cookie", Price = 5, Calories = 100 });
            pasteries.Add(new Pastry { Name = "Cupcake", Price = 10, Calories = 200 });
            pasteries.Add(new Pastry { Name = "Donut", Price = 8, Calories = 150 });
            pasteries.Add(new Pastry { Name = "Eclair", Price = 20, Calories = 300 });
            pasteries.Add(new Pastry { Name = "Fruitcake", Price = 30, Calories = 400 });
            pasteries.Add(new Pastry { Name = "Gingerbread", Price = 15, Calories = 200 });
            pasteries.Add(new Pastry { Name = "Honey Bun", Price = 12, Calories = 250 });
            pasteries.Add(new Pastry { Name = "Ice Cream", Price = 25, Calories = 350 });
            pasteries.Add(new Pastry { Name = "Jelly Roll", Price = 35, Calories = 450 });
            pasteries.Add(new Pastry { Name = "Kolache", Price = 40, Calories = 500 });
            pasteries.Add(new Pastry { Name = "Lemon Bar", Price = 45, Calories = 550 });

            var cheapPasteries = pasteries
              .Where(p => p.Calories > 150);



            //Console.WriteLine(cheapPasteries);
            Console.WriteLine($"{"Name",-15}| {"Price",5}| {"Calories",8}");
            foreach(var pastry in cheapPasteries)
            {
                Console.WriteLine($"{pastry.Name,-15}| {pastry.Price,5}| {pastry.Calories,8}");
            }
            foreach(var pastry in cheapPasteries)
            {
                Console.WriteLine(pastry);
            }


        }

        class Pastry
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Calories { get; set; }

            public override string ToString()
            {
                return $"{Name}\n  Price: {Price}\n  Calories: {Calories}";
            }

        }
    }
}