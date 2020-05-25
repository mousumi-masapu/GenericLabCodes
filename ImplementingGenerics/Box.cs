using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingGenerics
{
    class Box<T>
    {
        private List<T> items;

        public Box()
        {
            this.items = new List<T>();

        }
        public int count
        {
            get
            {

                return this.items.Count;

            }
        }

        public void Add(T item)
        {

            this.items.Add(item);
            Console.WriteLine("Inside Add  " +item);

        }

        public T Remove()
        {
            Console.WriteLine("Item count  " + items.Count);
            var item = this.items[items.Count - 1];
            Console.WriteLine("Item value inside Remove()  " + item);
            this.items.RemoveAt(items.Count - 1);
            
            return item;
        }
    }
}
