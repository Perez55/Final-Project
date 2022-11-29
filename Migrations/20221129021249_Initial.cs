using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "hobby",
                columns: table => new
                {
                    HobbyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HobbyID1 = table.Column<int>(type: "int", nullable: true),
                    AdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hobby", x => x.HobbyID);
                    table.ForeignKey(
                        name: "FK_hobby_admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hobby_hobby_HobbyID1",
                        column: x => x.HobbyID1,
                        principalTable: "hobby",
                        principalColumn: "HobbyID");
                });

            migrationBuilder.InsertData(
                table: "admin",
                columns: new[] { "AdminId", "AboutId", "FirstName", "LastName" },
                values: new object[] { 1, 1, "Hilbert", "Perez" });

            migrationBuilder.InsertData(
                table: "hobby",
                columns: new[] { "HobbyID", "AdminId", "Desc", "HobbyID1", "HobbyName" },
                values: new object[] { 1, 1, "Art is the best", null, "Art" });

            migrationBuilder.CreateIndex(
                name: "IX_hobby_AdminId",
                table: "hobby",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_hobby_HobbyID1",
                table: "hobby",
                column: "HobbyID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hobby");

            migrationBuilder.DropTable(
                name: "admin");
        }
    }
}
