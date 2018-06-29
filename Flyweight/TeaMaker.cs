using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TeaMaker
    {
        List<KarakTea> availableTea = new List<KarakTea>();

        public KarakTea Make(string preference)
        {

            bool i = this.availableTea.Exists(m => m.Preference == preference);
            if (!i)
            {
                this.availableTea.Add(new KarakTea() { Preference = preference });
            }
            return this.availableTea.Find(m => m.Preference == preference);
        }
    }
}
