using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем охотника
            Hunter hunter = new Hunter();

            //Создаем Африканского льва
            ILion africanLion = new AfricanLion();

            hunter.Hunt(africanLion); //охота на африканского льва
           
            // создаем азиатского льва
            ILion asianLion = new AsianLion();
            hunter.Hunt(asianLion); //охота на азиатского льва

            // создаем собаку
            WildDog wildDog = new WildDog();
            //  hunter.Hunt(wildDog); //охота на собаку . Ошибка!!!! WildDog не имеет ILion интерфейса

            // создаем Адаптер
            Adapter adapter = new Adapter(wildDog);

            hunter.Hunt(adapter); //охота на собаку


            Console.ReadKey();

        }
    }
}
