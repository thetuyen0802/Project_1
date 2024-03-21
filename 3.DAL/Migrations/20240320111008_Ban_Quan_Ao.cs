using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3.DAL.Migrations
{
    public partial class Ban_Quan_Ao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 18, 10, 8, 249, DateTimeKind.Local).AddTicks(1432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 13, 9, 17, 523, DateTimeKind.Local).AddTicks(528));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 13, 9, 17, 523, DateTimeKind.Local).AddTicks(528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 18, 10, 8, 249, DateTimeKind.Local).AddTicks(1432));
        }
    }
}
