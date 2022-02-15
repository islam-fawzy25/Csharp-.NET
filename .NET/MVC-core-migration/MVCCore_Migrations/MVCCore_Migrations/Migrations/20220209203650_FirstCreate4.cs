using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCore_Migrations.Migrations
{
    public partial class FirstCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 2, 9, 21, 36, 49, 780, DateTimeKind.Local).AddTicks(3427));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 10, 27, 10, 36, 5, 789, DateTimeKind.Local).AddTicks(8167));
        }
    }
}
