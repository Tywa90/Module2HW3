using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftBox.Code.CandyItems;

namespace GiftBox.Code
{
    public class Services
    {
        public static GiftBox BoxStart { get; set; }

        public static Product[] ProdArray { get; set; }
        public static void ProductsCreate()
        {
            Praline redMack = new Praline("Червоний мак", 17, 88.4, 8.1, "crumbly", "black", "Карамельна крихта, паста ядер горіхів");
            Praline karakum = new Praline("Кара-кум", 15.9, 85.1, 8.2, "crumbly", "black", "Карамельна крихта, паста ядер горіхів");
            Caramel cow = new Caramel("Корівка", 16.2, 60.8, 10.85, "soft", "Ніжна молочна помадка");
            ChocoType ritter = new ChocoType("Шоколад Ritter-Sport", 100, 627, 24, "solid", "black", "молочний");

            ProdArray = new Product[] { redMack, karakum, cow, ritter };
        }

        public static void BoxCreate()
        {
            BoxStart = new GiftBox();
            for (int i = 0; i < ProdArray.Length; i++)
            {
                BoxStart.AddGift(ProdArray[i], 2);
            }

            BoxStart.Wrap();
        }

        public static void PrintInfo()
        {
            double totalWeight = 0;
            BoxStart.CompareCalories();

            Console.WriteLine("Сортировка по параметру product.Kkal:");
            foreach (var item in GiftBox.GiftBoxList)
            {
                Console.WriteLine(item.Name + " = " + item.Kkal + "KCal");
                totalWeight += item.Weight;
            }

            var warningCalories = GiftBox.GiftBoxList.FindMaxCalories(200);
            Console.WriteLine("Этот продукт очень калорийный: " + warningCalories.Name);

            Console.WriteLine("Вес сладостей: " + totalWeight);
        }
    }
}
