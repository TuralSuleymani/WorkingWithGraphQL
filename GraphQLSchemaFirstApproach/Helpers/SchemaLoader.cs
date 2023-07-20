using GraphQL.Types;
using GraphQLSchemaFirstApproach.Extensions;
using GraphQLSchemaFirstApproach.RootTypes;

namespace GraphQLSchemaFirstApproach.Helpers
{
    public class SchemaLoader
    {
        public const string SchemaFolder = "Schema";
        public const string SchemaExtension = ".graphql";
        public static Schema LoadSchema(string schemaName)
        {
            string pathTograpthQlSchema = Path.Combine(ApplicationPath.PathTo(SchemaFolder), $"{schemaName}{SchemaExtension}");
            string schemaContent = File.ReadAllText(pathTograpthQlSchema);
            return Schema.For(schemaContent, _ => _.Types.Include<Query>());
        }
    }
}
