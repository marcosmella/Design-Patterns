
namespace Builder.Core
{
    public abstract class Mass
    {
         protected string _description;
        public string Description { get { return _description; } }
    }

    public class ThickCrust : Mass
    {
        public ThickCrust()
        {
            _description = "Thick Crust dough";
        }
    }

    public class ThinCrust : Mass
    {
        public ThinCrust()
        {
            _description = "Thin Crust dough";
        }
    }

    public class Integral : Mass
    {
        public Integral()
        {
            _description = "Integral Dough";
        }
    }

}
