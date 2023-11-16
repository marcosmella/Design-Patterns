
namespace FactoryMethod
{
    public class NapolitanaPizza : Pizza
    {
        public NapolitanaPizza(string origin)
        {
            _description = "Napolitana Pizza!";
            _origin = origin;
        }
    }
}