using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Unidentified_Vehicle : IVehicle
    {
        public void Build()
        {
            Console.WriteLine("Building a new vehicle!");
        }
    }
}
