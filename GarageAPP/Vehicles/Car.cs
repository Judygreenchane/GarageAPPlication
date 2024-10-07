using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageAPP.Vehicles
{
    internal class Car : Vehicle
    {
        public string FuelType { get; set; }

        public Car(string regNo, string color ,int numberOfWheels,string fuelType): base (regNo,color,numberOfWheels)
        {
            FuelType = fuelType;
        }
        public override void ParkVehicle()
        { 
            Console.WriteLine("HIHI");
            //Garage<T> garage = new Garage<T> ;

            //Console.WriteLine("Enter registration number:");
            //string regNumber = Console.ReadLine();
            //Console.WriteLine("Enter color:");
            //string color = Console.ReadLine();
            //Console.WriteLine("Enter number of wheels:");
            //int wheels = int.Parse(Console.ReadLine());
           
        }
    }
}
