using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AthleticAlliance.Infrastructure.Persistence.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "DoneWorkoutToUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "DoneWorkoutToUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
