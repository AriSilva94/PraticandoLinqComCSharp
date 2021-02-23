using LinqWithLambda.Tests;
using System;

namespace LinqWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestGroupBy();

            test.Test();

            Console.ReadLine();
        }
    }
}
