namespace Builder.Core
{
    public abstract class PizzaBuilder
    {

        protected string _description;
        public abstract Mass BuildMass();
        public abstract Sauce BuildSauce();
        public abstract Topping BuildTopping();

        public override string ToString()
        {
            return _description;
        }
        public Pizza BuildPizza()
        {
            Mass mass = BuildMass();
            Sauce sauce = BuildSauce();
            Topping topping = BuildTopping() ;

            return new Pizza(mass,sauce,topping,_description);
        }
    }
}
