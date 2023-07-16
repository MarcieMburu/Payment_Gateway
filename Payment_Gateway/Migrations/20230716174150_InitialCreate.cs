using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payment_Gateway.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receiver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rec_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rec_ID_NO = table.Column<int>(type: "int", nullable: false),
                    Rec_Phone = table.Column<int>(type: "int", nullable: false),
                    Rec_Dst_Acc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receiver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sen_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sen_ID_NO = table.Column<int>(type: "int", nullable: false),
                    Sen_Phone = table.Column<int>(type: "int", nullable: false),
                    Sen_Src_Acc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receiver");

            migrationBuilder.DropTable(
                name: "Sender");

            migrationBuilder.DropTable(
                name: "Transaction");
        }
    }
}
