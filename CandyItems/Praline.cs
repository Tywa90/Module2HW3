using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox.Code.CandyItems
{
    public class Praline : Chocolate
    {
        public string Filling { get; set; }
        public Praline(string name, double weight, double kKal, double shugarIn, string softness, string color, string filling)
            : base(name, weight, kKal, shugarIn, softness, color)
        {
            Filling = filling;
        }
    }
}
