using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBank.Databases.Migrations
{
    /// <inheritdoc />
    public partial class version1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionFrom = table.Column<int>(type: "int", nullable: false),
                    TransectionTo = table.Column<int>(type: "int", nullable: false),
                    TransactionAmmount = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransactions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankTransactions");
        }
    }
}
