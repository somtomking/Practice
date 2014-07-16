using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Mvc5.Models
{
    public class FormModel
    {
        public class Order
        {
            public Order()
            {
                Items = new List<OrderItem>();
            }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Count { get; set; }
            public List<OrderItem> Items { get; set; }
        }

        public class OrderItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }

}