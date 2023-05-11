using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBank.Databases.Migrations
{
    /// <inheritdoc />
    public partial class version2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransectionTo",
                table: "BankTransactions",
                newName: "TransactionTo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionTo",
                table: "BankTransactions",
                newName: "TransectionTo");
        }
    }
}
