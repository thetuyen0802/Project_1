using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3.DAL.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Employesses_EmployessId",
                table: "Bills");

            migrationBuilder.AlterColumn<int>(
                name: "EmployessId",
                table: "Bills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 8, 17, 56, 35, 154, DateTimeKind.Local).AddTicks(1078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 8, 16, 12, 27, 624, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Employesses_EmployessId",
                table: "Bills",
                column: "EmployessId",
                principalTable: "Employesses",
                principalColumn: "EmployessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Employesses_EmployessId",
                table: "Bills");

            migrationBuilder.AlterColumn<int>(
                name: "EmployessId",
                table: "Bills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 8, 16, 12, 27, 624, DateTimeKind.Local).AddTicks(3073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 8, 17, 56, 35, 154, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Employesses_EmployessId",
                table: "Bills",
                column: "EmployessId",
                principalTable: "Employesses",
                principalColumn: "EmployessId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
