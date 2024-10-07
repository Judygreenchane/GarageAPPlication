using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageAPP.Interfaces;
using GarageAPP.Vehicles;

namespace GarageAPP
{
    internal class GarageHandler : IHandler
    {
        private Garage<IVehicle> garage;

        public GarageHandler(int capacity)
        {
            garage = new Garage<IVehicle>(capacity);
        }



        public void ParkVehicle(IVehicle vehicle)
        {
            if (garage.AddVehicle(vehicle))
            {
                Console.WriteLine($"Vehicle with registration number {vehicle.RegNo} is  parked.");
            }
            else
            {
                Console.WriteLine("Failed to park the vehicle.");
            }
        }

        public void ListAllVehicles()
        {
            Console.WriteLine("All vehicles in the garage:");
            foreach (var vehicle in garage)
            {
                Console.WriteLine($"Registration number : {vehicle.RegNo}  Color : {vehicle.Color}  and have {vehicle.NumberOfWheels} wheels");
            }
        }

        public void RemoveVehicle(string regNo)
        {
            if (garage.RemoveVehicle(regNo))
            {
                Console.WriteLine($"Vehicle with registration number  {regNo} has taken out from garage");
            }
            else
            {
                Console.WriteLine($"Vehicle with  {regNo} is not found.");
            }
        }
        public IVehicle[] SearchVehicles(string color, int wheels)
        {
            return garage.SearchVehicles(color, wheels);
        }
        public IVehicle[] SearchVehicles(string color)
        {
            return garage.SearchVehicles(color);
        }
        public IVehicle[] SearchVehicles( int wheels)
        {
            return garage.SearchVehicles( wheels);
        }
        public void ListVehicleTypes()
        {
            var cars = garage.OfType<Car>().Count();
            var buses = garage.OfType<Bus>().Count();
            var motorcycle =garage.OfType<Motorcycle>().Count();
            var airplane =garage.OfType<Airplane>().Count();
            var boat = garage.OfType<Boat>().Count();
            Console.WriteLine($"Cars: {cars}, Buses: {buses} , Motorcycles: {motorcycle},Aeroplanes: {airplane},Boats: {boat}");
        }


       
    }

}
