using System;
using System.Collections.Generic;

namespace CustomerBase
{
	public class CustomerBase
	{
		private List<Customer> customers = new List<Customer>();

		public void Add(Customer customer)
		{
			customers.Add(customer);
		}

		public List<Customer> FindByLastName(string lastName)
		{
			List<Customer> result = new List<Customer>();
			foreach (Customer customer in customers)
				if (customer.LastName == lastName)
					result.Add(customer);
			return result;
		}

		public List<Customer> FindByFirstAndLastName(string firstName, string lastName)
		{
			List<Customer> result = new List<Customer>();
			foreach (Customer customer in customers)
				if (customer.FirstName == firstName && customer.LastName == lastName )
					result.Add(customer);
			return result;
		}

		public List<Customer> FindByCreditGreaterThan(int credit)
		{
			List<Customer> result = new List<Customer>();
			foreach (Customer customer in customers)
				if (customer.Credit > credit)
					result.Add(customer);
			return result;
		}
	}
}
