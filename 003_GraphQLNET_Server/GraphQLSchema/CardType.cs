using _003_GraphQLNET_Server.Models;
using GraphQL.Types;

namespace _003_GraphQLNET_Server.GraphQLSchema
{
    public class CardType : ObjectGraphType<Card>
    {
        public CardType()
        {
            Field(x => x.Id);
            Field(x => x.Number);
            Field(x => x.CustomerId);
            Field(x => x.CVC);
            Field(x => x.ExpiryDate);
        }
    }
}
