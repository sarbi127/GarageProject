using System;
using System.Collections.Generic;

namespace GarageProject
{
    class Program
    {
        static void Main(string[] args)
        {

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

                        garage.WriteAll(garage);
                        break;

                    case '2':

                        garage.CountVehicle(garage);
                        break;

                    case '3':

                        garage.PushPopList(garage);
                        break;

                    case '4':
                        
                        Console.WriteLine("\nMax Garage Capacity: {0}", garage.capacity);
                        break;

                    case '5':
                         
                        garage.FindVehicleColorwheels(garage);
                        break;

                    case '6':

                        garage.SearchVehicle(garage);
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */

                    case '0':
                        return;

                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;

                }

            }

        }
      
     }

 }

   

