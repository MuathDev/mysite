using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class insertdefaultid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("8a4ce6b2-c60a-44c6-9444-598f7a81407b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("b410b276-5690-4792-aab6-641f0a4bcbf1"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("b410b276-5690-4792-aab6-641f0a4bcbf1"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("8a4ce6b2-c60a-44c6-9444-598f7a81407b"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }
    }
}
