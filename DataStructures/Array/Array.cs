using System.Collections;

namespace DataStructures.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;
        public int Count { get ; private set; }
        public int Capacity => InnerList.Length;

        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }

        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
            {
                Add(item);
            }
        }

        public Array(IEnumerable<T> collection)
        {
            InnerList = new T[collection.ToArray().Length];
            Count = 0;
            foreach(var item in collection)
                Add(item);
        }

        public void Add(T item)
        {
            if(InnerList.Length == Count)
            {
                DoubleArray();
            }
            InnerList[Count] = item;
            Count++;
        }

        public T Remove()
        {
            if (Count == 0)
                throw new Exception("Array is null");
            
            if (InnerList.Length / 4 == Count)
            {
                HalfArray();
            }

            var temp =  InnerList[Count-1];
            if (Count > 0)
            {
                Count--;
            }
            return temp;
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];

            for(int i = 0; i < InnerList.Length; i++)
            {
                temp[i] = InnerList[i];
            }

            //System.Array.Copy(InnerList,temp,InnerList.Length);

            InnerList = temp;
        }

        private void HalfArray()
        {
            if (InnerList.Length > 2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList,temp, InnerList.Length / 4);
                InnerList = temp;
            }
        }

        public object Clone()
        {
            /*What is Shallow Copy ?
            A shallow copy is a copy of an object where only the top - level object is duplicated,
            while any references to other objects inside it still point to the same memory location.
            Essentially, a shallow copy creates a new object but reuses references to the objects inside.*/

            //return this.MemberwiseClone(); //Shallow Copy



            /*What is Deep Copy?
            A deep copy, on the other hand, duplicates not only the top-level object but also all the nested objects.
            It creates an entirely independent copy, meaning changes to the inner objects in the copy won’t affect
            the original object (and vice versa).*/

            var arr = new Array<T>(); //Deep Copy
            foreach (var item in this)
                arr.Add(item);
            return arr;

            /*NOTE: Since the type here is not System.Array but our own array type,
             the copies do not affect each other in both shallow and deep copying due to the addition method. */
        }
        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
