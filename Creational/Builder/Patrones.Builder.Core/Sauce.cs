namespace Builder.Core
{
    public abstract class Sauce
    {
        protected string _description;
        public string Description { get { return _description; } }
    }


    public class Tomato : Sauce
    {
        public Tomato()
        {
            _description = "Classic tomato sauce";
        }
    }

    public class Olive : Sauce
    {
        public Olive()
        {
            _description = "Tomato sauce with olive";
        }
    }

    public class Light : Sauce
    {
        public Light()
        {
            _description = "Sauce without dressing and seasonings";
        }
    }


    public class GarlicOil : Sauce
    {
        public GarlicOil()
        {
            _description = "Garlic Oil Sauce";
        }
    }

}
