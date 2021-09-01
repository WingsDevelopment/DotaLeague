using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlDataAccess.Migrations
{
    public partial class Added_PlayerShort_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfMatches",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pos1PriorityValue",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pos2PriorityValue",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pos3PriorityValue",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pos4PriorityValue",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pos5PriorityValue",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Winrate",
                table: "Players",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "NumberOfMatches",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Pos1PriorityValue",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Pos2PriorityValue",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Pos3PriorityValue",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Pos4PriorityValue",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Pos5PriorityValue",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Winrate",
                table: "Players");
        }
    }
}
