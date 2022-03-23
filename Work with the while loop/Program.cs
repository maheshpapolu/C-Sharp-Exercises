using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_the_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; //  varible initialization

            while (i <= 10) // condition for while loop
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment
            }
        }
    }
}
