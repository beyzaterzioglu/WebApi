using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class NorthwindDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // veri tabanı bağlantısı yapıldı
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true;MultipleActiveResultSets=true");
        }
        public DbSet<Customer> Customers { get; set; } //tabloyu nesneyle eşleştirdik
        public DbSet<Order> Orders { get; set; } //tabloyu nesneyle eşleştirdik 
        // entity framework sayesinde aynı isime sahip olanlar eşleşiyor.
    }
}
