namespace FactoryMethod.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaShop pizzaShop;
            Pizza pizza;

            pizzaShop = new ArgentinianPizzaShop();
            pizza = pizzaShop.CreatePizza("napo");
            pizza.Render();
            pizza = pizzaShop.CreatePizza("stadium");
            pizza.Render();

            pizzaShop = new ItalianPizzaShop();
            pizza = pizzaShop.CreatePizza("napo");
            pizza.Render();
            pizza = pizzaShop.CreatePizza("stadium");
            pizza.Render();
            Console.ReadKey();
        }
    }
}