﻿using System;
using System.Collections.Generic;


using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UI garagePark = new UI();

            var garage = new Garage<Vehicle>(10);
            garage.Add(new Cars("Car", "112AB", "red", 4, 12));
            garage.Add(new Cars("Car", "112B", "red", 4, 12));
            garage.Add(new Motorcycles("motorcycles", "112a", "green", 2, 13));
            garage.Add(new Motorcycles("motorcycles", "112b", "green", 2, 13));
            garage.Add(new Mopeds("mopeds", "122BB", "blue", 2, "14"));
            garage.Add(new Airplane("Airplane", "132AA", "red", 2, 15));
            garage.Add(new Airplane("Airplane", "132SS", "white", 2, 15));
            garage.Add(new Bus("Bus", "132AA", "white", 2, 1));
            garage.Add(new Boat("Boat", "13", "white", 0, 0));

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"

                     + "\n1. List all parked vehicles"
                     + "\n2. List all vehicle types currently parked in the garage and how many of each kind"
                     + "\n3. Park and unpark specific vehicles from the garage"
                     + "\n4. Show maximum capacity of the Garage "
                     + "\n5. Find a vehicles based on color and wheels"
                     + "\n6. Search on a vehicle based on Reg Number"
                     + "\n7. Save and load from File"
                     + "\n0. Exit the application");

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line

                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':

                        garagePark.WriteAll(garage);
                        break;

                    case '2':

                        garagePark.CountVehicle(garage);
                        break;

                    case '3':

                        Console.WriteLine("Type '+' or '-'  to add or remove from the list or zero to exit :");

                        string input1 = Console.ReadLine();
                        char nav = input1[0];        

                        garagePark.PushPopList(garage, garagePark, nav, input1);
                        break;

                    case '4':
                        
                        Console.WriteLine("\nMax Garage Capacity: {0}", garage.capacity);
                        break;

                    case '5':

                        Console.WriteLine("Enter vehicle color:");
                        string valueColor = Console.ReadLine();

                        Console.WriteLine("Enter vehicle numWheels:");
                        string valuenumWheels = Console.ReadLine();
                        int IntValue = Int32.Parse(valuenumWheels);

                        garagePark.FindVehicleColorwheels(garage, valueColor, IntValue);
                        break;

                    case '6':

                        Console.WriteLine("Enter vehicle Reg number:");
                        string valueRegNum = Console.ReadLine();

                        garagePark.SearchVehicle(garage, valueRegNum);
                        break;

                    case '7':

                      
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream(@"C:\Users\Elev\Desktop\ExampleNew.txt", FileMode.Create, FileAccess.Write);

                        formatter.Serialize(stream, garage);
                        stream.Close();

                        stream = new FileStream(@"C:\Users\Elev\Desktop\ExampleNew.txt", FileMode.Open, FileAccess.Read);
                        Garage objnew = (Garage)formatter.Deserialize(stream);

                        Console.WriteLine(objnew);
                        //Console.WriteLine(objnew.Name);

                        Console.ReadKey();

                        break;

                    case '0':
                        return;

                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6)");
                        break;

                }

            }

        }
      
     }

 }

   

