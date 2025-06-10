using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical_goods.CableTypes
{
    internal class CableType
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public CableType(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string DisplayName => $"{Name} - {Price} за дюйм";
    }
}
