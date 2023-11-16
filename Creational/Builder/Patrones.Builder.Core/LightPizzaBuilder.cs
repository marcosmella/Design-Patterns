namespace Builder.Core
{
    public class LightPizzaBuilder : PizzaBuilder
    {
        public LightPizzaBuilder()
        {
            _description = "Light Pizza";
        }
        public override Topping BuildTopping()
        {
            return new Aubergine();
        }

        public override Mass BuildMass()
        {
            return new Integral();
        }

        public override Sauce BuildSauce()
        {
            return new Light();
        }
    }
}
