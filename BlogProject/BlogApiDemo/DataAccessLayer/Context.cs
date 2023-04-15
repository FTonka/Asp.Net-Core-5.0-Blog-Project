using BlogApiDemo.EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=TONKA;database=BlogApiDemoDB;integrated security=true");

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
