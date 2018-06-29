using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class LabDoor : IDoor
    {
        public void Open()
        {
            Console.WriteLine("Дверь открывается");
        }

        public void Close()
        {
            Console.WriteLine("Дверь закрывается");
        }
    }
}
