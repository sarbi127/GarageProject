using System;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
     class UI 
     {
        // push and pop to list(garage)
        public void ParkUnPark(char nav, string input, GarageHandler garageHandler)
        {
            string valuekey = input.Substring(1);
            switch (nav)
            {
                case '0':
                    {
                        return;
                    }
                case '+':
                    {

                        Console.WriteLine("Enter Key number to add vehicle: " +
                            "\n1 Car" +
                            "\n2 Motorcycles" +
                            "\n3 Mopeds" +
                            "\n4 Airplane" +
                            "\n5 Bus" +
                            "\n6 Boat" +
                            "\n7 Bicycle");

                        string valueKey = Console.ReadLine();

                        if (valueKey != "1" && valueKey != "2" && valueKey != "3" && valueKey != "4" && valueKey != "5" && valueKey != "6" && valueKey != "7")
                        {
                            Console.WriteLine("Your enter key is wrong!");
                        }
                        else
                        {
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
                                //var IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.Add(new Cars("car", valueregNo, valueColor, 4, IntValue));
                                Console.WriteLine($"This car  park: {valueregNo}, {valueColor}, {4},{IntValue}");

                            }
                            else if (valueKey == "2")
                            {
                                Console.WriteLine("Enter cylinder volume:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.Add(new Motorcycles("motorcycle", valueregNo, valueColor, 2, IntValue));
                                Console.WriteLine($"This motorcycle park:  {valueregNo}, {valueColor}, {2},{IntValue} ");

                            }
                            else if (valueKey == "3")
                            {
                                Console.WriteLine("Enter fuel type volume:");
                                valueNum = Console.ReadLine();

                                garageHandler.Add(new Mopeds("Mopeds", valueregNo, valueColor, 2, valueNum));
                                Console.WriteLine($"This mopeds park: {valueregNo}, {valueColor}, {2},{valueNum}");

                            }
                            else if (valueKey == "4")
                            {
                                Console.WriteLine("Enter number of seats:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.Add(new Airplane("Airplane", valueregNo, valueColor, 2, IntValue));
                                Console.WriteLine($"This airplane park:  {valueregNo}, {valueColor},{2},{IntValue}");

                            }
                            else if (valueKey == "5")
                            {
                                Console.WriteLine("Enter number of seats:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.Add(new Bus("Bus", valueregNo, valueColor, 4, IntValue));
                                Console.WriteLine($"This bus park:  {valueregNo}, {valueColor},{4},{IntValue}");

                            }
                            else if (valueKey == "6")
                            {
                                Console.WriteLine("Enter length:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.Add(new Boat("Boat", valueregNo, valueColor, 0, IntValue));
                                Console.WriteLine($"This boat park:  {valueregNo}, {valueColor},{0},{IntValue}");

                            }
                            else if (valueKey == "7")
                            {
                                Console.WriteLine("Enter number of seats:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.Add(new Bicycle("Bicycle", valueregNo, valueColor, 2, IntValue));
                                Console.WriteLine($"This bicycle park: {valueregNo}, {valueColor},{2},{IntValue}");

                            }
                        }

                        break;                        
                    }

                case '-':
                    {
                        Console.WriteLine("Enter Key number to remove vehicle:" +
                            "\n1 Car" +
                            "\n2 Motorcycles" +
                            "\n3 Mopeds" +
                            "\n4 Airplane" +
                            "\n5 Bus" +
                            "\n6 Boat" +
                            "\n7 Bicycle");
                        string valueKey = Console.ReadLine();

                        if (valueKey != "1" && valueKey != "2" && valueKey != "3" && valueKey != "4" && valueKey != "5" && valueKey != "6" && valueKey != "7")
                        {
                            Console.WriteLine("Your enter key is wrong!");

                        }
                        else
                        {
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
                                // int IntValue = Int32.Parse(valueNum);

                                // garage.Remove(x => x.RegNo == valueregNo);

                                var IntValue = Validinput(valueNum);

                                garageHandler.RemoveRegNumHandler(valueregNo);
                                Console.WriteLine($"This car unpark: {valueregNo}, {valueColor}, {4}, {IntValue}");

                            }
                            else if (valueKey == "2")
                            {
                                Console.WriteLine("Enter cylinder volume:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.RemoveRegNumHandler(valueregNo);
                                Console.WriteLine($"This motorcycle unpark:  {valueregNo}, {valueColor}, {2}, {IntValue} ");

                            }
                            else if (valueKey == "3")
                            {
                                Console.WriteLine("Enter fuel type volume:");
                                valueNum = Console.ReadLine();

                                garageHandler.RemoveRegNumHandler(valueregNo);
                                Console.WriteLine($"This mopeds unpark: {valueregNo}, {valueColor}, {2},{valueNum}");
                            }
                            else if (valueKey == "4")
                            {
                                Console.WriteLine("Enter number of seats:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.RemoveRegNumHandler(valueregNo);
                                Console.WriteLine($"This airplane unpark:  {valueregNo}, {valueColor},{2}, {IntValue}");

                            }
                            else if (valueKey == "5")
                            {
                                Console.WriteLine("Enter number of seats:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.RemoveRegNumHandler(valueregNo);
                                Console.WriteLine($"This bus unpark:  {valueregNo}, {valueColor},{4}, {IntValue}");

                            }
                            else if (valueKey == "6")
                            {
                                Console.WriteLine("Enter length:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.RemoveRegNumHandler(valueregNo);
                                Console.WriteLine($"This boat unpark:  {valueregNo}, {valueColor},{0}, {IntValue}");

                            }
                            else if (valueKey == "7")
                            {
                                Console.WriteLine("Enter number of seats:");
                                valueNum = Console.ReadLine();
                                //int IntValue = Int32.Parse(valueNum);

                                var IntValue = Validinput(valueNum);

                                garageHandler.RemoveRegNumHandler(valueregNo);
                                Console.WriteLine($"This bicycle unpark: {valueregNo}, {valueColor},{2}, {IntValue}");
                            }
                        }

                        break;
                    }

            }
        }

        //public void WriteAll(Vehicle v)
        //{
        //    Console.WriteLine($"This vehicle park: {v.Name}, {v.RegNo}, {v.Color}");
        //}

        // Write Count number of each vehicle
        public void CountVehicleWrite(Dictionary<string, int> dict)
        {
            Console.WriteLine($"Cars: {dict["car"]}" +
                $"\nMotorcycles: {dict["motorcycle"]}" +
                $"\nMopeds: {dict["mopeds"] }" +
                $"\nAirplanes: {dict["airplan"]}" +
                $"\nBuses: {dict["bus"]}" +
                $"\nBoats: {dict["boat"]}" +
                $"\nBicycles: {dict["bicycle"]}");

        }
        // Write Find Vehicle Color and  wheels
        public void FindVehicleColorwheelsHandlerWrite(string valueColor, int IntValue, string VehicleName, string VehicleRegNo)
        {
            Console.WriteLine($"This vehicle have {valueColor} color and {IntValue} wheels: {VehicleName}, {VehicleRegNo}");
        }

        // Write Search Vehicle base on RegNum
        public void SearchVehicleHandlerWrite(string valueRegNum, string VehicleName, string VehicleColor, int VehicleWheels)
        {
            Console.WriteLine($"This vehicle have {VehicleColor} color and {VehicleWheels} wheels: {VehicleName}, {valueRegNum}");
        }

        // Not found message
        public void NotFound()
        {
            Console.WriteLine($"This vehicle not found!");
        }

        // It shouldn’t crash if you enter a string where the program expects an integer
        public int Validinput(string valueNum)
        {
            int retval;
            bool tf = Int32.TryParse(valueNum, out retval);
            while (!tf)
            {
                Console.WriteLine("Incorrect format!");
                //Console.WriteLine("Reenter string to convert");
                valueNum = Console.ReadLine();
                tf = Int32.TryParse(valueNum, out retval);
            }
            var IntValue = Int32.Parse(valueNum);

            return IntValue;

        }     
       
    }
}
