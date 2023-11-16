namespace DecoratorPattern
{
    public class Cream : AddedDecorator
    {
        public Cream(DrinkComponent drink) : base(drink) { }
        public override double Cost => _drink.Cost + 4;
        public override string Description => string.Format($"{_drink.Description}, Cream");
    
    }
}
