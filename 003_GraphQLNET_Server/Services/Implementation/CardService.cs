using _003_GraphQLNET_Server.Database;
using _003_GraphQLNET_Server.Models;
using _003_GraphQLNET_Server.Services.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace _003_GraphQLNET_Server.Services.Implementation
{
    public class CardService : ICardService
    {
        private readonly GraphQLAppDbContext _dbContext;
        public CardService(GraphQLAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Card?> GetCardByIdAsync(int id)
        {
            return await _dbContext.Cards.SingleOrDefaultAsync(x => x.Equals(id));
        }

        public async Task<IEnumerable<Card>> GetCardsAsync()
        {
            return await _dbContext.Cards.ToListAsync();
        }

        public async Task<IEnumerable<Card>> GetCardsByCustomerIdAsync(int customerId)
        {
            return await _dbContext.Cards
                        .Where(x => x.CustomerId == customerId)
                            .ToListAsync();
        }
    }
}
