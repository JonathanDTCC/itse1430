/*
 * Jonathan Daniel
 * ITSE 1430
 * Lab 1
 */
using System;

namespace Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStartingInfo();
        }
        static string s_accountName = "";
        static string s_accountNumber = "";
        static decimal s_startingBalance = 0;
        static void GetStartingInfo()
        {
            Console.WriteLine("Enter account nickname");
            s_accountName = ReadString(true);
            Console.WriteLine("Enter account number");
            s_accountNumber = ReadNumber();
            Console.WriteLine("Enter starting balance");
            s_startingBalance = ReadBalance(0);
        }
        static string ReadString(bool required)
        {
            do
            {
                string value = Console.ReadLine();

                if (!required || !String.IsNullOrEmpty(value))
                    return value;
                DisplayError("Value is required");
            } while (true);
        }
        static string ReadNumber()
        {
            do
            {
                string value = Console.ReadLine();

                if (!String.IsNullOrEmpty(value) && IsOnlyDigits(value))
                    return value;

                DisplayError("Account number should only be a string of unique numbers");
            } while (true);
        }
        static bool IsOnlyDigits(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        static decimal ReadBalance(decimal minValue)
        {
            do
            {
                string value = Console.ReadLine();

                if (Decimal.TryParse(value, out var result) && result > minValue)
                    return result;
                else if (!Decimal.TryParse(value, out result))
                    DisplayError("Value must be integral value");
                else
                    DisplayError("Value must be at least $" + minValue);
            } while (true);
        }
        static void DisplayError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
