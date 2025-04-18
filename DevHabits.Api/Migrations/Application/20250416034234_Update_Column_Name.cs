﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevHabits.Api.Migrations.Application
{
    /// <inheritdoc />
    public partial class Update_Column_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "frequency_frequency_type",
                schema: "dev_habit",
                table: "habits",
                newName: "frequency_type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "frequency_type",
                schema: "dev_habit",
                table: "habits",
                newName: "frequency_frequency_type");
        }
    }
}
