﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyIntroShop2._2.Main;

namespace MyIntroShop2._2.Migrations
{
    [DbContext(typeof(DBContent))]
    [Migration("20200204142101_add motherboards")]
    partial class addmotherboards
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyIntroShop2._2.Main.Models.Motherboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MotherboardCategoryId");

                    b.Property<string>("description");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<long>("price");

                    b.HasKey("Id");

                    b.HasIndex("MotherboardCategoryId");

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("MyIntroShop2._2.Main.Models.MotherboardCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription");

                    b.Property<string>("categoryName");

                    b.HasKey("Id");

                    b.ToTable("MotherboardCategories");
                });

            modelBuilder.Entity("MyIntroShop2._2.Main.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PhoneCategoryId");

                    b.Property<string>("description");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<long>("price");

                    b.HasKey("Id");

                    b.HasIndex("PhoneCategoryId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("MyIntroShop2._2.Main.Models.PhoneCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription");

                    b.Property<string>("categoryName");

                    b.HasKey("Id");

                    b.ToTable("PhoneCategories");
                });

            modelBuilder.Entity("MyIntroShop2._2.Main.Models.Motherboard", b =>
                {
                    b.HasOne("MyIntroShop2._2.Main.Models.MotherboardCategory", "MotherboardCategory")
                        .WithMany("motherboards")
                        .HasForeignKey("MotherboardCategoryId");
                });

            modelBuilder.Entity("MyIntroShop2._2.Main.Models.Phone", b =>
                {
                    b.HasOne("MyIntroShop2._2.Main.Models.PhoneCategory", "PhoneCategory")
                        .WithMany("phones")
                        .HasForeignKey("PhoneCategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
