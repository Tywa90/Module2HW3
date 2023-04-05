using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox.Code.CandyItems
{
    public class Product
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Kkal { get; set; }
        public Product(string name, double weight, double kKal)
        {
            Name = name;
            Weight = weight;
            Kkal = kKal;
        }
        
    }
}
