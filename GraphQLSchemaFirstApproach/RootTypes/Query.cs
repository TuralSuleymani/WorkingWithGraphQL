using GraphQL;
using GraphQLSchemaFirstApproach.Database;
using GraphQLSchemaFirstApproach.Models;


namespace GraphQLSchemaFirstApproach.RootTypes
{
    public class Query
    {

        [GraphQLMetadata("employees")]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await new InMemoryDb().GetEmployeesAsync();
        }

        [GraphQLMetadata("cards")]
        public async Task<IEnumerable<Card>> GetCards()
        {
            return await new InMemoryDb().GetCardsAsync();
        }
    }
}
