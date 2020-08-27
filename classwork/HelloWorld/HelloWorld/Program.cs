/*
 * Jonathan Daniel
 * ITSE 1430
 * Hello World
 */
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //A single line comment
            //Another line of comments
            Console.WriteLine("Hello World!");

            int hours = 40;
            double payRate = 12.80;

            double totalPay = hours * payRate;

            //Another block
            //10 + 45;
            //Don't do that --> { Console.WriteLine(); }
        }
    }
}
