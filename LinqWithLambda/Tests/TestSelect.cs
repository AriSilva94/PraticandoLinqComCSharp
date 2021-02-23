using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    class TestSelect : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var secondQuery = customers.Select(c => new { c.Name, c.Age });

            foreach (var item in secondQuery)
            {
                Console.WriteLine($"{item.Name}, {item.Age}");
            }
        }
    }
}
