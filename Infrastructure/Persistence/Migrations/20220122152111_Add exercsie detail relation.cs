using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AthleticAlliance.Infrastructure.Persistence.Migrations
{
    public partial class Addexercsiedetailrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExerciseDetails_WorkoutExercises_ExerciseId",
                table: "WorkoutExerciseDetails");

            migrationBuilder.DropIndex(
                name: "IX_WorkoutExerciseDetails_ExerciseId",
                table: "WorkoutExerciseDetails");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "WorkoutExerciseDetails");

            migrationBuilder.AddColumn<int>(
                name: "DetailsId",
                table: "WorkoutExercises",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_DetailsId",
                table: "WorkoutExercises",
                column: "DetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExercises_WorkoutExerciseDetails_DetailsId",
                table: "WorkoutExercises",
                column: "DetailsId",
                principalTable: "WorkoutExerciseDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExercises_WorkoutExerciseDetails_DetailsId",
                table: "WorkoutExercises");

            migrationBuilder.DropIndex(
                name: "IX_WorkoutExercises_DetailsId",
                table: "WorkoutExercises");

            migrationBuilder.DropColumn(
                name: "DetailsId",
                table: "WorkoutExercises");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseId",
                table: "WorkoutExerciseDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExerciseDetails_ExerciseId",
                table: "WorkoutExerciseDetails",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExerciseDetails_WorkoutExercises_ExerciseId",
                table: "WorkoutExerciseDetails",
                column: "ExerciseId",
                principalTable: "WorkoutExercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
