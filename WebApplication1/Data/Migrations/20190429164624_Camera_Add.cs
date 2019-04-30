using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class Camera_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<decimal>(nullable: true),
                    MaxResolution = table.Column<decimal>(nullable: true),
                    LowResolution = table.Column<decimal>(nullable: true),
                    EffectivePixels = table.Column<decimal>(nullable: true),
                    ZoomWide = table.Column<decimal>(nullable: true),
                    ZoomTele = table.Column<decimal>(nullable: true),
                    NormalFocusRange = table.Column<decimal>(nullable: true),
                    MacroFocusRange = table.Column<decimal>(nullable: true),
                    StorageIncluded = table.Column<decimal>(nullable: true),
                    Weight = table.Column<decimal>(nullable: true),
                    Dimensions = table.Column<decimal>(nullable: true),
                    Price = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cameras");
        }
    }
}
