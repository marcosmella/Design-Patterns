namespace Builder.Core
{
    public abstract  class Topping
    {
        protected string _description;
        public string Description { get { return _description; } }
    }


    public class Oregano : Topping
    {
        public Oregano()
        {
            _description = "Fresh Oregano";
        }
    }

    public class Anchovy : Topping
    {
        public Anchovy()
        {
            _description = "Anchovies in Oil";
        }
    }


    public class Aubergine : Topping
    {
        public Aubergine()
        {
            _description = "Aubergine without calories";
        }
    }

}
