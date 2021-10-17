using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Quarte.Migrations
{
    public partial class ProductsTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    CostPrice = table.Column<double>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    Desc = table.Column<string>(maxLength: 250, nullable: true),
                    Rooms = table.Column<int>(nullable: false),
                    Beds = table.Column<int>(nullable: false),
                    Baths = table.Column<int>(nullable: false),
                    HomeArea = table.Column<double>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(maxLength: 250, nullable: true),
                    WhichFloor = table.Column<int>(nullable: false),
                    HouseFloor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
