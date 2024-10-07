using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageAPP.Vehicles
{
    internal class Bus : Vehicle
    {
        

        public int NumberOfSeats { get; set; }
        public Bus(string regNo, string color, int numberOfWheels,int numberOfSeats) : base(regNo, color, numberOfWheels)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
