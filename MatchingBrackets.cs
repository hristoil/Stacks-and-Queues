using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    stack.Push(i);
                }

                if (str[i] == ')')
                {
                    var startindex = stack.Pop();
                    var lenght = i - startindex + 1;
                    Console.WriteLine(str.Substring(startindex, lenght));

                }
            }
        }
    }
}
