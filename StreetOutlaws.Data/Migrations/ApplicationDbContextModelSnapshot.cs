﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StreetOutlaws.Data.Context;

#nullable disable

namespace StreetOutlaws.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StreetOutlaws.Data.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("StreetOutlaws.Data.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "DeJuan Colbert",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Zachary Himes",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Jordan Hershberger",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Brody Hinton",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Darneisha Miller",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cory Smith",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Jamie Coakley",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Michael Kinsey",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Celio Arias",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Cassandra Emery",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 11,
                            Name = "Catlin Simon",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 12,
                            Name = "Terry Brown",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 13,
                            Name = "Nelson Fant IV",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 14,
                            Name = "Charles Lipperd",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 15,
                            Name = "Adam Lair",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 16,
                            Name = "Katelyn Hedlund",
                            TeamId = 4
                        });
                });

            modelBuilder.Entity("StreetOutlaws.Data.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fire"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Water"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wind"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Earth"
                        });
                });

            modelBuilder.Entity("StreetOutlaws.Data.Entities.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("StreetOutlaws.Data.Entities.Car", b =>
                {
                    b.HasOne("StreetOutlaws.Data.Entities.Driver", "Driver")
                        .WithMany("Cars")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("StreetOutlaws.Data.Entities.Driver", b =>
                {
                    b.HasOne("StreetOutlaws.Data.Entities.Team", "Team")
                        .WithMany("Drivers")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("StreetOutlaws.Data.Entities.Driver", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("StreetOutlaws.Data.Entities.Team", b =>
                {
                    b.Navigation("Drivers");
                });
#pragma warning restore 612, 618
        }
    }
}
