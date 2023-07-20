using _003_GraphQLNET_Server.Database;
using _003_GraphQLNET_Server.Models;
using _003_GraphQLNET_Server.Services.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace _003_GraphQLNET_Server.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly GraphQLAppDbContext _dbContext;
        public CustomerService(GraphQLAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Customer?> GetCustomerByIdAsync(int id)
        {
           return await _dbContext.Customers.SingleOrDefaultAsync(x => x.Equals(id));
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _dbContext.Customers.ToListAsync();
        }
    }
}
