using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageAPP.Interfaces;
using GarageAPP.Vehicles;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GarageAPP
{
    internal class UI : IUI
    {
        private IHandler handler;
        public UI(IHandler handler)
        {
            this.handler = handler;
        }
        public void Start()
        {
            bool running = true;
            while (running)
            {
                DisplayMenu();
                string  choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                             ParkVehicle();
                             break;
                    case "2":
                        handler.ListAllVehicles();
                        break;
                    case "3":
                        Console.WriteLine("Enter Reg Number of vehicle to be removed");
                        string regNo= Console.ReadLine();
                        handler.RemoveVehicle(regNo);
                        break;
                    case "4":
                        SearchVehicles();
                        break;
                    case "5":
                         handler.ListVehicleTypes();
                         break;
                    case "0":
                         Console.WriteLine("Exiting the application.");
                         Environment.Exit(0);
                    break;
                    default:
                    Console.WriteLine("Enter a valid choice to continue");
                    break;

               }
            }
           


           

        }

      

        private void ParkVehicle()
        {
            int wheels = 0;
            int NoOfSeats = 0;
            float cylinderVolume= 0;
            float lengthOfBoat= 0;
            int numberOfEngines = 0;
            Console.Write("Enter vehicle type (Car/Bus/Motorcycle,Boat,Aeroplane):");
            string type = Console.ReadLine().Trim(). ToLower();
            Console.Write("Enter registration number:");
            string regNumber = Console.ReadLine();
            Console.Write("Enter color:");
            string color = Console.ReadLine();
            Console.Write("Enter number of wheels:");
            try
            {
                 wheels = int.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Enter an integer value for number of wheels");
                 }
            IVehicle vehicle;
            switch (type)
            {
                case "car":
                    {
                        Console.Write("Enter Fuel Type");
                        string fuelType = Console.ReadLine();
                         vehicle = new Car(regNumber,color,wheels,fuelType);
                        handler.ParkVehicle(vehicle);
                        break;
                    }
                case "bus":
                    {
                        Console.Write("Enter Number of seats:");
                        try
                        {
                             NoOfSeats = int.Parse(Console.ReadLine());
                        }
                        catch {
                            Console.WriteLine("Enter an integer value for number of seats");
                        }
                        vehicle = new Bus(regNumber, color, wheels, NoOfSeats);
                        handler.ParkVehicle(vehicle);
                        break;
                    }
                case "motorcycle":
                    {
                        Console.Write("Enter Cylinder volume:");
                        try { 
                         cylinderVolume =float.Parse( Console.ReadLine());
                           }
                        catch {
                            Console.WriteLine("Enter a float value for cylinder volume");
                        }


                        vehicle = new Motorcycle(regNumber, color, wheels, cylinderVolume);
                        handler.ParkVehicle(vehicle);
                        break;
                    }
                case "boat":
                    {
                        Console.Write("Enter Length of boat:");
                        try
                        {
                            lengthOfBoat = float.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Enter a float value for length of boat");
                        }
                         vehicle = new Boat(regNumber,color,wheels,lengthOfBoat);
                        handler.ParkVehicle(vehicle);
                        break;
                    }
                case "aeroplane":
                    {
                        Console.WriteLine("Enter No of engines:");
                        try
                        {
                          numberOfEngines = int .Parse(Console.ReadLine());
                        }
                        catch {
                            Console.WriteLine("Enter an integer  value for number of engines");
                        }
                        vehicle = new Airplane(regNumber,color,wheels,numberOfEngines);
                        handler.ParkVehicle(vehicle);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please enter a correct value for vehicle type");
                        break;
                    }




            }
            
        }
        

        public void DisplayMenu()
        {
            Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 0) of your choice"
                     + "\n1. Parking of Vehicle(via registration number)"
                     + "\n2. List all vehicles in the Garage"
                     + "\n3  Remove vehicles from the garage (via registration number)"
                     + "\n4. Search for vehicles"
                     + "\n5.List vehicle types and number of each"
                     + "\n0. Exit the application");
            
        }


        private void SearchVehicles()
        {
            Console.WriteLine("Enter color to search for:");
            string color = Console.ReadLine();
            Console.WriteLine("Enter number of wheels:");
            int wheels = int.Parse(Console.ReadLine());

            var Vehicles = handler.SearchVehicles(color, wheels);
            if (Vehicles.Length == 0)
            {
                Console.WriteLine("No matching vehicles found.");
            }
            else
            {
                foreach (var vehicle in Vehicles)
                {
                    Console.WriteLine($" Register number :{vehicle.RegNo}  Color : {vehicle.Color} & {vehicle.NumberOfWheels} wheels");
                }
            }
        }


    }
}
