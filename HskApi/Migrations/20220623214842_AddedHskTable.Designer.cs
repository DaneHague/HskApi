﻿// <auto-generated />
using System;
using Hski.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HskApi.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20220623214842_AddedHskTable")]
    partial class AddedHskTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HskApi.Models.HskDetails", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Hanzi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HskLevel")
                        .HasColumnType("int");

                    b.Property<string>("Pinyin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HskDetails");
                });

            modelBuilder.Entity("HskApi.Models.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("test1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
