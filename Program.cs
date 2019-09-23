using System;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.GC *****");

            // Print out estimated number of bytes on heap.
            Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));

            // MaxGeneration is zero based, so add 1 for display purposes.
            Console.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));
            // Create a new Car object on the managed heap. We are returned a reference to this object ("refToMyCar").
            Car refToMyCar = new Car("Zippy", 50);
            // The C# dot operator (.) is used to invoke members on the object using our reference variable.
            Console.WriteLine(refToMyCar.ToString());

            // Print out generation of refToMyCar object.
            Console.WriteLine("\nGeneration of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

            // Force a garbage collection and wait for each object to be finalized.
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.ReadLine();
            
        }
    }
}
