using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox.Code
{
    public static class ArrayExtention
    {
        public static Array[] ArrayPrint(this Array[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }
    }
}
