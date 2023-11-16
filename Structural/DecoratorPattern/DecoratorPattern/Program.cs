namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            DrinkComponent coffee = new DecaffeinatedCoffee();
            coffee = new Cream(coffee);
            coffee = new Sweetener(coffee);
            coffee = new Cinnamon(coffee);

            Console.WriteLine($"Product:  {coffee.Description} has a cost: ${coffee.Cost}");

            coffee = new CoffeeExpress();
            coffee = new Milk(coffee);
            coffee = new Sweetener(coffee);
            coffee = new Cinnamon(coffee);

            Console.WriteLine($"Product:  {coffee.Description} has a cost: ${coffee.Cost}");

            coffee = new JustCafe();
            coffee = new Sweetener(coffee);

            Console.WriteLine($"Product:  {coffee.Description} has a cost: ${coffee.Cost}");


            Console.ReadKey();
        }
    }
}
