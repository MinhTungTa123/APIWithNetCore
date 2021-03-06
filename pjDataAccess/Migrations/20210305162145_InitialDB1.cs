using Microsoft.EntityFrameworkCore.Migrations;

namespace pjDataAccess.Migrations
{
    public partial class InitialDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriteID",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriteID",
                table: "Recipes");
        }
    }
}
