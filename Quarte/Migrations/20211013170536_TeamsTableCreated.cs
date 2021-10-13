using Microsoft.EntityFrameworkCore.Migrations;

namespace Quarte.Migrations
{
    public partial class TeamsTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 250, nullable: true),
                    FullName = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 250, nullable: true),
                    FacebookIcon = table.Column<string>(maxLength: 250, nullable: true),
                    TwitterIcon = table.Column<string>(maxLength: 250, nullable: true),
                    LinkedinIcon = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_TeamId",
                table: "Products",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Teams_TeamId",
                table: "Products",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Teams_TeamId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Products_TeamId",
                table: "Products");
        }
    }
}
