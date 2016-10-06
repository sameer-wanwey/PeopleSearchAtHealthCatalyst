using System.Data.Entity;
using PeopleSearchAtHealthCatalyst.Model;

namespace PeopleSearchAtHealthCatalyst.Repository
{
    public class PeopleSearchAtHealthCatalystContext : DbContext
    {
        public DbSet<Person> people { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(p => p.CreatedDate)
                .HasColumnType("datetime2")
                .HasPrecision(0);

            modelBuilder.Entity<Person>()
                .Property(p => p.ModifiedDate)
                .HasColumnType("datetime2")
                .HasPrecision(0);
        }
    }
}
