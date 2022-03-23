using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_integer_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare varible type, varible and it value

            int a = 30;
            int b = 20;
            int c = 5;

            //using math symbols for addition(+), Subtraction(-), multiplication(*), Division(/).

            Console.WriteLine(a + b); // 30 + 20 = 50

            Console.WriteLine(a - b); // 30 - 20 = 10

            Console.WriteLine(a * b); // 30 * 20 = 600

            Console.WriteLine(a / b); // 30 / 20 = 1 (becoz of we declare varible type is int)

            int d = a + b * c;  // first taking multiplication before addition
            Console.WriteLine(d); // result will be 130

            int e = (a + b) * c; // this time first taking addition 
            Console.WriteLine(e); // result will be 250

            int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;

            Console.WriteLine(f); //first taking operation in inside the () after / , * , + , - 

            Console.WriteLine(a % b); //gives the reminder value "10"

        }
    }
}
