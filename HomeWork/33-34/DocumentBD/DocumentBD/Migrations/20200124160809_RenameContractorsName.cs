using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentBD.Migrations
{
    public partial class RenameContractorsName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewFullName",
                table: "Contractors",
                maxLength: 128,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewFullName",
                table: "Contractors");
        }
    }
}
