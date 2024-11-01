using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Test1.users
{
    internal class context: DbContext
    {
        public DbSet<customers> customers { get; set; }
        public DbSet<orders> orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NV016Q3;Initial Catalog=pharma;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<orders>().HasOne<customers>(o=>o.customers).WithMany(c=>c.orders).HasForeignKey(o=>o.customer_id);
        }


    }
}
