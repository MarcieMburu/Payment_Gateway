using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payment_Gateway.Migrations
{
    public partial class tableschanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Receiver_Id",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Sender_Id",
                table: "Transactions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Receiver_Id",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sender_Id",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
