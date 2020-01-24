using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentBD.Migrations
{
    public partial class DeleteContractorsName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Contractors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Contractors",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);
        }
    }
}
