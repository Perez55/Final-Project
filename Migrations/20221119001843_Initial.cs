using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "hobby",
                columns: table => new
                {
                    HobbyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HobbyId1 = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hobby", x => x.HobbyId);
                    table.ForeignKey(
                        name: "FK_hobby_hobby_HobbyId1",
                        column: x => x.HobbyId1,
                        principalTable: "hobby",
                        principalColumn: "HobbyId");
                    table.ForeignKey(
                        name: "FK_hobby_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "UserId", "Desc", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 1, "I am Smart", "John", "Doe", "joe", "jdoe" });

            migrationBuilder.InsertData(
                table: "hobby",
                columns: new[] { "HobbyId", "Desc", "HobbyId1", "HobbyName", "UserId" },
                values: new object[] { 1, "Art is the best", null, "Art", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_hobby_HobbyId1",
                table: "hobby",
                column: "HobbyId1");

            migrationBuilder.CreateIndex(
                name: "IX_hobby_UserId",
                table: "hobby",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hobby");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
