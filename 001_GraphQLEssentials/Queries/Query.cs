using _001_GraphQLEssentials.Models;

namespace _001_GraphQLEssentials.Queries
{
    public class Query
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new
                Customer[]
            {
                new Customer{ Id = 1, Email = "bakihanma@gmail.com", Name = "Baki",
                Cards = new List<Card>()
                {
                    new Card{ Number = "1234-1234-4444", CVC="653", ExpiryDate="08/28", Id = 1},
                    new Card{ Number = "7766-1234-4444", CVC="765", ExpiryDate="08/26", Id = 2},
                } },
                new Customer{ Id = 2, Email = "hanayamakaoru@gmail.com", Name = "Hanamayama",
                 Cards = new List<Card>()
                {
                    new Card{ Number = "7878-3333-4444", CVC="222", ExpiryDate="08/28", Id = 3},
                    new Card{ Number = "7766-6789-1234", CVC="111", ExpiryDate="08/26", Id = 4},
                } },
                new Customer{ Id = 3, Email = "orochi@gmail.com", Name = "Doppo",
                 Cards = new List<Card>()
                {
                    new Card{ Number = "1234-1234-5456", CVC="123", ExpiryDate="08/28", Id = 5},
                    new Card{ Number = "8888-4444-4532", CVC="345", ExpiryDate="08/26", Id = 6},
                } },
                new Customer{ Id = 4, Email = "dorian@gmail.com", Name = "Dorian", Cards = new List<Card>()
                {
                    new Card{ Number = "8989-5555-4444", CVC="567", ExpiryDate="08/28", Id = 7},
                    new Card{ Number = "7766-6666-4444", CVC="789", ExpiryDate="08/26", Id = 8},
                } },
            };
        }
    }
}
