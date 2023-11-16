namespace DecoratorPattern
{
    public class Sugar : AddedDecorator
    {
        public Sugar(DrinkComponent drink) : base(drink) { }
        public override double Cost => _drink.Cost + 0.5;
        public override string Description => string.Format($"{_drink.Description}, Sugar");

    }
}
