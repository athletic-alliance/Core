using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AthleticAlliance.Infrastructure.Persistence.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinishedWorkoutDetails_Workouts_WorkoutId",
                table: "FinishedWorkoutDetails");

            migrationBuilder.DropIndex(
                name: "IX_FinishedWorkoutDetails_WorkoutId",
                table: "FinishedWorkoutDetails");

            migrationBuilder.DropColumn(
                name: "WorkoutId",
                table: "FinishedWorkoutDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkoutId",
                table: "FinishedWorkoutDetails",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FinishedWorkoutDetails_WorkoutId",
                table: "FinishedWorkoutDetails",
                column: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_FinishedWorkoutDetails_Workouts_WorkoutId",
                table: "FinishedWorkoutDetails",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id");
        }
    }
}
