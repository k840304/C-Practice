using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uva10055
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] numbers;
            int a, b;
            while ((input = Console.ReadLine()) != null)
            {
                numbers = input.Split(' ');
                a = Int32.Parse(numbers[0]);
                b = Int32.Parse(numbers[1]);
                if (a > b)
                {
                    Console.WriteLine(a - b);
                }
                else
                {
                    Console.WriteLine(b - a);
                }
            }
        }
    }
}
