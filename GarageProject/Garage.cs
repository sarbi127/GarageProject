using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageProject
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public int capacity { get; set; }
        //private readonly List<T> list;
        private T[] arr;

        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            //list = new List<T>(capacity);
            arr = new T[capacity];

        }
        public int Count => arr.Count(v => v != null);
        public bool IsFull => capacity <= Count;
        public bool IsEmpty => capacity == 0;

        //public bool Remove(T item) => list.Remove(item);

        public bool Add(T vehicle)
        {
            if (IsFull) return false;      
            if (!IsFull)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] == null)
                    {
                        arr[i] = vehicle;
                        break;
                    }
            }
           
            return true;
        }

        public bool Remove(T vehicle) {

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == vehicle)
                {
                    arr[i] = null;
                    break;
                }
            return true;
        }

        public int Capacity()
        {
          // return  sizeof(list) / sizeof(list[0]) ;
           var numbersList = arr.ToList();
            return numbersList.Capacity;
        }

        //public int Capacity => list.Capacity;

        // Get index from list
        public T this[int index] => arr[index];

        // add vehicle
        //public bool add(t item)
        //{
        //    if (isfull) list.removeat(0);
        //    list.add(item);
        //    return true;

        //}

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in arr)
            {
                if(item != null)
                yield return item;

            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();


    }
}

