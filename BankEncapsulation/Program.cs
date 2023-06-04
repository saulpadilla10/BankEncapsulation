using System;
using System.Collections.Generic;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount();

            double userInput;
            bool deposit;

            do
            {
                Console.WriteLine("Deposit Amout:");

                deposit = double.TryParse(Console.ReadLine(), out userInput);
                account1.Deposit(userInput);


            } while (deposit == false);


            Console.WriteLine("To check balance, enter Y or press Enter to stop");
            string yesno = Console.ReadLine();

            if (yesno.ToUpper() == "Y")
            {
                Console.WriteLine($"Balance: {account1.GetBalance()}");
            }
            else if (yesno == null)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
