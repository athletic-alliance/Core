using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AthleticAlliance.Infrastructure.Persistence.Migrations
{
    public partial class Createdbaseentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Exercises",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Exercises",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Exercises",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Exercises",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Exercises",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Exercises");
        }
    }
}
