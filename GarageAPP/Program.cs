

using GarageAPP;
using GarageAPP.Vehicles;
using System;
using System.Collections;


namespace GarageAP
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the capacity of the garage:");
            int capacity = int.Parse(Console.ReadLine());

            GarageHandler garageHandler = new GarageHandler(capacity);
            Console.WriteLine($"A garage is ceated and it can accomadate {capacity} vehicles");
            UI ui = new UI (garageHandler);
            ui.Start();

            
        }

    

    }
}

























           












