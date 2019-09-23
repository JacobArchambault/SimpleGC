using System;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** GC Basics *****");

            // Create a new Car object on the managed heap. We are returned a reference to this object ("refToMyCar").
            Car refToMyCar = new Car("Zippy", 50);

            // The C# dot operator (.) is used to invoke members on the object using our reference variable.
            Console.WriteLine(refToMyCar.ToString());

            Console.ReadLine();
        }

        static void MakeACar()
        {
            // If myCar is the only reference to the Car object, it *may* be destroyed when this method returns.
            Car myCar = new Car();
        }
    }
}
