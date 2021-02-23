using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    class TestTake : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var takeQuery = customers.Take(10);

            foreach (var item in takeQuery)
            {
                Console.WriteLine(item.Name);
            }

            var takeWhileQuery = customers.TakeWhile(c => c.Age != 40);

            foreach (var item in takeWhileQuery)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
