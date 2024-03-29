using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3.DAL.Migrations
{
    public partial class Du_An_mot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 1, 44, 47, 822, DateTimeKind.Local).AddTicks(9296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 10, 56, 47, 961, DateTimeKind.Local).AddTicks(6294));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 10, 56, 47, 961, DateTimeKind.Local).AddTicks(6294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 1, 44, 47, 822, DateTimeKind.Local).AddTicks(9296));
        }
    }
}
