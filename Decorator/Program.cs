using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffeeSimple = new SimpleCoffee();
            Console.WriteLine($"Кофе {coffeeSimple.GetDescription()} стоит {coffeeSimple.GetCost()}");

            ICoffee coffeeMilk = new MilkCoffee(coffeeSimple);
            Console.WriteLine($"Кофе {coffeeMilk.GetDescription()} стоит {coffeeMilk.GetCost()}");

            ICoffee coffeeVanilla = new VanillaCoffee(coffeeSimple);
            Console.WriteLine($"Кофе {coffeeVanilla.GetDescription()} стоит {coffeeVanilla.GetCost()}");

            ICoffee coffeeWhip = new WhipCoffee(coffeeSimple);
            Console.WriteLine($"Кофе {coffeeWhip.GetDescription()} стоит {coffeeWhip.GetCost()}");

            Console.ReadKey();


        }
    }
}
