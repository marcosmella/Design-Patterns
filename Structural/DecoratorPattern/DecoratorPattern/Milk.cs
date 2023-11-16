namespace DecoratorPattern
{
    public class Milk : AddedDecorator
    {
        public Milk(DrinkComponent drink) : base(drink) { }
        public override double Cost => _drink.Cost + 2;
        public override string Description => string.Format($"{_drink.Description}, Milk");
    }
}
