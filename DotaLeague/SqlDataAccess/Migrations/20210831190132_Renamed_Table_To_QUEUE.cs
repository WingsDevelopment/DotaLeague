using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlDataAccess.Migrations
{
    public partial class Renamed_Table_To_QUEUE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShortPlayers",
                table: "ShortPlayers");

            migrationBuilder.RenameTable(
                name: "ShortPlayers",
                newName: "Queue");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Queue",
                table: "Queue",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Queue",
                table: "Queue");

            migrationBuilder.RenameTable(
                name: "Queue",
                newName: "ShortPlayers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShortPlayers",
                table: "ShortPlayers",
                column: "Id");
        }
    }
}
