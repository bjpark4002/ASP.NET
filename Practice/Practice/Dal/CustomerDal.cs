using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Practice.Models;
namespace Practice.Dal
{
    public class CustomerDal : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().ToTable("CustomerTable");
        }
        public DbSet<Customer> Customers { get; set; }

    }
}