using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox.Code.CandyItems
{
    public class Caramel : Candy
    {
        public Caramel(string name, double weight, double kKal, double shugarIn, string softness, string caramelStruct)
            : base(name, weight, kKal, shugarIn, softness)
        {
            CaramelStruct = caramelStruct;
        }

        public string CaramelStruct { get; set; }
    }
}
