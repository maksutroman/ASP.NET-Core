﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBlog.Entityes;

namespace MyBlog.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20200212075315_Blog")]
    partial class Blog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyBlog.Models.BlogModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("author")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("fullPost")
                        .IsRequired();

                    b.Property<string>("img");

                    b.Property<string>("preview")
                        .IsRequired();

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("Blog");
                });
#pragma warning restore 612, 618
        }
    }
}
