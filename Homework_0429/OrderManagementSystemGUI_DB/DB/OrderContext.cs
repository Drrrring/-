using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

namespace OrderManagementSystemGUI_DB
{
    internal class OrderContext:DbContext
    {
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> ordersDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=orderdb;user=root;password=y6655533");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.Client).IsRequired();
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Count).IsRequired();
                entity.Property(e => e.Goods).IsRequired();
                
            });
        }
    }
}
