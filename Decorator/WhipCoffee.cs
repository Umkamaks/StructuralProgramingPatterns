using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WhipCoffee : ICoffee
    {
        ICoffee coffee;
        public WhipCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public float GetCost()
        {
            return this.coffee.GetCost() + 5;
        }

        public string GetDescription()
        {
            return this.coffee.GetDescription() + "со сливками";
        }
    }
}
