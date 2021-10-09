﻿// <auto-generated />
using System;
using Infastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211008163659_addImagesTable")]
    partial class addImagesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Core.Entities.Images", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PortfolioItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PortfolioItemId");

                    b.HasIndex("SkillsId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Core.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Owner");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a4ce6b2-c60a-44c6-9444-598f7a81407b"),
                            FullName = "Muath Alobaisi",
                            Profil = "Software Developer / Fullstack Developer"
                        });
                });

            modelBuilder.Entity("Core.Entities.PortfolioItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PortfolioItems");
                });

            modelBuilder.Entity("Core.Entities.PortfolioSkills", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalSkill")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PortfolioSkills");
                });

            modelBuilder.Entity("Core.Entities.Images", b =>
                {
                    b.HasOne("Core.Entities.Owner", "owner")
                        .WithMany("Images")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.PortfolioItem", "PortfolioItem")
                        .WithMany("Images")
                        .HasForeignKey("PortfolioItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.PortfolioSkills", "Skills")
                        .WithMany("Images")
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("owner");

                    b.Navigation("PortfolioItem");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("Core.Entities.Owner", b =>
                {
                    b.HasOne("Core.Entities.Address", "Address")
                        .WithMany("owner")
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Core.Entities.Address", b =>
                {
                    b.Navigation("owner");
                });

            modelBuilder.Entity("Core.Entities.Owner", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Core.Entities.PortfolioItem", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Core.Entities.PortfolioSkills", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
