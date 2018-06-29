using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ComputerFacade
    {
        Computer computer;
        public ComputerFacade(Computer computer)
        {
            this.computer = computer;
        }
        public void TurnOn()
        {
            this.computer.GetElectricShock();
            this.computer.MakeSound();
            this.computer.ShowLoadingScreen();
            this.computer.Bam();
        }

        public void TurnOff()
        {
            this.computer.CloseEverything();
            this.computer.PullCurrent();
            this.computer.Sooth();
        }
    }
}
