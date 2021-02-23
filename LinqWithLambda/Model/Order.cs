using System;

namespace LinqWithLambda.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalValue { get; set; }
    }
}
