using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "about",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_about", x => x.AboutId);
                });

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
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hobby", x => x.HobbyID);
                });

            migrationBuilder.CreateTable(
                name: "AdminHobbies",
                columns: table => new
                {
                    AdminHobbyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    HobbyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminHobbies", x => x.AdminHobbyId);
                    table.ForeignKey(
                        name: "FK_AdminHobbies_admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminHobbies_hobby_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "hobby",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "admin",
                columns: new[] { "AdminId", "AboutId", "FirstName", "LastName" },
                values: new object[] { 1, 1, "Hilbert", "Perez" });

            migrationBuilder.InsertData(
                table: "hobby",
                columns: new[] { "HobbyID", "Desc", "HobbyName" },
                values: new object[] { 1, "Art is the best", "Art" });

            migrationBuilder.InsertData(
                table: "AdminHobbies",
                columns: new[] { "AdminHobbyId", "AdminId", "HobbyId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AdminHobbies_AdminId",
                table: "AdminHobbies",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminHobbies_HobbyId",
                table: "AdminHobbies",
                column: "HobbyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "about");

            migrationBuilder.DropTable(
                name: "AdminHobbies");

            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "hobby");
        }
    }
}
