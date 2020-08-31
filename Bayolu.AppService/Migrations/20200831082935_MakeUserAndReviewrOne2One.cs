using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bayolu.AppService.Migrations
{
    public partial class MakeUserAndReviewrOne2One : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.AddColumn<Guid>(
                name: "UserReviews",
                schema: "Bayolu",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserReviews",
                schema: "Bayolu",
                table: "User",
                column: "UserReviews");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserReviews",
                schema: "Bayolu",
                table: "User",
                column: "UserReviews",
                principalSchema: "Bayolu",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserReviews",
                schema: "Bayolu",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserReviews",
                schema: "Bayolu",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserReviews",
                schema: "Bayolu",
                table: "User");

            migrationBuilder.CreateTable(
                name: "UserReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReviews_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Bayolu",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_UserId",
                table: "UserReviews",
                column: "UserId");
        }
    }
}
