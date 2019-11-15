using System;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
    [Serializable]
    class UI 
     {
        Action<string> printAction = i => Console.WriteLine(i);

        //Push and pop to garage
        public void ParkUnPark(char nav, string input, GarageHandler garageHandler)
        {
            string valuekey = input.Substring(1);
            switch (nav)
            {
                case '0':
                    { return; }
                case '+':
                    {
                        printAction("Enter Key number to add vehicle: " +
                            "\n1 Car" +
                            "\n2 Motorcycles" +
                            "\n3 Mopeds" +
                            "\n4 Airplane" +
                            "\n5 Bus" +
                            "\n6 Boat" +
                            "\n7 Bicycle");
                        string valueKey = Console.ReadLine();
                        if (valueKey != "1" && valueKey != "2" &&
                            valueKey != "3" && valueKey != "4" &&
                            valueKey != "5" && valueKey != "6" &&
                            valueKey != "7")
                        { printAction($"Your enter key is wrong!"); }
                        else
                        { AddPrintPark(garageHandler, valueKey); }
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
                        if (valueKey != "1" && valueKey != "2" &&
                            valueKey != "3" && valueKey != "4" &&
                            valueKey != "5" && valueKey != "6" &&
                            valueKey != "7")
                        { printAction("Your enter key is wrong!"); }
                        else
                        { RemovePrintPark(garageHandler, valueKey); }
                        break;
                    }

            }
        }

        // Remove Vehicle and Print it
        public void RemovePrintPark(GarageHandler garageHandler, string valueKey)
        {
                string valueregNo;
                string valueColor;
                int IntValue;

                printAction("Enter vehicle regNo:");
                valueregNo = Console.ReadLine();

                printAction("Enter vehicle color:");
                valueColor = Console.ReadLine();

                if (valueKey == "1")
                {
                    IntValue = InputVehiclePark(valueKey);
                    garageHandler.RemoveRegNumHandler(valueregNo);
                    printAction($"This car unpark: {valueregNo}, {valueColor}, {4}, {IntValue}");
                }
                else if (valueKey == "2")
                {
                    IntValue = InputVehiclePark(valueKey);
                    garageHandler.RemoveRegNumHandler(valueregNo);
                    printAction($"This motorcycle unpark:  {valueregNo}, {valueColor}, {2}, {IntValue} ");
                }
                else if (valueKey == "3")
                {
                    IntValue = InputVehiclePark(valueKey);
                    garageHandler.RemoveRegNumHandler(valueregNo);
                    printAction($"This mopeds unpark: {valueregNo}, {valueColor}, {2},{IntValue}");
                }
                else if (valueKey == "4")
                {
                    IntValue = InputVehiclePark(valueKey);
                    garageHandler.RemoveRegNumHandler(valueregNo);
                    printAction($"This airplane unpark:  {valueregNo}, {valueColor},{2}, {IntValue}");
                }
                else if (valueKey == "5")
                {
                    IntValue = InputVehiclePark(valueKey);
                    garageHandler.RemoveRegNumHandler(valueregNo);
                    printAction($"This bus unpark:  {valueregNo}, {valueColor},{4}, {IntValue}");

                }
                else if (valueKey == "6")
                {
                    IntValue = InputVehiclePark(valueKey);
                    garageHandler.RemoveRegNumHandler(valueregNo);
                    printAction($"This boat unpark:  {valueregNo}, {valueColor},{0}, {IntValue}");
                }
                else if (valueKey == "7")
                {
                    IntValue = InputVehiclePark(valueKey);
                    garageHandler.RemoveRegNumHandler(valueregNo);
                    printAction($"This bicycle unpark: {valueregNo}, {valueColor},{2}, {IntValue}");
                }
        }
       // Add Vehicle and Print it
        public void AddPrintPark(GarageHandler garageHandler, string valueKey)
            {
            string valueregNo;
            string valueColor;
            int IntValue;

            printAction("Enter vehicle regNo:");
            valueregNo = Console.ReadLine();

            printAction("Enter vehicle color:");
            valueColor = Console.ReadLine();

            if (valueKey == "1")
            {
                IntValue = InputVehiclePark(valueKey);
                garageHandler.Add(new Cars("car", valueregNo, valueColor, 4, IntValue));
                printAction($"This car  park: {valueregNo}, {valueColor}, {4},{IntValue}");
            }
            else if (valueKey == "2")
            {
                IntValue = InputVehiclePark(valueKey);
                garageHandler.Add(new Motorcycles("motorcycle", valueregNo, valueColor, 2, IntValue));
                printAction($"This motorcycle park:  {valueregNo}, {valueColor}, {2},{IntValue} ");
            }
            else if (valueKey == "3")
            {
                IntValue = InputVehiclePark(valueKey);
                garageHandler.Add(new Mopeds("Mopeds", valueregNo, valueColor, 2, IntValue));
                printAction($"This mopeds park: {valueregNo}, {valueColor}, {2},{IntValue}");
            }
            else if (valueKey == "4")
            {
                IntValue = InputVehiclePark(valueKey);
                garageHandler.Add(new Airplane("Airplane", valueregNo, valueColor, 2, IntValue));
                printAction($"This airplane park:  {valueregNo}, {valueColor},{2},{IntValue}");
            }
            else if (valueKey == "5")
            {
                IntValue = InputVehiclePark(valueKey);
                garageHandler.Add(new Bus("Bus", valueregNo, valueColor, 4, IntValue));
                printAction($"This bus park:  {valueregNo}, {valueColor},{4},{IntValue}");
            }
            else if (valueKey == "6")
            {
                IntValue = InputVehiclePark(valueKey);
                garageHandler.Add(new Boat("Boat", valueregNo, valueColor, 0, IntValue));
                printAction($"This boat park:  {valueregNo}, {valueColor},{0},{IntValue}");
             }
            else if (valueKey == "7")
            {
                IntValue = InputVehiclePark(valueKey);
                garageHandler.Add(new Bicycle("Bicycle", valueregNo, valueColor, 2, IntValue));
                printAction($"This bicycle park: {valueregNo}, {valueColor},{2},{IntValue}");
             }     
        }

        // Ask user depened on vehicle
        public int InputVehiclePark(string valueKey)
        {
            string valueNum;
            int IntValue;
            if (valueKey == "1")
            {
                printAction("Enter number of engin:");
            }
            if (valueKey == "2")
            {
                printAction("Enter cylinder volume:");
            }
            if (valueKey == "3")
            {
                printAction("Enter fuel type volume:");
            }
            if (valueKey == "4")
            {
                printAction("Enter number of seats:");
            }
            if (valueKey == "5")
            {
                printAction("Enter number of seats:");
            }
            if (valueKey == "6")
            {
                printAction("Enter length:");
            }
            if (valueKey == "7")
            {
                printAction("Enter number of seats:");
            }
            valueNum = Console.ReadLine();
            IntValue = Validinput(valueNum);
            return IntValue;
    
        }

        // Write Count number of each vehicle
        public void CountVehicleWrite(Dictionary<string, int> dict)
        {
            printAction($"Cars: {dict["car"]}" +
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
            printAction($"This vehicle have {valueColor} color and {IntValue} wheels: {VehicleName}, {VehicleRegNo}");
        }

        // Write Search Vehicle base on RegNum
        public void SearchVehicleHandlerWrite(string valueRegNum, string VehicleName, string VehicleColor, int VehicleWheels)
        {
            printAction($"This vehicle have {valueRegNum} reg number: {VehicleName}, {VehicleColor}, {VehicleWheels}");
        }
        
        // Not found message
        public void NotFound()
        {
            printAction($"This vehicle not found!");
            return;
        }

        // Shouldn’t crash if you enter a string where the program expects an integer
        public int Validinput(string valueNum)
        {
            int retval;
            bool tf = Int32.TryParse(valueNum, out retval);
            while (!tf)
            {
                printAction("Incorrect Input!");
                valueNum = Console.ReadLine();
                tf = Int32.TryParse(valueNum, out retval);
            }
            var IntValue = Int32.Parse(valueNum);
            return IntValue;

        }          
     }
}
