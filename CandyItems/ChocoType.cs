using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox.Code.CandyItems
{
    public class ChocoType : Chocolate
    {
        public ChocoType(string name, double weight, double kKal, double shugarIn, string softness, string color, string type)
            : base(name, weight, kKal, shugarIn, softness, color)
        {
            Type = type;
        }

        public string Type { get; set; }
    }
}
