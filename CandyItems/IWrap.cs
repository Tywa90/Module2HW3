using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox.Code.CandyItems
{
    public interface IWrap
    {
        void Wrap()
        {
            Console.WriteLine("Default");
            int total = 0;
        }
    }
}
