using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;

            switch (a)
            {
                case 1:
                    Console.WriteLine("Value of x is 15");
                    break;
                case 2:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 3:
                    Console.WriteLine("Value of x is 50");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }
        }
    }
}
