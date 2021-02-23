using System;
using System.Linq;

namespace LinqWithLambda.Tests
{
    class TestGroupBy : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            var totalOrders = orders.GroupBy(o => o.CustomerId)
                .Select(o => new
                {
                    CustomerId = o.Key,
                    TotalValue = o.Sum(t => t.TotalValue),
                    AverageValue = o.Average(t => t.TotalValue),
                    CountOrders = o.Count()
                });


            foreach (var item in totalOrders)
            {
                Console.WriteLine($"Customer {item.CustomerId} - Total Value: {item.TotalValue.ToString("c2")} - Average Value: {item.AverageValue.ToString("c2")} - Count Orders: {item.CountOrders}");
            }

        }
    }
}
