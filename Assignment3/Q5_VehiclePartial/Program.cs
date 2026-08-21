using System;

namespace Q5_VehiclePartial
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.VehicleNumber = "UP85AB1234";
            vehicle.VehicleName = "Honda City";
            vehicle.VehicleType = "Car";

            vehicle.DisplayVehicle();
            vehicle.StartVehicle();
            vehicle.StopVehicle();

            Console.ReadKey();
        }
    }
}