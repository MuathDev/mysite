using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class removedefaultidsImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("8c922b40-0607-4039-a074-7b24e8498b2d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "OwnerId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("cd8c4f52-5f81-45c0-b777-63cbbd5cbe07"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("cd8c4f52-5f81-45c0-b777-63cbbd5cbe07"));

            migrationBuilder.AlterColumn<Guid>(
                name: "OwnerId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("8c922b40-0607-4039-a074-7b24e8498b2d"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }
    }
}
