using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizClasses.Migrations
{
    public partial class changeduserscores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumCorrect",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumQuestions",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TimeToAnswer",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumCorrect",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "NumQuestions",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "TimeToAnswer",
                table: "Scores");
        }
    }
}
