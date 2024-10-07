using GarageAPP.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageAPP
{
    internal class Garage<T> : IEnumerable<T> where T : IVehicle 
    {
        private T[] vehicles;
        private int count = 0;
        public int Capacity { get; protected set; }

        public Garage(int capacity)
        {
            Capacity = capacity;
            vehicles = new T[capacity];
        }
        //public void AddVehicle(Ivehicle vehicle)
        //{

        //    vehicles[vehicles.Length - 1] =(Vehicle) vehicle;
        //}
        public bool AddVehicle(T vehicle)
        {
            if (count >= Capacity)
            {
                Console.WriteLine("Garage is full and have no more space");
                return false;
            }
            vehicles[count] = vehicle;
            count++;
            return true;
        }
        public bool RemoveVehicle(string regNo)
        {
            for (int i = 0; i < count; i++)
            {
                if (vehicles[i].RegNo.ToLower().Equals(regNo.ToLower()))
                {
                    vehicles[i] = vehicles[count - 1]; // Replace with last vehicle
                    vehicles[count - 1] = default(T);
                    count--;
                    return true;
                }
            }
            return false;
        }
        public T[] SearchVehicles(string color, int wheels)
        {
            return vehicles.Where(v => v != null && v.Color.Equals(color, StringComparison.OrdinalIgnoreCase) && v.NumberOfWheels== wheels).ToArray();
        }
        public T[] SearchVehicles(string color)
        {
            return vehicles.Where(v => v != null && v.Color.Equals(color, StringComparison.OrdinalIgnoreCase)).ToArray();
        }
        public T[] SearchVehicles( int wheels)
        {
            return vehicles.Where(v => v != null &&  v.NumberOfWheels == wheels).ToArray();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehicles[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
