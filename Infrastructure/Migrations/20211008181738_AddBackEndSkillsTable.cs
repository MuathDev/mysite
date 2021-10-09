using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddBackEndSkillsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioSkills");

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("478dc6ce-0fdb-4512-98ac-784576d4faa2"));

            migrationBuilder.CreateTable(
                name: "BackEndSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackEndSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackEndSkills_Images_imagesId",
                        column: x => x.imagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FrontEndSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrontEndSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FrontEndSkills_Images_imagesId",
                        column: x => x.imagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil", "imagesId" },
                values: new object[] { new Guid("75e333d9-8866-42ba-92f6-86e2306052ae"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer", null });

            migrationBuilder.CreateIndex(
                name: "IX_BackEndSkills_imagesId",
                table: "BackEndSkills",
                column: "imagesId");

            migrationBuilder.CreateIndex(
                name: "IX_FrontEndSkills_imagesId",
                table: "FrontEndSkills",
                column: "imagesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackEndSkills");

            migrationBuilder.DropTable(
                name: "FrontEndSkills");

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("75e333d9-8866-42ba-92f6-86e2306052ae"));

            migrationBuilder.CreateTable(
                name: "PortfolioSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortfolioSkills_Images_imagesId",
                        column: x => x.imagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil", "imagesId" },
                values: new object[] { new Guid("478dc6ce-0fdb-4512-98ac-784576d4faa2"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer", null });

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioSkills_imagesId",
                table: "PortfolioSkills",
                column: "imagesId");
        }
    }
}
