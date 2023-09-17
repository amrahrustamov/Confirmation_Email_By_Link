using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok.Migrations
{
    public partial class Confirm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsEmailConfirmed",
                table: "Users",
                newName: "IsRegisterConfirmed");

            migrationBuilder.RenameColumn(
                name: "ConfirmToken",
                table: "Users",
                newName: "ConfirmGuidCode");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "$2a$11$piEISmP0RU0VFvxjoHlnp.tA5FCU1LDI6uAkwtYiQgJA3Hec0inJC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRegisterConfirmed",
                table: "Users",
                newName: "IsEmailConfirmed");

            migrationBuilder.RenameColumn(
                name: "ConfirmGuidCode",
                table: "Users",
                newName: "ConfirmToken");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1,
                column: "Password",
                value: "$2a$11$X1zHYPmrcqvnXWwEmTejTu4/Xkdb5ASMaMCxfrmhu3CnaQnSfjp5m");
        }
    }
}
