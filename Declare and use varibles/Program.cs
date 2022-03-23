using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declare_and_use_varibles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declares a Varible , and assigns it a value
            
            string aFriend = "John";        

            // Prints out the value or Name

            Console.WriteLine(aFriend);      // Jhon

            //Adding "Hello" message to aFriend using + 

            Console.WriteLine("Hello " + aFriend); // Hello Jhon

            // Using $ symbol to pass a message

            Console.WriteLine( $"Hello {aFriend}");

            // find the length of a string using "Length"

            Console.WriteLine($"The name {aFriend} has {aFriend.Length} Letters");
        }
    }
}
