using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AfricanLion : ILion
    {
        public string Name { get; set; }
        public AfricanLion()
        {
            Name = "African Lion";
        }

        public void Roar()
        {
            Console.WriteLine("African lion is roaring");
        }
    }
}
