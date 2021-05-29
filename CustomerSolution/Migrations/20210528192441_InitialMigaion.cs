using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerSolution.Migrations
{
    public partial class InitialMigaion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryContact = table.Column<double>(type: "float", nullable: false),
                    PhoneNumber = table.Column<double>(type: "float", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
