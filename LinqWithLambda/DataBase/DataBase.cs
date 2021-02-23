using System;
using LinqWithLambda.Model;
using System.Collections.Generic;

namespace LinqWithLambda.DataBase
{
	public static class DataBase
	{
		public static List<Customer> GetCustomers()
		{
			var customers = new List<Customer>();

			for (int i = 0; i <= 50; i++)
			{
				var customer = new Customer();
				customer.Id = i;
				customer.Name = $"Customer {i}";
				customer.Age = 19 + i;

				customers.Add(customer);
			}

			return customers;
		}

		public static List<Order> GetOrders()
		{
			var orders = new List<Order>();

			var customerId = 0;

			for (int i = 0; i < 1000; i++)
			{
				var order = new Order();
				order.Id = i;
				if (customerId > 50) customerId = 0;
				order.CustomerId = customerId;
				order.CreatedDate = DateTime.Now;
				order.TotalValue = 10 * i;

				orders.Add(order);

				customerId++;
			}

			return orders;
		}
	}
}
