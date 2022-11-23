﻿// <auto-generated />
using System;
using DclmChilangaSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DclmChilangaSystem.Migrations
{
    [DbContext(typeof(APIContext))]
    partial class APIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DclmChilangaSystem.Models.Adults", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Brothers")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MeetingType")
                        .HasColumnType("integer");

                    b.Property<double>("Sisters")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Adults");
                });

            modelBuilder.Entity("DclmChilangaSystem.Models.Children", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Brothers")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MeetingType")
                        .HasColumnType("integer");

                    b.Property<double>("Sisters")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("DclmChilangaSystem.Models.Tithe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("CollectedAmount")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MeetingType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Tithe");
                });

            modelBuilder.Entity("DclmChilangaSystem.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserName");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DclmChilangaSystem.Models.Youths", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Brothers")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MeetingType")
                        .HasColumnType("integer");

                    b.Property<double>("Sisters")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Youths");
                });
#pragma warning restore 612, 618
        }
    }
}
