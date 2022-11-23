﻿// <auto-generated />
using System;
using ChurchSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChurchSystem.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20221103120313_dateFormart7")]
    partial class dateFormart7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChurchSystem.Models.Adults", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Brothers")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("MeetingType")
                        .HasColumnType("integer");

                    b.Property<double>("Sisters")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Adults");
                });

            modelBuilder.Entity("ChurchSystem.Models.Children", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Brothers")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("MeetingType")
                        .HasColumnType("integer");

                    b.Property<double>("Sisters")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("ChurchSystem.Models.Tithe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("CollectionedAmount")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("MeetingType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Tithe");
                });

            modelBuilder.Entity("ChurchSystem.Models.Youths", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Brothers")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

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
