using System;

namespace GenericArrayCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = ArrayCreator.Create(5, "Peter");
            Console.WriteLine(strings.GetValue(1));
            int[] integers= ArrayCreator.Create(10,33);
        }
    }
}
