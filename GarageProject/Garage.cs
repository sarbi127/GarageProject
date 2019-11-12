using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public int capacity { get; set; }
        private readonly List<T> list;

        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            list = new List<T>(capacity);

        }

        public int Count => list.Count;
        public bool IsFull => capacity <= Count;
        public bool IsEmpty => capacity == 0;


        // Add Vehicle
        public bool Add(T item)
        {
            if (IsFull) list.RemoveAt(0);
            list.Add(item);
            return true;

        }
        // Remove Vehicle
        public bool Remove(T item) => list.Remove(item);

        // Get index from list
        public T this[int index] => list[index];

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;

            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        // Count number of each vehicle
        public void CountVehicle(Garage<Vehicle> garage)
        {
            int CarsCount = 0;
            int MotorcycleCount = 0;
            int MopedsCount = 0;
            int AirplaneCount = 0;
            int BusCount = 0;
            int BoatCount = 0;
            int BicycleCount = 0;

            foreach (var v in garage)
            {
                if (v is Cars) CarsCount += 1;
                else if (v is Motorcycles) MotorcycleCount += 1;
                else if (v is Mopeds) MopedsCount += 1;
                else if (v is Airplane) AirplaneCount += 1;
                else if (v is Bus) BusCount += 1;
                else if (v is Boat) BoatCount += 1;
                else if (v is Bicycle) BicycleCount += 1;
            }

            Console.WriteLine($"CarsCount: {CarsCount},MotorcycleCount: {MotorcycleCount},MopedsCount: {MopedsCount}," +
                $" AirplaneCount: {AirplaneCount}, BusCount: {BusCount} , BoatCount: {BoatCount}, BicycleCount: {BicycleCount} ");

        }

        // Find vehicle with color and wheels
        public void FindVehicleColorwheels(Garage<Vehicle> garage)
        {

            Console.WriteLine("Enter vehicle color:");
            string valueColor = Console.ReadLine();

            Console.WriteLine("Enter vehicle numWheels:");
            string valuenumWheels = Console.ReadLine();
            int IntValue = Int32.Parse(valuenumWheels);

            foreach (var v in garage)
            {
                if (v.Color == valueColor && v.NumWheels == IntValue)
                {
                    Console.WriteLine($"This vehicle have {valueColor} color and {IntValue} wheels: {v.Name}, {v.RegNo}");

                }

            }
        }

        // Search vehicle with RegNum
        public void SearchVehicle(Garage<Vehicle> garage)
        {
            Console.WriteLine("Enter vehicle Reg number:");
            string valueRegNum = Console.ReadLine();

            foreach (var v in garage)
            {
                if (v.RegNo.ToLower() == valueRegNum.ToLower())
                {
                    Console.WriteLine($"This vehicle have a reg Number {valueRegNum} : {v.Name}, {v.Color}, {v.NumWheels}");

                }
            }
        }

        // Push and pop to list(garage)
        public void PushPopList(Garage<Vehicle> garage)
        {

            //var garage = new Garage<Vehicle>(10);
            Console.WriteLine("Type '+' or '-'  to add or remove from the list or zero to exit :");

            string input = Console.ReadLine();
            char nav = input[0];

            string valueKey = input.Substring(1);

            GaragePark garagePark = new GaragePark();

            switch (nav)
            {
                case '0':
                    {
                        return;

                    }
                case '+':
                    {
                        Console.WriteLine("Enter Key number to add vehicle: 1 (Car), 2 (motorcycles), 3 (mopeds), 4 (Airplane), 5 (Bus), 6 (Boat) ,7 (Bicycle)");
                        valueKey = Console.ReadLine();

                        garagePark.Park(garage, input, valueKey);
                        break;

                    }

                case '-':
                    {
                        Console.WriteLine("Enter Key number to remove vehicle: 1 (Car), 2 (motorcycles), 3 (mopeds), 4 (Airplane), 5 (Bus), 6 (Boat) ,7 (Bicycle)");
                        valueKey = Console.ReadLine();

                        garagePark.UnPark(garage, input, valueKey);
                        break;

                    }

            }
        }

            // Write garage 
            public void WriteAll(Garage<Vehicle> garage)
        {
            foreach (var v in garage)
            {
                Console.WriteLine($"This vehicle park: {v.Name}, {v.RegNo}, {v.Color}");
            }

        }

        //internal void Remove(Func<object, bool> p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

