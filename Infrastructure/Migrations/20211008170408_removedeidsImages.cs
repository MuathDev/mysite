using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class removedeidsImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Owner_OwnerId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_PortfolioItems_PortfolioItemId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_PortfolioSkills_SkillsId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("cd8c4f52-5f81-45c0-b777-63cbbd5cbe07"));

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Images",
                newName: "ownerId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_OwnerId",
                table: "Images",
                newName: "IX_Images_ownerId");

            migrationBuilder.AlterColumn<Guid>(
                name: "SkillsId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "PortfolioItemId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "ownerId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("21dde688-b776-4019-97bc-39508550e737"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("21dde688-b776-4019-97bc-39508550e737"));

            migrationBuilder.RenameColumn(
                name: "ownerId",
                table: "Images",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ownerId",
                table: "Images",
                newName: "IX_Images_OwnerId");

            migrationBuilder.AlterColumn<Guid>(
                name: "OwnerId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SkillsId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PortfolioItemId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "FullName", "Profil" },
                values: new object[] { new Guid("cd8c4f52-5f81-45c0-b777-63cbbd5cbe07"), null, "Muath Alobaisi", "Software Developer / Fullstack Developer" });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Owner_OwnerId",
                table: "Images",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_PortfolioItems_PortfolioItemId",
                table: "Images",
                column: "PortfolioItemId",
                principalTable: "PortfolioItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_PortfolioSkills_SkillsId",
                table: "Images",
                column: "SkillsId",
                principalTable: "PortfolioSkills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
