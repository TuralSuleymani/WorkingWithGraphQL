using _003_GraphQLNET_Server.Models;
using _003_GraphQLNET_Server.Services.Abstraction;
using GraphQL.Types;

namespace _003_GraphQLNET_Server.GraphQLSchema
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType(ICardService cardService)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Email);
            Field<ListGraphType<CardType>>("cards").Resolve(context  => cardService.GetCardsByCustomerIdAsync(context.Source.Id));
        }
    }
}
