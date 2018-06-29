using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TeaShop
    {
        TeaMaker teaMaker;
        Dictionary<int, KarakTea> dict = new Dictionary<int, KarakTea>();

        public TeaShop(TeaMaker teaMaker)
        {
            this.teaMaker = teaMaker;
        }
        public void takeOrder(string teaType, int table)
        {
            this.dict[table] = this.teaMaker.Make(teaType);      
        }
        public void Serve()
        {          
            foreach (var order in dict)
            {
                Console.WriteLine( $"Принести чай, столик №{order.Key} с {order.Value.Preference}");
            }
        }
    }
}
