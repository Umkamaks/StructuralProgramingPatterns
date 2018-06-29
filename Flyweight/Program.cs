using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaMaker teaMaker = new TeaMaker();
            TeaShop teaShop = new TeaShop(teaMaker);
            teaShop.takeOrder("меньше сахара", 1);
            teaShop.takeOrder("больше молока", 2);
            teaShop.takeOrder("без сахара", 15);
            teaShop.takeOrder("без сахара", 15);
            teaShop.Serve();
            Console.ReadKey();
        }
    }
}
