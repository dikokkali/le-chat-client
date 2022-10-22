using Microsoft.EntityFrameworkCore.Migrations;

namespace LeChat.Messaging.Persistence.Migrations
{
    public partial class InitialChangeSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "User",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Message",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ChatSession",
                newName: "ChatSession",
                newSchema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "User",
                schema: "dbo",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Message",
                schema: "dbo",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "ChatSession",
                schema: "dbo",
                newName: "ChatSession");
        }
    }
}
