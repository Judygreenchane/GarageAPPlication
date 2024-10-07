using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageAPP.Interfaces
{
    internal interface IHandler
    {
        void ParkVehicle(IVehicle vehicle);
        void ListAllVehicles();
        void RemoveVehicle(string regNo);
        IVehicle[] SearchVehicles(string color, int wheels);
        
        void ListVehicleTypes();
      
    }
}
