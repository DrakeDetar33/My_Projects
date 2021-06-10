using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalPracticeMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Protein",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Animal = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ServingSize = table.Column<int>(nullable: false),
                    ProteinTot = table.Column<double>(nullable: false),
                    FatTot = table.Column<double>(nullable: false),
                    Calories = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protein", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Protein");
        }
    }
}
