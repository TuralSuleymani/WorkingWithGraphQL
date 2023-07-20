namespace _003_GraphQLNET_Server.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string CVC { get; set; }
        public string ExpiryDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
