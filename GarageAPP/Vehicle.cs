using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageAPP.Interfaces;

namespace GarageAPP
{
    internal class Vehicle : IVehicle
    {
        public string RegNo { get; set; }
        public  string Color { get; set; }

        public int  NumberOfWheels { get; set; }

        public Vehicle(string regNo, string color, int numberOfWheels)
        {
            RegNo = regNo;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }

      
        public virtual void ParkVehicle()
        {
            
        }
    }
}
