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
            Services.ProductsCreate();
            Services.BoxCreate();
            Services.PrintInfo();
        }
    }
}
