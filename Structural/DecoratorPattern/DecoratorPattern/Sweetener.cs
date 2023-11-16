namespace DecoratorPattern
{
    public  class Sweetener :AddedDecorator
    {
        public Sweetener(DrinkComponent drink) : base(drink) { }
        public override double Cost => _drink.Cost + 1;
        public override string Description => string.Format($"{_drink.Description}, Sweetener");

    }
}
