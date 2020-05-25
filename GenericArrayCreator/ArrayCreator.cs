using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GenericArrayCreator
{
    class ArrayCreator
    {

        public static T[] Create<T>(int length,T item)
        {

            var array = new T[length];
            
            for(int i = 0; i < length; i++)
            {
                array[i] = item;
                Console.WriteLine("The item value is " + item);
            }

            return array;
        }
    }
}
