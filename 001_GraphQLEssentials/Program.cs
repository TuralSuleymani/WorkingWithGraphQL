using _001_GraphQLEssentials.Queries;

namespace _001_GraphQLEssentials
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddGraphQLServer()
                .AddQueryType<Query>();

            var app = builder.Build();

            app.MapGraphQL();

            app.Run();
        }
    }
}