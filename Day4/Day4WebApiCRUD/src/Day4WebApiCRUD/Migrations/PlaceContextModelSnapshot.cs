using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Day4WebApiCRUD.Models;

namespace Day4WebApiCRUD.Migrations
{
    [DbContext(typeof(PlaceContext))]
    partial class PlaceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Day4WebApiCRUD.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cost");

                    b.Property<int?>("RailcarId");

                    b.HasKey("Id");

                    b.HasIndex("RailcarId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("Day4WebApiCRUD.Models.Railcar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RailcarNum");

                    b.Property<int>("TrainId");

                    b.HasKey("Id");

                    b.HasIndex("TrainId");

                    b.ToTable("Railcars");
                });

            modelBuilder.Entity("Day4WebApiCRUD.Models.Train", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TrainNum");

                    b.HasKey("Id");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("Day4WebApiCRUD.Models.Place", b =>
                {
                    b.HasOne("Day4WebApiCRUD.Models.Railcar", "Railcar")
                        .WithMany("Places")
                        .HasForeignKey("RailcarId");
                });

            modelBuilder.Entity("Day4WebApiCRUD.Models.Railcar", b =>
                {
                    b.HasOne("Day4WebApiCRUD.Models.Train", "Train")
                        .WithMany("Railcars")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
