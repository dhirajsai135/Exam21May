﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherAPI.Models;

namespace WeatherAPI.Migrations
{
    [DbContext(typeof(ClimateContext))]
    [Migration("20210521115435_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeatherAPI.Models.Climate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Forecast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HighTemp")
                        .HasColumnType("float");

                    b.Property<double>("LowTemp")
                        .HasColumnType("float");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("climates");
                });
#pragma warning restore 612, 618
        }
    }
}