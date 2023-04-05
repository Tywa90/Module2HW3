using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox.Code.CandyItems
{
    public class ChocoPlate : Chocolate
    {
        public string Type { get; set; }
        public ChocoPlate(string name, double weight, double kKal, double shugarIn, string softness, string color, string type)
            : base(name, weight, kKal, shugarIn, softness, color)
        {
            Type = type;
        }
    }
}
