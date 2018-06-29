using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SimpleCoffee : ICoffee
    {
        public float GetCost()
        {
            return 10;
        }

        public string GetDescription()
        {
            return "Обычный кофе";
        }

    }
}
