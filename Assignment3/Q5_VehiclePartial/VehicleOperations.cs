using System;

namespace Q5_VehiclePartial
{
    public partial class Vehicle
    {
        public void DisplayVehicle()
        {
            Console.WriteLine("Vehicle Number: " + VehicleNumber);
            Console.WriteLine("Vehicle Name: " + VehicleName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
        }

        public void StartVehicle()
        {
            Console.WriteLine("Vehicle Started");
        }

        public void StopVehicle()
        {
            Console.WriteLine("Vehicle Stopped");
        }
    }
}