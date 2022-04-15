using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizClasses.Migrations
{
    public partial class updateduserscores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeToAnswer",
                table: "Scores",
                newName: "TotalTime");

            migrationBuilder.AddColumn<int>(
                name: "AvgTimeToAnswer",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgTimeToAnswer",
                table: "Scores");

            migrationBuilder.RenameColumn(
                name: "TotalTime",
                table: "Scores",
                newName: "TimeToAnswer");
        }
    }
}
