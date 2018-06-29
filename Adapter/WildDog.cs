using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WildDog
    {
       public string Name { get; set; }
        public WildDog()
        {
            Name = "Wild Dog";
        }
        public void Bark() //Рычать
        {
            Console.WriteLine("Wild Dog is barking");
        }
    }
}
