using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeChat.Messaging.Persistence.Migrations
{
    public partial class AddedFriendships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {  
            migrationBuilder.CreateTable(
                name: "Relationship_Friendship",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcceptedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship_Friendship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relationship_Friendship_User_SourceUserId",
                        column: x => x.SourceUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Relationship_Friendship_User_TargetUserId",
                        column: x => x.TargetUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_Friendship_SourceUserId",
                schema: "dbo",
                table: "Relationship_Friendship",
                column: "SourceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_Friendship_TargetUserId",
                schema: "dbo",
                table: "Relationship_Friendship",
                column: "TargetUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relationship_Friendship",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_Relationship_Friendship_SourceUserId",
                schema: "dbo",
                table: "Relationship_Friendship");

            migrationBuilder.DropIndex(
                name: "IX_Relationship_Friendship_TargetUserId",
                schema: "dbo",
                table: "Relationship_Friendship");
        }
    }
}
