using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageProject
{
    public class GarageHandler
    {
        Garage<Vehicle> garage;
        UI uI = new UI();
    

        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }

        public void WriteAllHandler()
        {
            foreach (var v in garage)
            {
                uI.WriteAll(v);
            }

        }

        public void CountVehicleHandler()
        {
            var dict = new Dictionary<string, int>
            {

                { "car" , 0 },
                { "motorcycle" , 0 },
                { "mopeds" , 0 },
                { "airplan" , 0 },
                { "bus" , 0 },
                { "boat" , 0 },
                { "bicycle" , 0 },

            };

            foreach (var v in garage)
            {
                if (v is Cars) dict["car"] += 1;
                else if (v is Motorcycles) dict["motorcycle"] += 1;
                else if (v is Mopeds) dict["mopeds"] += 1;
                else if (v is Airplane) dict["airplan"] += 1;
                else if (v is Bus) dict["bus"] += 1;
                else if (v is Boat) dict["boat"] += 1;
                else if (v is Bicycle) dict["bicycle"] += 1;
            }

            uI.CountVehicleWrite(dict);
        }

        public bool Add(Vehicle vehicle)
        {
          return  garage.Add(vehicle);
        }

        public bool Remove(Vehicle vehicle)
        {
            return garage.Remove(vehicle);
        }

        // Remove vehicle with regNo
        public void RemoveRegNumHandler(string valueregNo)
        {
            for (int i = garage.Count - 1; i >= 0; i--)
            {
                if (garage[i].RegNo.ToLower() == valueregNo.ToLower())
                {
                    garage.Remove(garage[i]);
                    //mylist.RemoveAt(i);
                }
            }

        }

        // Set Max Capacity
        public void CapacityGarageHandler(string input2)
        {
            int IntValue = uI.Validinput(input2);
            garage = new Garage<Vehicle>(IntValue);

            //garage.capacity = IntValue;

            Console.WriteLine("\nMax Garage Capacity: {0}", garage.capacity );
            //return capNew;

        }

        // Find vehicle with color and wheels
        public void FindVehicleColorwheelsHandler(string valueColor, int IntValue)
        {
            foreach (var v in garage)
            {
                if (v.Color == valueColor && v.NumWheels == IntValue)
                {
                    string VehicleName = v.Name;
                    string VehicleRegNo = v.RegNo;

                    uI.FindVehicleColorwheelsHandlerWrite(valueColor, IntValue, VehicleName, VehicleRegNo);

                }

            }
        }

        internal IEnumerable<Vehicle> GetVehicleInfo()
        {
            return garage.ToList();
          //return  garage.Select(v => new VehiclePrint()
          //  {
          //      regNumber = v.RegNo,
          //      color = v.Color
          //  });
        }

        // Search vehicle with RegNum
        public void SearchVehicleHandler( string valueRegNum)
        {
            foreach (var v in garage)
            {
                if (v.RegNo.ToLower() == valueRegNum.ToLower())
                {
                    string VehicleName = v.Name;
                    string VehicleColor = v.Color;
                    int VehicleWheels = v.NumWheels;

                    uI.SearchVehicleHandlerWrite(valueRegNum, VehicleName, VehicleColor, VehicleWheels);
                 
                }
            }
        }

    }
}
