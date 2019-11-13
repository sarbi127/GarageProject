using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GarageProject
{
 public class Garage<T> : IEnumerable<T> where T : Vehicle
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

    }
}

