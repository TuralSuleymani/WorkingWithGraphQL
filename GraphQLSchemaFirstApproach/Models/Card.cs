namespace GraphQLSchemaFirstApproach.Models
{
    public enum CardType
    {
        Visa,
        Master
    }

    public record Card(int Id, string CardHolder, string cardNumber,CardType CardType, Employee Employee);
}
