using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}

		private double balance;

		public void Deposit(double depositAmount)
		{

			balance += depositAmount;
		}
		
		public double GetBalance()
		{
			return balance;
		}
		
	}
}

