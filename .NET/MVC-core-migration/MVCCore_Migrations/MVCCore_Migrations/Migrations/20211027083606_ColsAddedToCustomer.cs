using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCore_Migrations.Migrations
{
    public partial class ColsAddedToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 10, 27, 10, 36, 5, 789, DateTimeKind.Local).AddTicks(8167));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 10, 27, 9, 56, 5, 290, DateTimeKind.Local).AddTicks(8390));
        }
    }
}
