﻿namespace _003_GraphQLNET_Server.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Card> Cards { get; set; }
    }
}
