using _003_GraphQLNET_Server.Models;

namespace _003_GraphQLNET_Server.Services.Abstraction
{
    public interface ICardService
    {
        Task<Card?> GetCardByIdAsync(int id);
        Task<IEnumerable<Card>> GetCardsAsync();
    }
}
