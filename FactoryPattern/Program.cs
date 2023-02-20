using System.Buffers.Text;
using System.ComponentModel;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newVeh = VehicleFactory.GetVehicle(2);
            var newCar = VehicleFactory.GetVehicle(4);
            var newSemi = VehicleFactory.GetVehicle(18);
            var weirdVeh = VehicleFactory.GetVehicle(19);
            newVeh.Build();
            newCar.Build();
            newSemi.Build();
            weirdVeh.Build();
            var userVehicle = VehicleFactory.GetVehicle();
            userVehicle.Build();

            


//Now we will make our static VehicleFactory class.
//It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
//Call this functionality in the Main method.
        }
    }
}
