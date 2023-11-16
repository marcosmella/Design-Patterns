using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Core
{
    public class Bazooka : Weapon
    {
        public override string Shoot()
        {
            return "Shooting with an Bazooka";
        }
    }
}
