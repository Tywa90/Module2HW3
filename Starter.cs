using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftBox.Code.CandyItems;

namespace GiftBox.Code
{
    public class Starter
    {
        public static void Run()
        {
            Praline redMack = new Praline("Червоний мак", 17, 88.4, 8.1, "crumbly", "black", "Карамельна крихта, паста ядер горіхів");
            Praline karakum = new Praline("Кара-кум", 15.9, 85.1, 8.2, "crumbly", "black", "Карамельна крихта, паста ядер горіхів");
            Caramel cow = new Caramel("Корівка", 16.2, 60.8, 10.85, "soft", "Ніжна молочна помадка");
            ChocoType ritter = new ChocoType("Шоколад Ritter-Sport", 100, 627, 24, "solid", "black", "молочний");

            GiftBox boxStart = new GiftBox();
            boxStart.AddGift(redMack, 2);
            boxStart.AddGift(karakum, 3);
            boxStart.AddGift(cow, 3);
            boxStart.AddGift(ritter, 1);

            boxStart.Wrap();
            boxStart.CompareCalories();
        }
    }
}
