using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Decimal_to_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stake = new Stack<int>();

            int num;

            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (n != 0)
            {
                num = n % 2;
                stake.Push(num);
                n = n/2;
            }

            Console.Write(string.Join("", stake));
            Console.WriteLine();
        }
    }
}
