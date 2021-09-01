using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlDataAccess.Migrations
{
    public partial class Added_PlayerShort_Model_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShortPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    WinRate = table.Column<float>(nullable: false),
                    MMR = table.Column<int>(nullable: false),
                    NumberOfMatches = table.Column<int>(nullable: false),
                    SteamID = table.Column<string>(nullable: true),
                    VouchedLeague = table.Column<int>(nullable: false),
                    Pos1PriorityValue = table.Column<int>(nullable: false),
                    Pos2PriorityValue = table.Column<int>(nullable: false),
                    Pos3PriorityValue = table.Column<int>(nullable: false),
                    Pos4PriorityValue = table.Column<int>(nullable: false),
                    Pos5PriorityValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortPlayers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShortPlayers");
        }
    }
}
