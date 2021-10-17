using Microsoft.EntityFrameworkCore.Migrations;

namespace Quarte.Migrations
{
    public partial class SettingsTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderLogo = table.Column<string>(maxLength: 100, nullable: true),
                    FooterLogo = table.Column<string>(maxLength: 100, nullable: true),
                    ContactMail = table.Column<string>(maxLength: 100, nullable: true),
                    SupportMail = table.Column<string>(maxLength: 100, nullable: true),
                    PhoneImage = table.Column<string>(maxLength: 100, nullable: true),
                    ContactPhone = table.Column<string>(maxLength: 100, nullable: true),
                    SupportPhone = table.Column<string>(maxLength: 100, nullable: true),
                    AboutImage = table.Column<string>(maxLength: 100, nullable: true),
                    AboutTitle = table.Column<string>(maxLength: 100, nullable: true),
                    AboutDesc = table.Column<string>(maxLength: 300, nullable: true),
                    AboutText = table.Column<string>(maxLength: 100, nullable: true),
                    AboutRedirectUrl = table.Column<string>(maxLength: 100, nullable: true),
                    AboutRedirectUrlText = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    FacebookUrl = table.Column<string>(maxLength: 100, nullable: true),
                    InstagramUrl = table.Column<string>(maxLength: 100, nullable: true),
                    DribbleUrl = table.Column<string>(maxLength: 100, nullable: true),
                    TwitterUrl = table.Column<string>(maxLength: 100, nullable: true),
                    LinkedinUrl = table.Column<string>(maxLength: 100, nullable: true),
                    FacebookIcon = table.Column<string>(maxLength: 100, nullable: true),
                    InstagramIcon = table.Column<string>(maxLength: 100, nullable: true),
                    TwitterIcon = table.Column<string>(maxLength: 100, nullable: true),
                    DribbleIcon = table.Column<string>(maxLength: 100, nullable: true),
                    LocationIcon = table.Column<string>(maxLength: 100, nullable: true),
                    LinkedinIcon = table.Column<string>(maxLength: 100, nullable: true),
                    PhoneIcon = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
