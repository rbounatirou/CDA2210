using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBank.Databases.Migrations
{
    /// <inheritdoc />
    public partial class version4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionTo",
                table: "BankTransactions",
                newName: "transaction_to");

            migrationBuilder.RenameColumn(
                name: "TransactionFrom",
                table: "BankTransactions",
                newName: "transeaction_from");

            migrationBuilder.RenameColumn(
                name: "TransactionDate",
                table: "BankTransactions",
                newName: "transaction_date");

            migrationBuilder.RenameColumn(
                name: "TransactionAmmount",
                table: "BankTransactions",
                newName: "transaction_amount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "transeaction_from",
                table: "BankTransactions",
                newName: "TransactionFrom");

            migrationBuilder.RenameColumn(
                name: "transaction_to",
                table: "BankTransactions",
                newName: "TransactionTo");

            migrationBuilder.RenameColumn(
                name: "transaction_date",
                table: "BankTransactions",
                newName: "TransactionDate");

            migrationBuilder.RenameColumn(
                name: "transaction_amount",
                table: "BankTransactions",
                newName: "TransactionAmmount");
        }
    }
}
