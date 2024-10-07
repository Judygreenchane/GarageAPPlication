using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageAPP.Vehicles
{
    internal class Airplane : Vehicle
    {
       

        public int NumberOfEngines { get; set; }

        public Airplane(string regNo, string color, int numberOfWheels, int numberOfEngines) : base(regNo, color, numberOfWheels)
        {
            NumberOfEngines = numberOfEngines;

        }
    }
}
