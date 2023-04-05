using GiftBox.Code.CandyItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox.Code
{
    public class Starter
    {
        private static Product[] _productsList;
        public static void Run()
        {
            
            Praline redMack = new Praline("Червоний мак", 17, 88.4, 8.1, "crumbly", "black", "Карамельна крихта, паста ядер горіхів");
            Praline karakum = new Praline("Кара-кум", 15.9, 85.1, 8.2, "crumbly", "black", "Карамельна крихта, паста ядер горіхів");
            Caramel cow = new Caramel("Корівка", 16.2, 60.8, 10.85, "soft", "Ніжна молочна помадка");
            ChocoPlate ritter = new ChocoPlate("Шоколад Ritter-Sport", 100, 627, 24, "solid", "black", "молочний");

            GiftBox.Wrap();

            _productsList = new Product[] { redMack, karakum, cow, ritter };

            DisplayBox();

        }

        public static void DisplayBox()
        {
            foreach (var item in _productsList)
            {
                Console.WriteLine(item.Name);
            }
        }
      
    }
}
