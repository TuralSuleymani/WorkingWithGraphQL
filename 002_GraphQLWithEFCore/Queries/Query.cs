using _002_GraphQLEssentials.Models;
using _002_GraphQLWithEFCore.Database;
using Microsoft.EntityFrameworkCore;

namespace _002_GraphQLWithEFCore.Queries
{
    public class Query
    {
        [UsePaging(MaxPageSize = 2, AllowBackwardPagination =true)]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Customer> GetCustomers([Service] GraphQLAppDbContext graphqldbcontext)
        => graphqldbcontext.Customers.Include("Cards");
    }
}
