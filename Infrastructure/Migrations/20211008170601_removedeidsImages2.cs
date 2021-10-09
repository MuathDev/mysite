using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class removedeidsImages2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("21dde688-b776-4019-97bc-39508550e737"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("4c1fb730-9882-4600-89e9-2833c0402c49"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("4c1fb730-9882-4600-89e9-2833c0402c49"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("21dde688-b776-4019-97bc-39508550e737"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }
    }
}
