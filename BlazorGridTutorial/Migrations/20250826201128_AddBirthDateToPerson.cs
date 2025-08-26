using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorGridTutorial.Migrations
{
    /// <inheritdoc />
    public partial class AddBirthDateToPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "BirthDate",
                table: "People",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "People");
        }
    }
}
