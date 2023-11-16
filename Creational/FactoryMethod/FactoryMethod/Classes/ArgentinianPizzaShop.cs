
namespace FactoryMethod
{
    public class ArgentinianPizzaShop : PizzaShop
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "stadium")
            {
                return new StadiumPizza("Argentina");
            }
            else if (type == "napo")
            {
                return new NapolitanaPizza("Argentina");
            }
            else
            {
                return null;
            }
        }
    }
}