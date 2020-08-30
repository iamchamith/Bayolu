using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bayolu.AppService.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Bayolu");

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Bayolu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 500, nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Team = table.Column<int>(nullable: false),
                    StorageCapacity = table.Column<decimal>(nullable: false),
                    OriginalFolder = table.Column<string>(maxLength: 50, nullable: false),
                    Comment = table.Column<string>(maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User",
                schema: "Bayolu");
        }
    }
}
