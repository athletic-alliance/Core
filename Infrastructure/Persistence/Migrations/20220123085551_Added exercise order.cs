﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AthleticAlliance.Infrastructure.Persistence.Migrations
{
    public partial class Addedexerciseorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "WorkoutExercises",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "WorkoutExercises");
        }
    }
}
