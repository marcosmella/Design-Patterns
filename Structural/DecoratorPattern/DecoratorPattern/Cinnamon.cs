namespace DecoratorPattern
{
    public class Cinnamon : AddedDecorator
    {
        public Cinnamon(DrinkComponent drink) : base(drink) { }
        public override double Cost => _drink.Cost + 1.75;
        public override string Description => string.Format($"{_drink.Description}, Cinnamon");
    }
}
