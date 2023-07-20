using _003_GraphQLNET_Server.Database;
using GraphiQl;
using Microsoft.EntityFrameworkCore;

namespace _003_GraphQLNET_Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<GraphQLAppDbContext>(
        options => options.UseSqlServer("Data Source=.;Initial Catalog=GraphQLDb;Integrated Security=SSPI;TrustServerCertificate=True;"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseGraphiQl();
            app.MapControllers();

            app.Run();
        }
    }
}