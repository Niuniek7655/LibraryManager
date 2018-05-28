﻿// <auto-generated />
using DAL.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Shared;
using System;

namespace DAL.Migrations
{
    [DbContext(typeof(ContexDb))]
    [Migration("20180528175416_CorrectUserMigration")]
    partial class CorrectUserMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Models.EntityModels.HireHistory", b =>
                {
                    b.Property<int>("HireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("HireId");

                    b.ToTable("HireHistory");
                });

            modelBuilder.Entity("DAL.Models.EntityModels.Mediums", b =>
                {
                    b.Property<int>("MediumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("HireHistoryHireId");

                    b.Property<int>("MediumType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("MediumId");

                    b.HasIndex("HireHistoryHireId");

                    b.ToTable("Mediums");
                });

            modelBuilder.Entity("DAL.Models.EntityModels.StoragePlaces", b =>
                {
                    b.Property<int>("StoragePlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("HireHistoryHireId");

                    b.Property<int?>("MediumsMediumId");

                    b.Property<string>("StoragePlaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool>("StorageStatus")
                        .HasColumnType("bit");

                    b.HasKey("StoragePlaceId");

                    b.HasIndex("HireHistoryHireId");

                    b.HasIndex("MediumsMediumId");

                    b.ToTable("StoragePlaces");
                });

            modelBuilder.Entity("DAL.Models.EntityModels.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(253)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("Permissions");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)");

                    b.Property<int?>("StoragePlacesStoragePlaceId");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UserId");

                    b.HasIndex("StoragePlacesStoragePlaceId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.Models.EntityModels.Mediums", b =>
                {
                    b.HasOne("DAL.Models.EntityModels.HireHistory")
                        .WithMany("MediumId")
                        .HasForeignKey("HireHistoryHireId");
                });

            modelBuilder.Entity("DAL.Models.EntityModels.StoragePlaces", b =>
                {
                    b.HasOne("DAL.Models.EntityModels.HireHistory")
                        .WithMany("StoragePlaceId")
                        .HasForeignKey("HireHistoryHireId");

                    b.HasOne("DAL.Models.EntityModels.Mediums")
                        .WithMany("StoragePlaces")
                        .HasForeignKey("MediumsMediumId");
                });

            modelBuilder.Entity("DAL.Models.EntityModels.Users", b =>
                {
                    b.HasOne("DAL.Models.EntityModels.StoragePlaces")
                        .WithMany("UserId")
                        .HasForeignKey("StoragePlacesStoragePlaceId");
                });
#pragma warning restore 612, 618
        }
    }
}
