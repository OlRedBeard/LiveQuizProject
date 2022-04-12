using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizClasses.Migrations
{
    public partial class remappedquizinstancetoalistonquiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuizInstanceId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Instances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    Started = table.Column<bool>(type: "bit", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instances_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_QuizInstanceId",
                table: "Users",
                column: "QuizInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Instances_QuizId",
                table: "Instances",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Instances_QuizInstanceId",
                table: "Users",
                column: "QuizInstanceId",
                principalTable: "Instances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Instances_QuizInstanceId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Instances");

            migrationBuilder.DropIndex(
                name: "IX_Users_QuizInstanceId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "QuizInstanceId",
                table: "Users");
        }
    }
}
