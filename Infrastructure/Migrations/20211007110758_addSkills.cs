using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class addSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("62ad26ca-fa83-4bee-a1fc-ac7f89e53b80"));

            migrationBuilder.CreateTable(
                name: "PortfolioSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioSkills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("22e794ee-be54-471b-88b3-367ff145e6c9"), null, "avatar.jpg", "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioSkills");

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("22e794ee-be54-471b-88b3-367ff145e6c9"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("62ad26ca-fa83-4bee-a1fc-ac7f89e53b80"), null, "avatar.jpg", "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }
    }
}
