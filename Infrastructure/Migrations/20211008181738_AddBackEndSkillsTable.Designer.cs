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
    [Migration("20211008181738_AddBackEndSkillsTable")]
    partial class AddBackEndSkillsTable
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

            modelBuilder.Entity("Core.Entities.BackEndSkills", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalSkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("imagesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("imagesId");

                    b.ToTable("BackEndSkills");
                });

            modelBuilder.Entity("Core.Entities.FrontEndSkills", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalSkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("imagesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("imagesId");

                    b.ToTable("FrontEndSkills");
                });

            modelBuilder.Entity("Core.Entities.Images", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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

                    b.Property<Guid?>("imagesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("imagesId");

                    b.ToTable("Owner");

                    b.HasData(
                        new
                        {
                            Id = new Guid("75e333d9-8866-42ba-92f6-86e2306052ae"),
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

                    b.Property<Guid?>("imagesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("imagesId");

                    b.ToTable("PortfolioItems");
                });

            modelBuilder.Entity("Core.Entities.BackEndSkills", b =>
                {
                    b.HasOne("Core.Entities.Images", "images")
                        .WithMany()
                        .HasForeignKey("imagesId");

                    b.Navigation("images");
                });

            modelBuilder.Entity("Core.Entities.FrontEndSkills", b =>
                {
                    b.HasOne("Core.Entities.Images", "images")
                        .WithMany()
                        .HasForeignKey("imagesId");

                    b.Navigation("images");
                });

            modelBuilder.Entity("Core.Entities.Owner", b =>
                {
                    b.HasOne("Core.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Core.Entities.Images", "images")
                        .WithMany()
                        .HasForeignKey("imagesId");

                    b.Navigation("Address");

                    b.Navigation("images");
                });

            modelBuilder.Entity("Core.Entities.PortfolioItem", b =>
                {
                    b.HasOne("Core.Entities.Images", "images")
                        .WithMany()
                        .HasForeignKey("imagesId");

                    b.Navigation("images");
                });
#pragma warning restore 612, 618
        }
    }
}
