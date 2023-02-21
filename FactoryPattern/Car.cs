using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicles
    {
        public string Color { get; set; }
        public bool IsDrivable { get; set; }

        public void Drive()
        {
            Console.WriteLine($"sorry im driving my {Color} car");
        }
    }
}
