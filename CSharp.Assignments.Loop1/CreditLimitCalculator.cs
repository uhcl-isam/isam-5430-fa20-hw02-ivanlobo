using System;
using System.Dynamic;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {
            // read in account number
            // Enter your sentinel loop here
            Console.WriteLine("Please enter your account number:");
            int accNum = Convert.ToInt32(Console.ReadLine());
            while (accNum > 0)
            {
                Console.WriteLine("Please enter your balance at the start of the month:");
                int begBal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your total charges:");
                int charge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your total credits:");
                int credit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your credit limit:");
                int limit = Convert.ToInt32(Console.ReadLine());
                int i = (begBal + charge) - credit;
                if (i > limit)
                {
                    Console.WriteLine($"Your credit balance is {i}");
                    Console.WriteLine("Credit limit exceeded");
                }
                else if (i < limit)
                {
                    Console.WriteLine($"Your credit balance is {i}");
                    Console.WriteLine("You are within your credit limit");
                }
                Console.WriteLine("Please enter your account number:");
                accNum = Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}
