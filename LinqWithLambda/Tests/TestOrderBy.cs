using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    class TestOrderBy : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            var customerOrders = customers.GroupJoin(
                orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, order) => new
                {
                    CustomerId = customer.Id,
                    Name = customer.Name,
                    Age = customer.Age,
                    AllOrder = order
                });

            foreach (var item in customerOrders.OrderBy(c => c.Name))
            {
                Console.WriteLine($"{item.Name} Purchased: ");

                foreach (var order in item.AllOrder.OrderBy(c => c.TotalValue))
                {
                    Console.WriteLine($"Value {order.TotalValue.ToString("c2")} in {order.CreatedDate.ToString("dd/MM/yyyy")}");
                }

                Console.WriteLine($"Total value {item.AllOrder.Sum(c => c.TotalValue).ToString("c2")}");
                Console.WriteLine($"Average value {item.AllOrder.Average(c => c.TotalValue).ToString("c2")}");                
            }
        }
    }
}
