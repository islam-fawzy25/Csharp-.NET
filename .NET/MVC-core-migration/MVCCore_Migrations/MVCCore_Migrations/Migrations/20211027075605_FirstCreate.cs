using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCore_Migrations.Migrations
{
    public partial class FirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CId = table.Column<int>(type: "int", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CId",
                        column: x => x.CId,
                        principalTable: "Customers",
                        principalColumn: "CId",                        
                        onDelete: ReferentialAction.Cascade);// onUpdate: ReferentialAction.NoAction,
                    table.ForeignKey(
                        name: "FK_Orders_Products_PId",
                        column: x => x.PId,
                        principalTable: "Products",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CId", "Name" },
                values: new object[] { 3, "Ole Olsen" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] {  "Name", "Price" },
                values: new object[] { "TV", 5555.0 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OId", "CId", "OrderDate", "PId", "Qty" },
                values: new object[] { 1, 3, new DateTime(2021, 10, 27, 9, 56, 5, 290, DateTimeKind.Local).AddTicks(8390), 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CId",
                table: "Orders",
                column: "CId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PId",
                table: "Orders",
                column: "PId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
