using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class VanillaCoffee : ICoffee
    {
        ICoffee coffee;
        public VanillaCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public float GetCost()
        {
            return this.coffee.GetCost() + 3;
        }

        public string GetDescription()
        {
            return this.coffee.GetDescription() + "ваниль";
        }
    }
}
