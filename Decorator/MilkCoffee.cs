using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MilkCoffee : ICoffee
    {
        ICoffee coffee;
        public MilkCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public float GetCost()
        {
            return this.coffee.GetCost() + 2;
        }

        public string GetDescription()
        {
            return this.coffee.GetDescription() + "с молоком";
        }
    }
}
