using Loans.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Loans.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {
            
        }


        public DbSet<BranchOffice> BranchOffices { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("CountryId", "Name").IsUnique();
            modelBuilder.Entity<City>().HasIndex("StateId", "Name").IsUnique();
            modelBuilder.Entity<BranchOffice>().HasIndex("CityId", "Name").IsUnique();
        }
    }
}
