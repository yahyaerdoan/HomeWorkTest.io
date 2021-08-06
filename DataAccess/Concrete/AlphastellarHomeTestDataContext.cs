using AlphastellarHomeTest.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class AlphastellarHomeTestDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =YAHYAERDOGAN\SQLEXPRESS;Database=AlphastellarHomeTestData;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }
    }
}