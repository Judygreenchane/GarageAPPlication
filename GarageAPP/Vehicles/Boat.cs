using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageAPP.Vehicles
{
    internal class Boat : Vehicle
    {
        

        public float LengthOfBoat { get; set; }
        public Boat(string regNo, string color, int numberOfWheels,float lengthOfBoat) : base(regNo, color, numberOfWheels)
        {
            LengthOfBoat=lengthOfBoat;
        }
    }
}
