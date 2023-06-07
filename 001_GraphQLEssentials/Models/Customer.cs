namespace _001_GraphQLEssentials.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Card> Cards { get; set; }
    }
}
