using Microsoft.EntityFrameworkCore.Migrations;

namespace Quarte.Migrations
{
    public partial class ServicesTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(nullable: false),
                    Icon = table.Column<string>(maxLength: 250, nullable: true),
                    Title = table.Column<string>(maxLength: 250, nullable: true),
                    Desc = table.Column<string>(maxLength: 250, nullable: true),
                    RedirectUrl = table.Column<string>(maxLength: 250, nullable: true),
                    RedirectUrlText = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
