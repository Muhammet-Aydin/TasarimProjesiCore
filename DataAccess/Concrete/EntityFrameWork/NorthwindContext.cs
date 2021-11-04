using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
   public class NorthwindContext:DbContext//connecıton strıng baglantısı ıcın olusturduk.//ayrı bir klasor acıp onn ıcıne de connecıton strıngı baglansıtısını yapabilirdik.
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source =DESKTOP-3341JEP\\SQLEXPRESS; initial catalog=Northwind;integrated security =True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }



    }
}
