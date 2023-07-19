using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payment_Gateway.Migrations
{
    public partial class ReceiverChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Receiver_ReceiverId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "Receiver");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_ReceiverId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "ReceiverId",
                table: "Transactions",
                newName: "Receiver_Id");

            migrationBuilder.AddColumn<string>(
                name: "Receiver_Dst_Acc",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Receiver_ID_NO",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Receiver_Name",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Receiver_Phone",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Receiver_Dst_Acc",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Receiver_ID_NO",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Receiver_Name",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Receiver_Phone",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Receiver_Id",
                table: "Transactions",
                newName: "ReceiverId");

            migrationBuilder.CreateTable(
                name: "Receiver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rec_Dst_Acc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rec_ID_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rec_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rec_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receiver", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ReceiverId",
                table: "Transactions",
                column: "ReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Receiver_ReceiverId",
                table: "Transactions",
                column: "ReceiverId",
                principalTable: "Receiver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
