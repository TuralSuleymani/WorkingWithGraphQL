using GraphQL.Types;

namespace _003_GraphQLNET_Server.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(CustomersQuery customersQuery, IServiceProvider provider):base(provider)
        {
            Query = customersQuery;
        }
    }
}
