using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            var carsQueue = new Queue<string>();

            int carsThatPassedTotal = 0;

            while (input != "end")
            {

                if (input == "green")
                {
                    var carsThatCanPass = Math.Min(carsQueue.Count, numberOfCars);
                    for (int i = 0; i < carsThatCanPass; i++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        carsThatPassedTotal++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);                   
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"{carsThatPassedTotal} cars passed the crossroads.");

        }
    }
}
