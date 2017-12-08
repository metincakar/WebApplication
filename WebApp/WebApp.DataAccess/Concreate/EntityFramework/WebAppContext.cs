using Microsoft.EntityFrameworkCore;
using WebApp.Entities.Concreate;

namespace WebApp.DataAccess.Concreate.EntityFramework
{
    public class WebAppContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server:(localdb)\mssqllocaldb;Database=WebAppDb;Trusted_Connection=true;");
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        
    }
}