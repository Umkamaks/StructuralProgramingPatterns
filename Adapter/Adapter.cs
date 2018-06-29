using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : ILion
    {
        public string Name { get ; set; }
        protected WildDog wildDog;

        public Adapter (WildDog wildDog)
        {
            Name = wildDog.Name;
            this.wildDog = wildDog;
        }
        public void Roar()
        {
            wildDog.Bark();
        }
    }
}
