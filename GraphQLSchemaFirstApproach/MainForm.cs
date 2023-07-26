using GraphQL.SystemTextJson;
using GraphQL.Types;
using GraphQLSchemaFirstApproach.Helpers;

namespace GraphQLSchemaFirstApproach
{
    public partial class MainForm : Form
    {
        private Schema _schema;
        public MainForm()
        {
            InitializeComponent();
            _schema = SchemaLoader.LoadSchema("GraphQLSchema");
        }

        private async void Btn_execute_Click(object sender, EventArgs e)
        {
            var schemaExecutionResponse = await _schema.ExecuteAsync(_ => _.Query = rcbx_request.Text);
            rcbx_response.Text = schemaExecutionResponse;
        }

    }
}