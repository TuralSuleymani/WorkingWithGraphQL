using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _002_GraphQLWithEFCore.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "id1@gmail.com", "Simon Baker" },
                    { 2, "id2@gmail.com", "Hanayama Kaoru" },
                    { 3, "id3@gmail.com", "Hanma Baki" },
                    { 4, "id4@gmail.com", "O. Doppo" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CVC", "CustomerId", "ExpiryDate", "Number" },
                values: new object[,]
                {
                    { 1, "345", 1, "08/26", "1234-2345-3445-3456" },
                    { 2, "345", 2, "08/26", "1234-2345-3445-3456" },
                    { 3, "123", 3, "09/25", "3344-7654-3445-3456" },
                    { 4, "234", 4, "07/24", "5566-5454-3445-3456" },
                    { 5, "987", 1, "06/26", "6677-3232-3445-3456" },
                    { 6, "654", 1, "05/27", "8899-9898-3445-3456" },
                    { 7, "432", 2, "04/28", "9900-5678-3445-3456" },
                    { 8, "165", 1, "03/23", "1122-5678-3445-3456" },
                    { 9, "651", 2, "02/29", "2233-2543-3445-3456" },
                    { 10, "987", 3, "01/26", "3544-1234-3445-3456" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CustomerId",
                table: "Cards",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
