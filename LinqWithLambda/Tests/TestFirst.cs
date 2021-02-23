using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    class TestFirst : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var firstQuery = customers.FirstOrDefault(c => c.Age > 10);

            Console.WriteLine($"{firstQuery?.Name} - {firstQuery?.Age}");
        }
    }
}
