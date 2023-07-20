using _003_GraphQLNET_Server.Services.Abstraction;
using GraphQL.Types;

namespace _003_GraphQLNET_Server.GraphQLSchema
{
    public class CustomersQuery : ObjectGraphType<object>
    {
        public CustomersQuery(ICustomerService customerService)
        {
            Name = "Query";
            Field<ListGraphType<CustomerType>>("customers").Resolve(c => customerService.GetCustomersAsync());
        }
    }
}
