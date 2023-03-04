using System;
using System.Collections.Generic;

namespace SDC1KnowledgeCheck2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<ElectricGuitar>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myGuitar = new ElectricGuitar();

                Console.WriteLine("Enter the value for your guitar brand");
                myGuitar.Brand = Console.ReadLine();
                Console.WriteLine("Enter the value for the type of pickup on your guitar");
                myGuitar.PickupType = Console.ReadLine();


                recordList.Add(myGuitar);
            }

            // Print out the list of records using Console.WriteLine()

            foreach (var record in recordList)
            {
                // Example......Gibson has 6 strings and humbucker pickups
                // .............Fender has 6 strings and single coil pickups
                Console.WriteLine($"{record.Brand} has {record.Strings} strings and {record.PickupType} pickups");
            }
        }
    }
}
