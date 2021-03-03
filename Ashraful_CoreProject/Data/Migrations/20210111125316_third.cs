using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ashraful_CoreProject.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductAjaxes",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 6, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAjaxes", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAjaxes");
        }
    }
}
