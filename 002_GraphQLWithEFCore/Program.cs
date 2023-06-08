using _002_GraphQLWithEFCore.Database;
using _002_GraphQLWithEFCore.Queries;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GraphQLAppDbContext>(
        options => options.UseSqlServer("Data Source=.;Initial Catalog=GraphQLDb;Integrated Security=SSPI;TrustServerCertificate=True;"));

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.MapGraphQL();

app.Run();
