using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class removedeidsImages3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Owner_ownerId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_PortfolioItems_PortfolioItemId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_PortfolioSkills_SkillsId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ownerId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_PortfolioItemId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_SkillsId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("4c1fb730-9882-4600-89e9-2833c0402c49"));

            migrationBuilder.DropColumn(
                name: "PortfolioItemId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "SkillsId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ownerId",
                table: "Images");

            migrationBuilder.AddColumn<Guid>(
                name: "imagesId",
                table: "PortfolioSkills",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "imagesId",
                table: "PortfolioItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "imagesId",
                table: "Owner",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil", "imagesId" },
                values: new object[] { new Guid("478dc6ce-0fdb-4512-98ac-784576d4faa2"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer", null });

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioSkills_imagesId",
                table: "PortfolioSkills",
                column: "imagesId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioItems_imagesId",
                table: "PortfolioItems",
                column: "imagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_imagesId",
                table: "Owner",
                column: "imagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_Images_imagesId",
                table: "Owner",
                column: "imagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioItems_Images_imagesId",
                table: "PortfolioItems",
                column: "imagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioSkills_Images_imagesId",
                table: "PortfolioSkills",
                column: "imagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Images_imagesId",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioItems_Images_imagesId",
                table: "PortfolioItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioSkills_Images_imagesId",
                table: "PortfolioSkills");

            migrationBuilder.DropIndex(
                name: "IX_PortfolioSkills_imagesId",
                table: "PortfolioSkills");

            migrationBuilder.DropIndex(
                name: "IX_PortfolioItems_imagesId",
                table: "PortfolioItems");

            migrationBuilder.DropIndex(
                name: "IX_Owner_imagesId",
                table: "Owner");

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("478dc6ce-0fdb-4512-98ac-784576d4faa2"));

            migrationBuilder.DropColumn(
                name: "imagesId",
                table: "PortfolioSkills");

            migrationBuilder.DropColumn(
                name: "imagesId",
                table: "PortfolioItems");

            migrationBuilder.DropColumn(
                name: "imagesId",
                table: "Owner");

            migrationBuilder.AddColumn<Guid>(
                name: "PortfolioItemId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SkillsId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ownerId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("4c1fb730-9882-4600-89e9-2833c0402c49"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ownerId",
                table: "Images",
                column: "ownerId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PortfolioItemId",
                table: "Images",
                column: "PortfolioItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_SkillsId",
                table: "Images",
                column: "SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Owner_ownerId",
                table: "Images",
                column: "ownerId",
                principalTable: "Owner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_PortfolioItems_PortfolioItemId",
                table: "Images",
                column: "PortfolioItemId",
                principalTable: "PortfolioItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_PortfolioSkills_SkillsId",
                table: "Images",
                column: "SkillsId",
                principalTable: "PortfolioSkills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
