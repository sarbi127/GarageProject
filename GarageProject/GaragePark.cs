using System;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
    class GaragePark : Garage
    {
        // Park vehicle and add it in the garage
        public void Park(Garage<Vehicle> garage, string input, string valueKey)
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
                int IntValue = Int32.Parse(valueNum);

                garage.Add(new Cars("Car", valueregNo, valueColor, 4, IntValue));
                Console.WriteLine($"This car  park: {valueregNo}, {valueColor}, {4},{valueNum}");

            }

            else if (valueKey == "2")
            {
                Console.WriteLine("Enter cylinder volume:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                garage.Add(new Motorcycles("Motorcycle", valueregNo, valueColor, 2, IntValue));
                Console.WriteLine($"This motorcycle park:  {valueregNo}, {valueColor}, {2},{valueNum} ");

            }
            else if (valueKey == "3")
            {
                Console.WriteLine("Enter fuel type volume:");
                valueNum = Console.ReadLine();
                //int IntValue = Int32.Parse(valueNum);

                garage.Add(new Mopeds("Mopeds", valueregNo, valueColor, 2, valueNum));
                Console.WriteLine($"This mopeds park: {valueregNo}, {valueColor}, {2},{valueNum}");

            }
            else if (valueKey == "4")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                garage.Add(new Airplane("Airplane", valueregNo, valueColor, 2, IntValue));
                Console.WriteLine($"This airplane park:  {valueregNo}, {valueColor},{2},{valueNum}");

            }
            else if (valueKey == "5")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                garage.Add(new Bus("Bus", valueregNo, valueColor, 4, IntValue));
                Console.WriteLine($"This bus park:  {valueregNo}, {valueColor},{4},{valueNum}");

            }
            else if (valueKey == "6")
            {
                Console.WriteLine("Enter length:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                garage.Add(new Boat("Boat", valueregNo, valueColor, 0, IntValue));
                Console.WriteLine($"This boat park:  {valueregNo}, {valueColor},{0},{valueNum}");

            }
            else if (valueKey == "7")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                garage.Add(new Bicycle("Bicycle", valueregNo, valueColor, 2, IntValue));
                Console.WriteLine($"This bicycle park: {valueregNo}, {valueColor},{2},{valueNum}");

            }
        }


        // Unpark vehicle and delete it from garage
        public void UnPark(Garage<Vehicle> garage, string input, string valueKey)
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
                int IntValue = Int32.Parse(valueNum);

                // garage.Remove(x => x.RegNo == valueregNo);

                for (int i = garage.Count - 1; i >= 0; i--)
                {
                    if (garage[i].RegNo.ToLower() == valueregNo.ToLower())
                    {
                        garage.Remove(garage[i]);
                        //mylist.RemoveAt(i);
                    }
                }

                Console.WriteLine($"This car unpark: {valueregNo}, {valueColor}, {4}, {valueNum}");

            }
            else if (valueKey == "2")
            {
                Console.WriteLine("Enter cylinder volume:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                for (int i = garage.Count - 1; i >= 0; i--)
                {
                    if (garage[i].RegNo.ToLower() == valueregNo.ToLower())
                    {
                        garage.Remove(garage[i]);
                        //mylist.RemoveAt(i);
                    }
                }
                Console.WriteLine($"This motorcycle unpark:  {valueregNo}, {valueColor}, {2},{valueNum} ");

            }
            else if (valueKey == "3")
            {
                Console.WriteLine("Enter fuel type volume:");
                valueNum = Console.ReadLine();
                //int IntValue = Int32.Parse(valueNum);
                for (int i = garage.Count - 1; i >= 0; i--)
                {
                    if (garage[i].RegNo.ToLower() == valueregNo.ToLower())
                    {
                        garage.Remove(garage[i]);
                        //mylist.RemoveAt(i);
                    }
                }

                Console.WriteLine($"This mopeds unpark: {valueregNo}, {valueColor}, {2},{valueNum}");
            }
            else if (valueKey == "4")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                for (int i = garage.Count - 1; i >= 0; i--)
                {
                    if (garage[i].RegNo.ToLower() == valueregNo.ToLower())
                    {
                        garage.Remove(garage[i]);
                        //mylist.RemoveAt(i);
                    }
                }

                Console.WriteLine($"This airplane unpark:  {valueregNo}, {valueColor},{2},{valueNum}");

            }
            else if (valueKey == "5")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                for (int i = garage.Count - 1; i >= 0; i--)
                {
                    if (garage[i].RegNo.ToLower() == valueregNo.ToLower())
                    {
                        garage.Remove(garage[i]);
                        //mylist.RemoveAt(i);
                    }
                }

                Console.WriteLine($"This bus unpark:  {valueregNo}, {valueColor},{4},{valueNum}");

            }
            else if (valueKey == "6")
            {
                Console.WriteLine("Enter length:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                for (int i = garage.Count - 1; i >= 0; i--)
                {
                    if (garage[i].RegNo.ToLower() == valueregNo.ToLower())
                    {
                        garage.Remove(garage[i]);
                        //mylist.RemoveAt(i);
                    }
                }

                Console.WriteLine($"This boat unpark:  {valueregNo}, {valueColor},{0},{valueNum}");

            }
            else if (valueKey == "7")
            {
                Console.WriteLine("Enter number of seats:");
                valueNum = Console.ReadLine();
                int IntValue = Int32.Parse(valueNum);

                for (int i = garage.Count - 1; i >= 0; i--)
                {
                    if (garage[i].RegNo.ToLower() == valueregNo.ToLower())
                    {
                        garage.Remove(garage[i]);
                        //mylist.RemoveAt(i);
                    }
                }

                Console.WriteLine($"This bicycle unpark: {valueregNo}, {valueColor},{2},{valueNum}");
            }

        }
    }
}
