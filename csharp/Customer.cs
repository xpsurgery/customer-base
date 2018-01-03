using System;

namespace CustomerBase
{
	public class Customer
	{
		
		internal readonly string FirstName;
		internal readonly string LastName;
		internal readonly int Credit;

		public Customer(String firstName, String lastName, int credit)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Credit = credit;
		}

		public override string ToString()
		{
			return string.Format ("(Customer {0} {1})", FirstName, LastName);
		}

	}
}

