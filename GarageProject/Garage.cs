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
        private T[] list;

        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            //list = new List<T>(capacity);
            list = new T[capacity];

        }

        public int Count => list.Count(v => v != null);
        public bool IsFull => capacity <= Count;
        public bool IsEmpty => capacity == 0;

        //public bool Remove(T item) => list.Remove(item);

        public bool Add(T vehicle)
        {
            if (IsFull) return false;      
            if (!IsFull)
            {
                for (int i = 0; i < list.Length; i++)
                    if (list[i] == null)
                    {
                        list[i] = vehicle;
                        break;
                    }
            }
            
            return true;

        }

        public bool Remove(T vehicle) {

            //var numbersList = list.ToList();
            //numbersList.Remove(vehicle);
            for (int i = 0; i < list.Length; i++)
                if (list[i] == vehicle)
                {
                    list[i] = null;
                    break;
                }
            return true;
        }

        public int Capacity()
        {
          // return  sizeof(list) / sizeof(list[0]) ;
           var numbersList = list.ToList();
            return numbersList.Capacity;
        }

        //public int Capacity => list.Capacity;

        // Get index from list
        public T this[int index] => list[index];

        // add vehicle
        //public bool add(t item)
        //{
        //    if (isfull) list.removeat(0);
        //    list.add(item);
        //    return true;

        //}

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                if(item != null)
                yield return item;

            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        //IEnumerator
        //public bool MoveNext()
        //{
        //    position++;
        //    return (position < vehiclelist.Length);
        //}

        ////IEnumerable
        //public void Reset()
        //{ position = 0; }

        ////IEnumerable
        //public object Current
        //{
        //    get { return vehiclelist[position]; }
        //}

    }
}

