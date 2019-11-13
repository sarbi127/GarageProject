using System;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
     class UI 
    {
        // Push and pop to list(garage)
        public void PushPopList(Garage<Vehicle> garage, UI garagePark, char nav, string input)
        {
            string valueKey = input.Substring(1);
           switch (nav)
            {
                case '0':
                    {
                        return;
                    }
                case '+':
                    {
                        garagePark.Park(garage, input);
                        break;
                    }

                case '-':
                    {
                        garagePark.UnPark(garage, input);
                        break;
                    }

            }
        }

        // Park vehicle and add it in the garage and print it
        public void Park(Garage<Vehicle> garage, string input)
        {

            Console.WriteLine("Enter Key number to add vehicle: 1 (Car), 2 (motorcycles), 3 (mopeds), 4 (Airplane), 5 (Bus), 6 (Boat) ,7 (Bicycle)");
            string valueKey = Console.ReadLine();

            string valueNum = input.Substring(1);
            string valueregNo = input.Substring(1);

            string valueColor = input.Substring(1);
            string valuenumWheels = input.Substring(1);

            Console.WriteLine("Enter vehicle regNo:");
            valueregNo = Console.ReadLine();

            Console.WriteLine("Enter vehicle color:");
            valueColor = Console.ReadLine();

            int retval;

            if (valueKey == "1")
            {
                Console.WriteLine("Enter number of engin:");
                valueNum = Console.ReadLine();
                //var IntValue = Int32.Parse(valueNum);

                var IntValue = Validinput(valueNum);
        
                garage.Add(new Cars("Car", valueregNo, valueColor, 4, IntValue));
                Console.WriteLine($"This car  park: {valueregNo}, {valueColor}, {4},{IntValue}");

            }

            else if (valueKey == "2")
            {
                Console.WriteLine("Enter cylinder volume:");
                valueNum = Console.ReadLine();
                //int IntValue = Int32.Parse(valueNum);

                var IntValue = Validinput(valueNum);

                garage.Add(new Motorcycles("Motorcycle", valueregNo, valueColor, 2, IntValue));
                Console.WriteLine($"This motorcycle park:  {valueregNo}, {valueColor}, {2},{IntValue} ");

            }
            else if (valueKey == "3")
            {
                Console.WriteLine("Enter fuel type volume:");
                valueNum = Console.ReadLine();

                garage.Add(new Mopeds("Mopeds", valueregNo, valueColor, 2, valueNum));
                Console.WriteLine($"This mopeds park: {valueregNo}, {valueColor}, {2},{valueNum}");

            }
            else if (valueKey == "4")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                //int IntValue = Int32.Parse(valueNum);

                var IntValue = Validinput(valueNum);

                garage.Add(new Airplane("Airplane", valueregNo, valueColor, 2, IntValue));
                Console.WriteLine($"This airplane park:  {valueregNo}, {valueColor},{2},{IntValue}");

            }
            else if (valueKey == "5")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                //int IntValue = Int32.Parse(valueNum);

                var IntValue = Validinput(valueNum);

                garage.Add(new Bus("Bus", valueregNo, valueColor, 4, IntValue));
                Console.WriteLine($"This bus park:  {valueregNo}, {valueColor},{4},{IntValue}");

            }
            else if (valueKey == "6")
            {
                Console.WriteLine("Enter length:");
                valueNum = Console.ReadLine();
                //int IntValue = Int32.Parse(valueNum);

                var IntValue = Validinput(valueNum);

                garage.Add(new Boat("Boat", valueregNo, valueColor, 0, IntValue));
                Console.WriteLine($"This boat park:  {valueregNo}, {valueColor},{0},{IntValue}");

            }
            else if (valueKey == "7")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                //int IntValue = Int32.Parse(valueNum);

                var IntValue = Validinput(valueNum);

                garage.Add(new Bicycle("Bicycle", valueregNo, valueColor, 2, IntValue));
                Console.WriteLine($"This bicycle park: {valueregNo}, {valueColor},{2},{IntValue}");

            }
        }

        // Unpark vehicle and delete it from garage
        public void UnPark(Garage<Vehicle> garage, string input)
        {

            Console.WriteLine("Enter Key number to remove vehicle: 1 (Car), 2 (motorcycles), 3 (mopeds), 4 (Airplane), 5 (Bus), 6 (Boat) ,7 (Bicycle)");
            string valueKey = Console.ReadLine();

            string valueNum = input.Substring(1);
            string valueregNo = input.Substring(1);
            string valueColor = input.Substring(1);
            string valuenumWheels = input.Substring(1);

            Console.WriteLine("Enter vehicle regNo:");
            valueregNo = Console.ReadLine();

            Console.WriteLine("Enter vehicle color:");
            valueColor = Console.ReadLine();

            if (valueKey == "1")
            {
                Console.WriteLine("Enter number of engin:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                // garage.Remove(x => x.RegNo == valueregNo);

                RemoveRegNum(garage, valueregNo);
                Console.WriteLine($"This car unpark: {valueregNo}, {valueColor}, {4}, {valueNum}");

            }
            else if (valueKey == "2")
            {
                Console.WriteLine("Enter cylinder volume:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                RemoveRegNum(garage, valueregNo);
                Console.WriteLine($"This motorcycle unpark:  {valueregNo}, {valueColor}, {2},{valueNum} ");

            }
            else if (valueKey == "3")
            {
                Console.WriteLine("Enter fuel type volume:");
                valueNum = Console.ReadLine();

                RemoveRegNum(garage, valueregNo);
                Console.WriteLine($"This mopeds unpark: {valueregNo}, {valueColor}, {2},{valueNum}");
            }
            else if (valueKey == "4")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                RemoveRegNum(garage, valueregNo);
                Console.WriteLine($"This airplane unpark:  {valueregNo}, {valueColor},{2},{valueNum}");

            }
            else if (valueKey == "5")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                RemoveRegNum(garage, valueregNo);
                Console.WriteLine($"This bus unpark:  {valueregNo}, {valueColor},{4},{valueNum}");

            }
            else if (valueKey == "6")
            {
                Console.WriteLine("Enter length:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                RemoveRegNum(garage, valueregNo);
                Console.WriteLine($"This boat unpark:  {valueregNo}, {valueColor},{0},{valueNum}");

            }
            else if (valueKey == "7")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                RemoveRegNum( garage, valueregNo);
                Console.WriteLine($"This bicycle unpark: {valueregNo}, {valueColor},{2},{valueNum}");
            }

        }

        // Count number of each vehicle
        public void CountVehicle(Garage<Vehicle> garage)
        {
            var dict = new Dictionary<string, int> {

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

            Console.WriteLine($"CarsCount: {dict["car"]},MotorcycleCount: {dict["motorcycle"]},MopedsCount: {dict["mopeds"] }," +
                $" AirplaneCount: {dict["airplan"]}, BusCount: {dict["bus"]} , BoatCount: {dict["boat"]}, BicycleCount: {dict["bicycle"]} ");

        }

        // Find vehicle with color and wheels
        public void FindVehicleColorwheels(Garage<Vehicle> garage, string valueColor, int IntValue)
        {
            foreach (var v in garage)
            {
                if (v.Color == valueColor && v.NumWheels == IntValue)
                {
                    Console.WriteLine($"This vehicle have {valueColor} color and {IntValue} wheels: {v.Name}, {v.RegNo}");

                }

            }
        }

        // Search vehicle with RegNum
        public void SearchVehicle(Garage<Vehicle> garage, string valueRegNum)
        {
            foreach (var v in garage)
            {
                if (v.RegNo.ToLower() == valueRegNum.ToLower())
                {
                    Console.WriteLine($"This vehicle have a reg Number {valueRegNum} : {v.Name}, {v.Color}, {v.NumWheels}");

                }
            }
        }
        // Remove vehicle with regNo
        public void RemoveRegNum(Garage<Vehicle> garage, string valueregNo)
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

        public int Validinput(string valueNum)
        {
            int retval;
            bool tf = Int32.TryParse(valueNum, out retval);
            while (!tf)
            {
                Console.WriteLine("Incorrect string format. Conversion failed.");
                Console.WriteLine("Reenter string to convert");
                valueNum = Console.ReadLine();
                tf = Int32.TryParse(valueNum, out retval);
            }
            var IntValue = Int32.Parse(valueNum);

            return IntValue;

        }

        // Write garage 
        public void WriteAll(Garage<Vehicle> garage)
        {
            foreach (var v in garage)
            {
                Console.WriteLine($"This vehicle park: {v.Name}, {v.RegNo}, {v.Color}");
            }
          
        }
    }
}
