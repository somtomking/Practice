using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.EF.CodeFirst
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DB") {
        
            
        }

        
        //public DbSet<Order> Order { get; set; }
        //public DbSet<Product> Product { get; set; }
        public DbSet<ATable> A { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new OrderMap());
            //modelBuilder.Configurations.Add(new OrderItemMap());
            //modelBuilder.Configurations.Add(new SimpleProductMap());
            //modelBuilder.Configurations.Add(new BookProductProductMap());
            modelBuilder.Configurations.Add(new ATableMap());
            modelBuilder.Configurations.Add(new BTableMap());
            base.OnModelCreating(modelBuilder);
        }
       
    }
}
