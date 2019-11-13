using System;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
  public  class Vehicle : IGarageHandler
    {
        public string RegNo { get; set; }
        public string Color { get; set; }
        public int NumWheels { get; set; }
        public string Name { get; set; }
        public Vehicle(string name,string regNo, string color, int numWheels) // constructor
        {
            Name = name;
            RegNo = regNo;
            Color = color;
            NumWheels = numWheels;
        }
       
    }

    public class Cars : Vehicle
    {
        public int NumEng { get; set; }
        public int  Key = 1;

        public Cars(string name, string regNo, string color, int numWheels, int numEng) : // constructor
            base(name, regNo, color, numWheels)
        {
            NumEng = numEng;

        }

    }

    public class Motorcycles : Vehicle
    {
        public int CylVol { get; set; }
        public Motorcycles(string name, string regNo, string color, int numWheels, int cylVol) : // constructor
            base(name, regNo, color, numWheels)
        {
            CylVol = cylVol;
        }

    }

    public class Mopeds : Vehicle
    {
        public string FuelType { get; set; }
        public Mopeds(string name, string regNo, string color, int numWheels, string fuelType) : // constructor
            base(name, regNo, color, numWheels)
        {
            FuelType = fuelType;

        }

    }

    public class Airplane : Vehicle
    {
        public int NumSeats { get; set; }
        public Airplane(string name,string regNo, string color, int numWheels, int numSeats) : // constructor
            base(name, regNo, color, numWheels)
        {
            NumSeats = numSeats;

        }
        
    }

    public class Bus : Vehicle
    {
        public int NumSeats { get; set; }
        public Bus(string name, string regNo, string color, int numWheels, int numSeats) : // constructor
            base(name, regNo, color, numWheels) 
        {
            NumSeats = numSeats;

        }
    }

    public class Boat : Vehicle
    {
        public int Lenght { get; set; }

        public Boat(string name, string regNo, string color, int numWheels, int lenght) : // constructor
            base(name, regNo, color, numWheels)
        {
            Lenght = lenght;
        }

    }

    public class Bicycle : Vehicle
    {
        public int NumSeats { get; set; }
        public Bicycle(string name, string regNo, string color, int numWheels, int numSeats) : // constructor
            base(name, regNo, color, numWheels) 
        {
            NumSeats = numSeats;
        }
    }


}
