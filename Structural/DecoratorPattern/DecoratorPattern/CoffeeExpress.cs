using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class CoffeeExpress : DrinkComponent
    {
        public override double Cost => 12;
        public override string Description => "Coffee Express";
    }
}
