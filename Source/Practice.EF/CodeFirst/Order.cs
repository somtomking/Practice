using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.EF.CodeFirst
{
    public class Order
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public OrderStutas OrderStutas { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
