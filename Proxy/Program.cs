using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Security door = new Security(new LabDoor());

            door.Open("321");

            door.Open("123");

            door.Close();
            Console.ReadKey();
            
        }
    }
}
