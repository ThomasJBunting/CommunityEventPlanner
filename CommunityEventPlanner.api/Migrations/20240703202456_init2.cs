using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommunityEventPlanner.api.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CommunityEventSubscriptions_UserId",
                table: "CommunityEventSubscriptions");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityEventSubscriptions_UserId_EventId",
                table: "CommunityEventSubscriptions",
                columns: new[] { "UserId", "EventId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CommunityEventSubscriptions_UserId_EventId",
                table: "CommunityEventSubscriptions");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityEventSubscriptions_UserId",
                table: "CommunityEventSubscriptions",
                column: "UserId");
        }
    }
}
