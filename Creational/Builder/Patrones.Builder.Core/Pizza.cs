using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Core
{
    public  class Pizza
    {
        Mass _mass;
        Sauce _sauce;
        Topping _topping;
        string _type;

        public override string ToString()
        {
            return $"{_type}, Mass: {_mass.Description}, Sauce: {_sauce.Description}, Topping: {_topping.Description}";
        }


        public Pizza(Mass mass, Sauce sauce,Topping topping, string type)
        {
            _mass = mass;
            _sauce = sauce;
            _topping = topping;
            _type = type;
        }
    }
}
