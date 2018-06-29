using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AsianLion : ILion
    {
        public string Name { get; set; }
        public AsianLion()
        {
            Name = "Asian Lion";
        }
        public void Roar()
        {
            Console.WriteLine("Asian lion is roaring");
        }
    }
}
