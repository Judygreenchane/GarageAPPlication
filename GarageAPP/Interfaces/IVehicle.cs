using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageAPP.Interfaces
{
    internal interface IVehicle 
    {
        string RegNo  { get; }
        string Color { get; }
        int NumberOfWheels { get; }
       
        void ParkVehicle();
        //void RemoveVehicle();
    }
}
