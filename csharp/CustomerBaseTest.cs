using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CustomerBase
{
	[TestFixture()]
	public class CustomerBaseTest
	{

		private Customer alice = new Customer ("Alice", "Rossi", 10000);
		private Customer bob = new Customer ("Bob", "Rossi", 20000);
		private Customer charlie = new Customer ("Charlie", "Bianchi", 30000);
		private CustomerBase customerBase;

		[SetUp]
		public void setUp ()
		{
			customerBase = new CustomerBase ();
			customerBase.Add (alice);
			customerBase.Add (bob);
			customerBase.Add (charlie);
		}

		[Test]
		public void findByLastName ()
		{
			List<Customer> found = customerBase.FindByLastName ("Rossi");
			Assert.AreEqual (new List<Customer> () { alice, bob }, found);
		}

		[Test]
		public void findByFirstAndLastName ()
		{
			List<Customer> found = customerBase.FindByFirstAndLastName ("Alice", "Rossi");
			Assert.AreEqual (new List<Customer> () { alice }, found);
		}

		[Test]
		public void findWithCreditGreaterThan ()
		{
			List<Customer> found = customerBase.FindByCreditGreaterThan (20000);
			Assert.AreEqual (new List<Customer> () { charlie }, found);
		}

		[Test]
		public void findWithCreditLessThan ()
		{
			Assert.Fail ("Open-closed violation!");
			// ...
			// We're sick and tired of adding new methods to CustomerBase.
			// CHALLENGE: can you refactor CustomerBase and its tests
			// so that new kinds of queries can be implemented WITHOUT CHANGING CUSTOMERBASE ???
		}
	}
}
