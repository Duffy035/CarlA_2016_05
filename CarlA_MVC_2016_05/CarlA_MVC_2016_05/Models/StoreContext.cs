//Carl Andersson

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarlA_MVC_2016_05.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        public StoreContext() : base("StoreDB")
        {
            Database.SetInitializer(new StoreContextInitializer());
        }
    }

    internal class StoreContextInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var stores = new List<Store>();
            stores.Add(new Store()
            {
                StoreId = 1, Name = "IKEA", Address = "Kungsgatan 12, Helsingborg", Products = new List<Product>()
                {
                    new Product() {ProductId = 1, StoreId = 1, Name = "Billy", Price = 400, ProductNumber = 1, ProductsInStock = 100, ProductText = "Fin hylla för fina flickor"},
                    new Product() {ProductId = 2, StoreId = 1, Name = "Willy wonka carpet", Price = 1050, ProductNumber = 2, ProductsInStock = 250, ProductText = "Jättehärlig matta, med en doft av magisk cholkad - det du! Kom och köp!"},
                }
            });
            stores.Add(new Store()
            {
                StoreId = 2, Name = "Hemköp", Address = "Järfällavägen 2, Svedala", Products = new List<Product>()
                {
                    new Product() {ProductId = 1, StoreId = 2, Name = "Gevalia", Price = 50, ProductNumber = 1, ProductsInStock = 400, ProductText = "Gevalia, när du får oväntat besök: Bjud på en köpp!"},
                    new Product() {ProductId = 2, StoreId = 2, Name = "Coca Cola", Price = 20, ProductNumber = 2, ProductsInStock = 100, ProductText = "2L Cola för barnakalaset. Glöm inte att borsta tänderan efteråt, he-hu"}
                }
            });
            context.Stores.AddRange(stores);
            context.SaveChanges();
        }
    }
}