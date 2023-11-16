
namespace FactoryMethod
{
    public class StadiumPizza : Pizza
    {
        public StadiumPizza(string origin)
        {
            _description = "Pizza de stadium";
            _origin = origin;
        }
    }
}