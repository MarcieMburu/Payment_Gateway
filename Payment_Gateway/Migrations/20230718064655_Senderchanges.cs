using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payment_Gateway.Migrations
{
    public partial class Senderchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sen_Src_Acc",
                table: "Sender",
                newName: "Src_Acc");

            migrationBuilder.RenameColumn(
                name: "Sen_Phone",
                table: "Sender",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Sen_Name",
                table: "Sender",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Sen_ID_NO",
                table: "Sender",
                newName: "ID_NO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Src_Acc",
                table: "Sender",
                newName: "Sen_Src_Acc");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Sender",
                newName: "Sen_Phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Sender",
                newName: "Sen_Name");

            migrationBuilder.RenameColumn(
                name: "ID_NO",
                table: "Sender",
                newName: "Sen_ID_NO");
        }
    }
}
