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
            while(true)
            {
                switch (DisplayMenu())
                {
                    case 'W': WithdrawBalance(); break;

                    case 'D': DepositBalance(); break;

                    case 'Q': ConfirmQuit(); break;
                }
            }
        }
        static string s_accountName = "";
        static string s_accountNumber = "";
        static decimal s_balance = 0;
        static void GetStartingInfo()
        {
            Console.WriteLine("Enter account nickname");
            s_accountName = ReadString(true);
            Console.WriteLine("Enter account number");
            s_accountNumber = ReadNumber();
            Console.WriteLine("Enter starting balance");
            s_balance = ReadBalance(0);
        }
        static char DisplayMenu()
        {
            do
            {
                Console.WriteLine("\nAccount Info");
                Console.WriteLine("============");

                Console.WriteLine("Account Name: " + s_accountName);
                Console.WriteLine("Account Number: " + s_accountNumber);
                Console.WriteLine("Current Balance: " + s_balance.ToString("C"));
                Console.WriteLine("===============================");

                Console.WriteLine("W)ithdraw Money");
                Console.WriteLine("D)eposit Money");
                Console.WriteLine("Q)uit");

                string value = Console.ReadLine();

                if (String.Compare(value, "W", StringComparison.CurrentCultureIgnoreCase) == 0)
                    return 'W';
                else if (String.Compare(value, "D", StringComparison.CurrentCultureIgnoreCase) == 0)
                    return 'D';
                else if (String.Compare(value, "Q", StringComparison.CurrentCultureIgnoreCase) == 0)
                    return 'Q';

                DisplayError("Invalid option");
            } while (true);
        }
        static void ConfirmQuit()
        {
            do
            {
                Console.WriteLine("\nAre you sure you want to quit?");
                Console.WriteLine("============");

                Console.WriteLine("Y)es");
                Console.WriteLine("N)o");

                string value = Console.ReadLine();

                if (String.Compare(value, "Y", StringComparison.CurrentCultureIgnoreCase) == 0)
                    Environment.Exit(0);
                else if (String.Compare(value, "N", StringComparison.CurrentCultureIgnoreCase) == 0)
                    return;

                DisplayError("Invalid Option");
            } while (true);
        }
        static void WithdrawBalance()
        {
            Console.WriteLine("Withdrawing");
        }

        static void DepositBalance()
        {
            Console.WriteLine("Deposit");
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
