using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
   public class Hunter
    {
        public void Hunt (ILion lion)
        {
            Console.WriteLine("Hunter is hunting on {0}",lion.Name);
        }
    }
}
