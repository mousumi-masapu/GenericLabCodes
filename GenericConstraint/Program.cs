using System;

namespace GenericConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            var scale = new Scale<int>(10, 10);

            Console.WriteLine("The heavier one is " + scale.GetHeavier());

            var weight = new Scale<string>( "Ant", "Elephant");

            Console.WriteLine("The heavier one is " + weight.GetHeavier());
        }
    }
}
