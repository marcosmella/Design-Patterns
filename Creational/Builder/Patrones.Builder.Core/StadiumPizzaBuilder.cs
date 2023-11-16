namespace Builder.Core
{
    public class StadiumPizzaBuilder : PizzaBuilder
    {

        public StadiumPizzaBuilder()
        {
            _description = "Stadium Pizza";
        }
        public override Topping BuildTopping()
        {
           return new Anchovy();
        }

        public override Mass BuildMass()
        {
            return new Integral();
        }

        public override Sauce BuildSauce()
        {
            return new GarlicOil();
        }
    }
}
