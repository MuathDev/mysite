using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class addImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("22e794ee-be54-471b-88b3-367ff145e6c9"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PortfolioSkills");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PortfolioItems");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Owner");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PortfolioSkills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PortfolioItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_PortfolioItems_PortfolioItemId",
                        column: x => x.PortfolioItemId,
                        principalTable: "PortfolioItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_PortfolioSkills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "PortfolioSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("8a4ce6b2-c60a-44c6-9444-598f7a81407b"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });

            migrationBuilder.CreateIndex(
                name: "IX_Images_OwnerId",
                table: "Images",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PortfolioItemId",
                table: "Images",
                column: "PortfolioItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_SkillsId",
                table: "Images",
                column: "SkillsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("8a4ce6b2-c60a-44c6-9444-598f7a81407b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "PortfolioSkills",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PortfolioSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PortfolioItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("22e794ee-be54-471b-88b3-367ff145e6c9"), null, "avatar.jpg", "Muath Alobaisi", "Software Developer / Fullstack Developer" });
        }
    }
}
