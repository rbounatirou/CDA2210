﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CerealApi.Migrations
{
    /// <inheritdoc />
    public partial class cerealsv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Protein",
                table: "Cereals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Protein",
                table: "Cereals");
        }
    }
}
