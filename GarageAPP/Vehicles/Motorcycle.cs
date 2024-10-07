using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageAPP.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        

        public float CylinderVolume { get; set; }
        public Motorcycle(string regNo, string color, int numberOfWheels, float cylinderVolume) : base(regNo, color, numberOfWheels)
        {
            CylinderVolume  =  cylinderVolume;

        }
    }
}
