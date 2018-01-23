using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stakes_and_queus
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var elements = input.Split(' ');

            var stack = new Stack<string>(elements.Reverse());

            

            while (stack.Count>1)
            {
                var el1 = int.Parse(stack.Pop());
                var op = stack.Pop();
                var el2 = int.Parse(stack.Pop());

                switch (op)
                {
                    case "+":
                        stack.Push((el1 + el2).ToString());
                        break;
                    case "-":
                        stack.Push((el1 - el2).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
            



        }
    }
}
