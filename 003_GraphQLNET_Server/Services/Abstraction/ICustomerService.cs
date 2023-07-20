using _003_GraphQLNET_Server.Models;

namespace _003_GraphQLNET_Server.Services.Abstraction
{
    public interface ICustomerService
    {
        Task<Customer?> GetCustomerByIdAsync(int id);
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
