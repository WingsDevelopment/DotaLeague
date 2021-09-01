using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlDataAccess.Migrations
{
    public partial class Renamed_Table_To_QUEUE_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Queue",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Leagues",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Queue");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Leagues");
        }
    }
}
