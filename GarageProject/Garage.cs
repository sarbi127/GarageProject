using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageProject
{
    [Serializable]
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public int capacity { get; set; }
        private T[] arr;

        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            arr = new T[capacity];

        }
        public int Count => arr.Count(v => v != null);
        public bool IsFull => capacity <= Count;
        public bool IsEmpty => capacity == 0;

        //Add vehicel to the garage with arr
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

        // Remove vehicel to the garage with arr
        public bool Remove(T vehicle) {

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == vehicle)
                {
                    arr[i] = null;
                    break;
                }
            return true;
        }

        //Capacity of the garage
        public int Capacity()
        {
           var numbersList = arr.ToList();
            return numbersList.Capacity;
        }

        // Get index from list
        public T this[int index] => arr[index];

        //The IEnumerator interface provides iterative capability for a collection that is internal to a class. 
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in arr)
            {
                if(item != null)
                yield return item;

            }
        }
        //The IEnumerable interface provides support for the foreach iteration.
        //IEnumerable requires that you implement the GetEnumerator method.
       IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();


    }
}

