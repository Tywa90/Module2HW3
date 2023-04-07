using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GiftBox.Code.CandyItems
{
    public class Sweet : Product
    {
        public Sweet(string name, double weight, double kKal, double shugarIn)
            : base(name, weight, kKal)
        {
            ShugarIn = shugarIn;
        }

        public double ShugarIn { get; set; }
    }
}
