using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace challenge_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Participation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "LastName", "Participation" },
                values: new object[] { 100, "Rodrigo", "Costa", 20 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "LastName", "Participation" },
                values: new object[] { 102, "Teste", "123", 30 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
