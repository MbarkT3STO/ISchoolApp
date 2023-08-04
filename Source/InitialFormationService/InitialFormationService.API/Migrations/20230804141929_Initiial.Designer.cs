﻿// <auto-generated />
using System;
using InitialFormationService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InitialFormationService.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230804141929_Initiial")]
    partial class Initiial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InitialFormationService.Infrastructure.Data.Entities.AcademicYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsEnded")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("AcademicYears");
                });

            modelBuilder.Entity("InitialFormationService.Infrastructure.Data.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int>("DiplomaLevelId")
                        .HasColumnType("integer");

                    b.Property<byte>("FormativeMonths")
                        .HasColumnType("smallint");

                    b.Property<byte>("FormativeYears")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaLevelId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Branches", null, t =>
                        {
                            t.HasCheckConstraint("CK_Branch_FormativeMonths", "\"FormativeMonths\">= 0");

                            t.HasCheckConstraint("CK_Branch_FormativeYears", "\"FormativeYears\">= 0");
                        });
                });

            modelBuilder.Entity("InitialFormationService.Infrastructure.Data.Entities.DiplomaLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("DiplomaLevels");
                });

            modelBuilder.Entity("InitialFormationService.Infrastructure.Data.Entities.Branch", b =>
                {
                    b.HasOne("InitialFormationService.Infrastructure.Data.Entities.DiplomaLevel", "DiplomaLevel")
                        .WithMany("Branches")
                        .HasForeignKey("DiplomaLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiplomaLevel");
                });

            modelBuilder.Entity("InitialFormationService.Infrastructure.Data.Entities.DiplomaLevel", b =>
                {
                    b.Navigation("Branches");
                });
#pragma warning restore 612, 618
        }
    }
}
