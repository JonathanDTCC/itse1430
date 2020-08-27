/*
 * Jonathan Daniel
 * ITSE 1430
 * Hello World
 */
using System;

namespace HelloWorld
{
    //Pascal casing - Capitalize on word boundaries including first word
    //Camel casing - Capitalize on word boundaries except first (e.g. firstName, payRate)
    class Program
    {
        //Function declaration - declaration to compiler that a function exists with a given signature
        //Function signature - Function name and the parameter types (sometimes it will include return type)
        //Function definition - declaration + implementation
        static void Main(string[] args) // 1 parameter
        {
            //A single line comment
            //Another line of comments

            //Display given string to output
            //Arguments - data passed to the function
            Console.WriteLine("Hello World!"); //printf, cout

            //Variable declaration;
            //T id;
            //int hours;
            //hours = 10; //Assignment operator: id = E

            //Identifer Rules
            // 1. Unique within scope
            // 2. Must start with underscore or letter
            // 3. Consist of letters, digits, and underscores
            // e.g.
            //  Valid? firstName, first_Name, first_name
            //  pay1Rate - Yes
            //  1chance - No

            //Always camel case local variables, noun
            //Preferred: T id = E;
            int hours = 10;

            //int pay = 0;
            //pay = hours * 9;
            int totalPay = hours * 9;

            //Function overloading - multiple functions with same name but different parameters
            // atof, atoi
            Console.WriteLine(totalPay);
        }
    }
}
