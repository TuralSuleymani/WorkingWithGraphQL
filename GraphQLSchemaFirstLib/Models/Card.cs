namespace GraphQLSchemaFirstLib.Models
{
    public enum CardType
    {
        Visa,
        Master
    }

    public record Card(int Id, string CardHolder, string CardNumber, CardType CardType, Employee Employee);
}
