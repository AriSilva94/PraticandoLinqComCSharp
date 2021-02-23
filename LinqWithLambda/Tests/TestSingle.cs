using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    class TestSingle : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var singleQuery = customers.SingleOrDefault(c => c.Age > 10);

            Console.WriteLine($"{singleQuery?.Name} - {singleQuery?.Age}");
        }
    }
}
