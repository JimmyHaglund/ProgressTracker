﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarframeProgressTrackerApi.Data;

namespace WarframeProgressTrackerApi.Migrations
{
    [DbContext(typeof(WarframeProgressTrackerContext))]
    [Migration("20210629064724_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WarframeProgressTrackerApi.Models.Frame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Armor")
                        .HasColumnType("int");

                    b.Property<string>("AuraPolarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Energy")
                        .HasColumnType("int");

                    b.Property<string>("ExilusPolarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Polarities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Shield")
                        .HasColumnType("int");

                    b.Property<float>("SprintSpeed")
                        .HasColumnType("real");

                    b.Property<int>("SubsumedAbility")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Frames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Armor = 100,
                            AuraPolarity = "A",
                            Energy = 100,
                            ExilusPolarity = "E",
                            Health = 110,
                            Name = "Excalibur",
                            Polarities = "UAF",
                            Shield = 50,
                            SprintSpeed = 1f,
                            SubsumedAbility = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
