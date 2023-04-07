using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftBox.Code.CandyItems;

namespace GiftBox.Code
{
    public static class GiftBoxExtension
    {
        public static Product FindMaxCalories(this Product[] product, double calories)
        {
            foreach (var item in product)
            {
                if (item.Kkal >= calories)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
