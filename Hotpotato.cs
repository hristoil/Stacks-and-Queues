using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hot_potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            var namesSplited = new Queue<string>(names.Split());

            int rotations = int.Parse(Console.ReadLine());

            //Queue<string> queue = new Queue<string>(namesSplited);

            while (namesSplited.Count != 1)
            {
                for (int i = 1; i < rotations; i++)
                {
                    namesSplited.Enqueue(namesSplited.Dequeue());
                }
                Console.WriteLine($"Removed {namesSplited.Dequeue()}");
            }
            Console.WriteLine($"Last is {namesSplited.Dequeue()}");





        }
    }
}
