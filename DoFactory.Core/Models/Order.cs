using System;

namespace DoFactory.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public double TotalAmount { get; set; }
    }
}