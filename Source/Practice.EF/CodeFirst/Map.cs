using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.EF.CodeFirst
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            
        }

    }

    public class OrderItemMap : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMap()
        {

        }
    }
    public class ProductMap:EntityTypeConfiguration<BookProduct>
    {
        public ProductMap()
        {
            
        }
    }
    public class SimpleProductMap : EntityTypeConfiguration<SimpleProduct>
    {
        public SimpleProductMap()
        {
            this.Map(s => s.ToTable("SimpleProduct"));
            this.Map(s=>s.MapInheritedProperties());
           
        }

    }

    public class BookProductProductMap : EntityTypeConfiguration<BookProduct>
    {
        public BookProductProductMap()
        {
            this.Map(s => s.ToTable("BookProduct"));
            this.Map(s => s.MapInheritedProperties());
         
        }

    }
}
