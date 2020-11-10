using Records.ExampleRecords;
using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            var license1 = new DriverLicense()
            {
                Number = "01",
                Categories = "A,B,C"
            };
            var license2 = new DriverLicense()
            {
                Number = "02",
                Categories = "A,B,C"
            };
            license1.Number = "02";
            Console.WriteLine($"license1 == license2: {license1 == license2} \n");
            Console.ReadKey();
            




            var license3 = license1;
            license1.Number = "01";
            Console.WriteLine($"license1 == license3: {license1 == license3} \n");
            Console.ReadKey();





            Console.WriteLine("Moral of history:");
            Console.WriteLine("Records behave like Structs for comparisons, but be careful!");
            Console.WriteLine("Records are reference type.");

            Console.ReadKey();
        }

    }
}
