using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace GarageProject
{
    [Serializable]
    public class GarageHandler
    {
        Garage<Vehicle> garage;
        UI uI = new UI();


        //constructor
        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }

        // Vehicles Count
        public void CountVehicleHandler()
        {
            //var res = garage.GroupBy(v => v.GetType().Name).Select(v => new
            //{
            //    Name = v.Key,
            //    Total = v.Count()
            //});

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

        // Add to Arry
        public bool Add(Vehicle vehicle)
        {
          return  garage.Add(vehicle);
        }

        // Remove from Arry
        public bool Remove(Vehicle vehicle)
        {
            return garage.Remove(vehicle);
        }

        // Remove vehicle base on regNo
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

            Console.WriteLine("\nMax Garage Capacity: {0}", garage.capacity );
            //return capNew;

        }

        // Find vehicle base on color and wheels
        public void FindVehicleColorwheelsHandler(string valueColor, int IntValue)
        {
            bool InGarage = false;
            foreach (var v in garage)
            {
                if (v.Color == valueColor && v.NumWheels == IntValue)
                {
                    string VehicleName = v.Name;
                    string VehicleRegNo = v.RegNo;

                    uI.FindVehicleColorwheelsHandlerWrite(valueColor, IntValue, VehicleName, VehicleRegNo);
                    InGarage = true;

                }             
            }
            if (InGarage == false)
            {
                uI.NotFound();
            }
        }

        // Get Vehicle Information
        public IEnumerable<Vehicle> GetVehicleInfo()
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
            bool InGarage = false;
            foreach (var v in garage)
            {
                if (v.RegNo.ToLower() == valueRegNum.ToLower())
                {
                    string VehicleName = v.Name;
                    string VehicleColor = v.Color;
                    int VehicleWheels = v.NumWheels;

                    uI.SearchVehicleHandlerWrite(valueRegNum, VehicleName, VehicleColor, VehicleWheels);
                    InGarage = true;
                }             
            }
            if (InGarage == false)
            {
                uI.NotFound();
            }            
        }

    }
}
