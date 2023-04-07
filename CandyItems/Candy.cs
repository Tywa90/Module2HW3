using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GiftBox.Code.CandyItems
{
    public class Candy : Sweet
    {
        public Candy(string name, double weight, double kKal, double shugarIn, string softness)
            : base(name, weight, kKal, shugarIn)
        {
            Softness = softness;
        }

        public string Softness { get; set; }
    }
}
