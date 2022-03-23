using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_if_and_else_together
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 30;
            int c = 40;

            if ((a + b + c > 100) && (a == b)) // the &&  means both conditions must be true to execute the statement
            {
                Console.WriteLine("The answer is grater than 100");
                Console.WriteLine("And the first number is  equal to the second number."); 
            }

            else
            {
                Console.WriteLine("The answer is not grater than the 100");
                Console.WriteLine("or the first number is not equal to the second number.");
            }
            
        }
    }
}
