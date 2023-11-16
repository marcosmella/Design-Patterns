using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Core
{
    public class ItalianPizzaBuilder : PizzaBuilder
    {

        public ItalianPizzaBuilder()
        {
            _description = "Italian Pizza";
        }
        public override Topping BuildTopping()
        {
            return new Anchovy();
        }

        public override Mass BuildMass()
        {
            return new ThinCrust();
        }

        public override Sauce BuildSauce()
        {
            return new Olive();
        }
    }
}
