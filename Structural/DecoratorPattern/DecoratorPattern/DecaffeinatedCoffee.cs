namespace DecoratorPattern
{
    public class DecaffeinatedCoffee : DrinkComponent
    {
        public override double Cost => 15;
        public override string Description => "Decaffeinated Coffee";
    }
}
