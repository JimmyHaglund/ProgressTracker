﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarframeProgressTrackerApi.Data;

namespace WarframeProgressTrackerApi.Migrations
{
    [DbContext(typeof(WarframeProgressTrackerContext))]
    partial class WarframeProgressTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<float>("ArmorMaxFactor")
                        .HasColumnType("real");

                    b.Property<string>("AuraPolarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Energy")
                        .HasColumnType("int");

                    b.Property<float>("EnergyMaxFactor")
                        .HasColumnType("real");

                    b.Property<string>("ExilusPolarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<float>("HealthMaxFactor")
                        .HasColumnType("real");

                    b.Property<int>("MasteryRankRequired")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Polarities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Shield")
                        .HasColumnType("int");

                    b.Property<float>("ShieldMaxFactor")
                        .HasColumnType("real");

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
                            Armor = 225,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "",
                            Energy = 100,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Excalibur",
                            Polarities = "DV",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 2,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "V",
                            Energy = 100,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 150,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Ash",
                            Polarities = "VV",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.15f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 3,
                            Armor = 450,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "V",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Atlas",
                            Polarities = "BDV",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 0.9f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 4,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "V",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Banshee",
                            Polarities = "VV",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 5,
                            Armor = 175,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 200,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "B",
                            Health = 75,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Baruuk",
                            Polarities = "DD",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.2f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 6,
                            Armor = 350,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "V",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Chroma",
                            Polarities = "BV",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 7,
                            Armor = 125,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "V",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Ember",
                            Polarities = "BB",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 8,
                            Armor = 125,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Equinox",
                            Polarities = "DV",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.15f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 9,
                            Armor = 300,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "D",
                            Energy = 100,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Frost",
                            Polarities = "BD",
                            Shield = 150,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 0.9f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 10,
                            Armor = 150,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "D",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Gara",
                            Polarities = "VV",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.15f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 11,
                            Armor = 300,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "V",
                            Energy = 120,
                            EnergyMaxFactor = 2.25f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Garuda",
                            Polarities = "BD",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 12,
                            Armor = 175,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "B",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Gauss",
                            Polarities = "VD",
                            Shield = 150,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.4f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 13,
                            Armor = 350,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 350,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Grendel",
                            Polarities = "BDD",
                            Shield = 25,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 0.95f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 14,
                            Armor = 175,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 100,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Harrow",
                            Polarities = "DB",
                            Shield = 150,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 15,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 0,
                            EnergyMaxFactor = 0f,
                            ExilusPolarity = "D",
                            Health = 75,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Hildryn",
                            Polarities = "DD",
                            Shield = 450,
                            ShieldMaxFactor = 3.5f,
                            SprintSpeed = 1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 16,
                            Armor = 225,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 125,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Hydroid",
                            Polarities = "VB",
                            Shield = 125,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.05f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 17,
                            Armor = 225,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 100,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "B",
                            Health = 550,
                            HealthMaxFactor = 4f,
                            MasteryRankRequired = 0,
                            Name = "Inaros",
                            Polarities = "DD",
                            Shield = 0,
                            ShieldMaxFactor = 0f,
                            SprintSpeed = 1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 18,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 175,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 75,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Ivara",
                            Polarities = "DB",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.15f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 19,
                            Armor = 275,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "D",
                            Energy = 125,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "B",
                            Health = 125,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Khora",
                            Polarities = "VB",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.05f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 20,
                            Armor = 450,
                            ArmorMaxFactor = 1.5f,
                            AuraPolarity = "B",
                            Energy = 0,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 200,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Lavos",
                            Polarities = "DB",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.15f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 21,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Limbo",
                            Polarities = "VV",
                            Shield = 75,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.15f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 22,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 100,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 75,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Loki",
                            Polarities = "DV",
                            Shield = 75,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.25f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 23,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "V",
                            Energy = 125,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 75,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Mag",
                            Polarities = "BB",
                            Shield = 150,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.25f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 24,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "V",
                            Energy = 100,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 125,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Mesa",
                            Polarities = "BB",
                            Shield = 75,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 25,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 80,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Mirage",
                            Polarities = "DV",
                            Shield = 80,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.2f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 26,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "",
                            Energy = 100,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Nekros",
                            Polarities = "BV",
                            Shield = 90,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 27,
                            Armor = 190,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 125,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Nezha",
                            Polarities = "DV",
                            Shield = 50,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.15f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 28,
                            Armor = 300,
                            ArmorMaxFactor = 1.5f,
                            AuraPolarity = "V",
                            Energy = 100,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 150,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Nidus",
                            Polarities = "VD",
                            Shield = 0,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 29,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Nova",
                            Polarities = "VV",
                            Shield = 75,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.2f,
                            SubsumedAbility = 0
                        },
                        new
                        {
                            Id = 30,
                            Armor = 100,
                            ArmorMaxFactor = 1f,
                            AuraPolarity = "B",
                            Energy = 150,
                            EnergyMaxFactor = 1.5f,
                            ExilusPolarity = "",
                            Health = 100,
                            HealthMaxFactor = 3f,
                            MasteryRankRequired = 0,
                            Name = "Nyx",
                            Polarities = "VB",
                            Shield = 100,
                            ShieldMaxFactor = 3f,
                            SprintSpeed = 1.1f,
                            SubsumedAbility = 0
                        });
                });

            modelBuilder.Entity("WarframeProgressTrackerApi.Models.PrimaryWeapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Accuracy")
                        .HasColumnType("real");

                    b.Property<string>("AmmoType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Disposition")
                        .HasColumnType("real");

                    b.Property<float>("FireRate")
                        .HasColumnType("real");

                    b.Property<int>("MagazineSize")
                        .HasColumnType("int");

                    b.Property<int>("MasteryRankRequired")
                        .HasColumnType("int");

                    b.Property<int>("MaxAmmo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ReloadSeconds")
                        .HasColumnType("real");

                    b.Property<string>("TriggerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeaponType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PrimaryWeapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Accuracy = 25f,
                            AmmoType = "Arm Cannon",
                            Disposition = 0.7f,
                            FireRate = 3.83f,
                            MagazineSize = 27,
                            MasteryRankRequired = 0,
                            MaxAmmo = 0,
                            Name = "Bubunico",
                            ProjectileType = "Projectile",
                            ReloadSeconds = 16.875f,
                            TriggerType = "Auto",
                            WeaponType = "Arm Cannon"
                        },
                        new
                        {
                            Id = 2,
                            Accuracy = 23.5f,
                            AmmoType = "Rifle",
                            Disposition = 0.6f,
                            FireRate = 12f,
                            MagazineSize = 48,
                            MasteryRankRequired = 8,
                            MaxAmmo = 96,
                            Name = "Acceltra",
                            ProjectileType = "Projectile",
                            ReloadSeconds = 2f,
                            TriggerType = "Auto",
                            WeaponType = "Rifle"
                        },
                        new
                        {
                            Id = 3,
                            Accuracy = 9.1f,
                            AmmoType = "Shotgun",
                            Disposition = 0.9f,
                            FireRate = 1.42f,
                            MagazineSize = 20,
                            MasteryRankRequired = 14,
                            MaxAmmo = 120,
                            Name = "Corinth",
                            ProjectileType = "Hit Scan",
                            ReloadSeconds = 3f,
                            TriggerType = "Semi-Auto",
                            WeaponType = "Shotgun"
                        });
                });

            modelBuilder.Entity("WarframeProgressTrackerApi.Models.SecondaryWeapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Accuracy")
                        .HasColumnType("real");

                    b.Property<string>("AmmoType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Disposition")
                        .HasColumnType("real");

                    b.Property<float>("FireRate")
                        .HasColumnType("real");

                    b.Property<int>("MagazineSize")
                        .HasColumnType("int");

                    b.Property<int>("MasteryRankRequired")
                        .HasColumnType("int");

                    b.Property<int>("MaxAmmo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ReloadSeconds")
                        .HasColumnType("real");

                    b.Property<string>("TriggerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeaponType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SecondaryWeapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Accuracy = 33.33f,
                            AmmoType = "Pistol",
                            Disposition = 1.52f,
                            FireRate = 8.33f,
                            MagazineSize = 60,
                            MasteryRankRequired = 4,
                            MaxAmmo = 420,
                            Name = "Cestra",
                            ProjectileType = "Projectile",
                            ReloadSeconds = 2f,
                            TriggerType = "Auto",
                            WeaponType = "Pistol"
                        },
                        new
                        {
                            Id = 2,
                            Accuracy = 16f,
                            AmmoType = "Pistol",
                            Disposition = 1.25f,
                            FireRate = 1.08f,
                            MagazineSize = 6,
                            MasteryRankRequired = 3,
                            MaxAmmo = 210,
                            Name = "Lex",
                            ProjectileType = "Hit Scan",
                            ReloadSeconds = 2.35f,
                            TriggerType = "Semi-Auto",
                            WeaponType = "Pistol"
                        },
                        new
                        {
                            Id = 3,
                            Accuracy = 5f,
                            AmmoType = "Shotgun Sidearm",
                            Disposition = 0.95f,
                            FireRate = 4.17f,
                            MagazineSize = 10,
                            MasteryRankRequired = 12,
                            MaxAmmo = 210,
                            Name = "Pyrana",
                            ProjectileType = "Hit Scan",
                            ReloadSeconds = 2f,
                            TriggerType = "Auto",
                            WeaponType = "Shotgun Sidearm"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
