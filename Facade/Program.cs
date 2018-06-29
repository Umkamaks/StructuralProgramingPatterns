using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            ComputerFacade computerFacade = new ComputerFacade(computer);
            computerFacade.TurnOn();
            computerFacade.TurnOff();

            Console.ReadKey();

        }
    }
}
