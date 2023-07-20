using _003_GraphQLNET_Server.Models;
using Microsoft.EntityFrameworkCore;

namespace _003_GraphQLNET_Server.Database
{
    public class GraphQLAppDbContext : DbContext
    {
        public GraphQLAppDbContext(DbContextOptions<GraphQLAppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Cards)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .HasData(new Customer() { Id = 1, Email = "id1@gmail.com", Name = "Simon Baker" },
                         new Customer() { Id = 2, Email = "id2@gmail.com", Name = "Hanayama Kaoru" },
                         new Customer() { Id = 3, Email = "id3@gmail.com", Name = "Hanma Baki" },
                         new Customer() { Id = 4, Email = "id4@gmail.com", Name = "O. Doppo" });

            modelBuilder.Entity<Card>()
                .HasData(new Card() { Id = 1, CustomerId = 1, Number = "1234-2345-3445-3456", CVC = "345", ExpiryDate = "08/26" },
                         new Card() { Id = 2, CustomerId = 2, Number = "1234-2345-3445-3456", CVC = "345", ExpiryDate = "08/26" },
                         new Card() { Id = 3, CustomerId = 3, Number = "3344-7654-3445-3456", CVC = "123", ExpiryDate = "09/25" },
                         new Card() { Id = 4, CustomerId = 4, Number = "5566-5454-3445-3456", CVC = "234", ExpiryDate = "07/24" },
                         new Card() { Id = 5, CustomerId = 1, Number = "6677-3232-3445-3456", CVC = "987", ExpiryDate = "06/26" },
                         new Card() { Id = 6, CustomerId = 1, Number = "8899-9898-3445-3456", CVC = "654", ExpiryDate = "05/27" },
                         new Card() { Id = 7, CustomerId = 2, Number = "9900-5678-3445-3456", CVC = "432", ExpiryDate = "04/28" },
                         new Card() { Id = 8, CustomerId = 1, Number = "1122-5678-3445-3456", CVC = "165", ExpiryDate = "03/23" },
                         new Card() { Id = 9, CustomerId = 2, Number = "2233-2543-3445-3456", CVC = "651", ExpiryDate = "02/29" },
                         new Card() { Id = 10, CustomerId = 3, Number = "3544-1234-3445-3456", CVC = "987", ExpiryDate = "01/26" });

            base.OnModelCreating(modelBuilder);
        }
    }
}
