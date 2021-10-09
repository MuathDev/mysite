using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class insertdefaultidsforImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("b410b276-5690-4792-aab6-641f0a4bcbf1"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SkillsId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "PortfolioItemId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("8c922b40-0607-4039-a074-7b24e8498b2d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SkillsId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "PortfolioItemId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

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
                values: new object[] { new Guid("b410b276-5690-4792-aab6-641f0a4bcbf1"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }
    }
}
