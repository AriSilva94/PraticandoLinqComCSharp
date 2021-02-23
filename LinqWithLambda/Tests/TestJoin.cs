using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    class TestJoin : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();


            //var customerJoin = customers.Join(
            //    orders,
            //    customer => customer.Id,
            //    order => order.CustomerId,
            //    (customer, order) => new { Customer = customer, Order = order });

            //foreach (var item in customerJoin)
            //{
            //    Console.WriteLine($"The customer {item.Customer.Name} purchased {item.Order.TotalValue.ToString("F2")} in {item.Order.CreatedDate.ToString("dd/MM/yyyy")}");
            //}


            var customerGroupJoin = customers.GroupJoin(
                orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, allOrders) => new { Customer = customer, AllOrders = allOrders });

            foreach (var customerOrder in customerGroupJoin)
            {
                Console.WriteLine($"The customer { customerOrder.Customer.Name} purchased: ");
                foreach (var order in customerOrder.AllOrders)
                {
                    Console.WriteLine($"Total value {order.TotalValue.ToString("F2")} in {order.CreatedDate.ToString("dd/MM/yyyy")}");
                }

            }
        }
    }
}
