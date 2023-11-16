namespace DecoratorPattern
{
    public abstract class AddedDecorator : DrinkComponent
    {
        protected DrinkComponent _drink;
        public AddedDecorator(DrinkComponent drink)
        {
            _drink = drink;
        }


    }
}
