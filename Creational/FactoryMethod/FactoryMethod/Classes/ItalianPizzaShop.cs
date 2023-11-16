
namespace FactoryMethod
{
    public class ItalianPizzaShop : PizzaShop
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "stadium")
            {
                return new StadiumPizza("Italia");
            }
            else if (type == "napo")
            {
                return new NapolitanaPizza("Italia");
            }
            else
            {
                return null;
            }
        }
    }
}