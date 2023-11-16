namespace Builder.Core
{
    public class MozzarellaPizzaBuilder : PizzaBuilder
    {
        public MozzarellaPizzaBuilder()
        {
            _description = "Mozzarella Pizza";
        }
        public override Topping BuildTopping()
        {
            return new Oregano();
        }

        public override Mass BuildMass()
        {
            return new ThickCrust();
        }

        public override Sauce BuildSauce()
        {
            return new Tomato();
        }
    }
}
