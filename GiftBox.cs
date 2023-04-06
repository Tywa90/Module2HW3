using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftBox.Code.CandyItems;

namespace GiftBox.Code
{
    public class GiftBox : IWrap
    {
        private static Product[] _giftBoxList;
        private static int arrLength = 0;
        private static int j = 0;

        public void AddGift(Product gift, int quant)
        {
            for (int i = 0; i < quant; i++)
            {
                arrLength++;
                Array.Resize(ref _giftBoxList, arrLength);
                _giftBoxList[j] = gift;
                j++;
            }
        }

        public void Wrap()
        {
            Console.WriteLine($"Box is packed with items inside:");
            int num = 1;
            foreach (var item in _giftBoxList)
            {
                Console.WriteLine($"{num}. {item.Name}");
                num++;
            }
        }

        public void CompareCalories()
        {
            Array.Sort(_giftBoxList);
            for (int k = 0; k < _giftBoxList.Length; k++)
            {
                Console.WriteLine($"{_giftBoxList[k].Name} = {_giftBoxList[k].Kkal}KCal");
            }
        }
    }
}
