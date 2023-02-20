using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelNumber)
        {
            if (wheelNumber == 2)
            {
                return new Motorcycle();
            }
            else if (wheelNumber == 4)
            {
                return new Car();
            }
            else if (wheelNumber == 18)
            {
                return new SemiTruck();
            }
            else
                return new Unidentified_Vehicle();

        }
        public static IVehicle GetVehicle()
        {
            Console.WriteLine("Please type how many wheels your vehicle has. Options' 2, 4, or 18.");
            var userInput = Console.ReadLine();
            
        switch (userInput)
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                case "18":
                    return new SemiTruck();
                default:
                    return  new Unidentified_Vehicle();

            }
        }
    }
}
