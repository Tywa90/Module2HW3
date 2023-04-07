using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox.Code.CandyItems
{
    public class Chocolate : Candy
    {
        public Chocolate(string name, double weight, double kKal, double shugarIn, string softness, string color)
            : base(name, weight, kKal, shugarIn, softness)
        {
            Color = color;
        }

        public string Color { get; set; }
    }
}
